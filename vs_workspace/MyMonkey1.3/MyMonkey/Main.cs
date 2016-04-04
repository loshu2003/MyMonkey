using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Text.RegularExpressions;

namespace MyMonkey
{
    public partial class Main : Form
    {
        ArrayList argsList = new ArrayList();

        public Main()
        {
            InitializeComponent();
        }

        public string ConsoleTxt
        {
            get { return consoleTxt.Text; }
            set { consoleTxt.Text = value; }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            //return controls.SelectMany(ctrl => GetAll(ctrl, type))
            //                          .Concat(controls)
            //                          .Where(c => c.GetType() == type)
            //                          .OrderBy(c => c.TabIndex);

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.Tag != null)
                                      .OrderBy(c => c.TabIndex);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(deviceIDCbx.Text))
            {
                MessageBox.Show("设备ID不能为空");
                return;
            }
            

            this.argsList.Clear();
            this.argsList.Add("shell monkey");
            var argCtlsList = GetAll(this, typeof(TextBox)).ToList();
            var length = argCtlsList.Count;

            for (int i = 0; i < length; i++)
            {
                this.setPar(argCtlsList[i]);
            }

            string agrs = string.Join(" ", argsList.ToArray());

            Monkey monkey = new Monkey(agrs);
            monkey.run();
            consoleTxt.Text = monkey.Log;
        }

        /***
         *配合monkey日志输出功能
         ***/
        /*
        delegate void setTextCallback(string text);

        public void setText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.consoleTxt.InvokeRequired)
            {
                setTextCallback d = new setTextCallback(setText);
                this.Invoke(d, new object[] { text });

                //setTextCallback d = new setTextCallback(setText);
                //IAsyncResult result = this.consoleTxt.BeginInvoke(d, new object[] { text });
                //try
                //{
                //    d.EndInvoke(result);
                //}
                //catch
                //{
                //}

            }
            else
            {
                this.consoleTxt.Text += text + "\n";
            }
        }
        */

        private void setPar(Control ctl)
        {
            String ctlName = ctl.GetType().Name;
            switch (ctlName)
            {
                case "TextBox":
                    if (ctl.Text != String.Empty)
                    {
                        this.argsList.Add(ctl.Tag.ToString() + " " + ctl.Text);
                    }
                    break;
                case "RadioButton":
                    RadioButton rd = (RadioButton)ctl;
                    if(rd.Checked == true)
                    {
                        this.argsList.Add(rd.Tag.ToString());
                    }
                    break;
                case "ComboBox":
                    if (ctl.Text != String.Empty)
                    {
                        this.argsList.Insert(0, ctl.Tag.ToString() + " " + ctl.Text);
                    }
                    break;
                case "CheckBox":
                    CheckBox chk = (CheckBox)ctl;
                    if (chk.Checked == true)
                    {
                        this.argsList.Add(chk.Tag.ToString());
                    }
                    break;
            }
            
        } //setPar end.

        
        private void Main_Load(object sender, EventArgs e)
        {
            this.loadDevices();
            this.showDeviceInfo(deviceIDCbx.Items[0].ToString());

            initPackageNameTbx();
        }

        /***
         * 初始化package name textbox
         ***/
        private void initPackageNameTbx(bool isReset=false)
        {
            if(isReset)
            {
                Monkey.resetInstalledPacakges();
            }
            //先获取手机中安装的pacakge，然后给pacakge name textbox添加自动补全效果
            var packagesSrc = new AutoCompleteStringCollection();
            string[] packages = Monkey.InstalledPackages.ToArray(typeof(string)) as string[];
            packagesSrc.AddRange(packages);

            packageNameTbx.AutoCompleteCustomSource = packagesSrc;
            packageNameTbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            packageNameTbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void showDeviceInfo(string devicesId)
        {
            string args = "-s " + devicesId + " shell \"grep -E 'ro.build.version.release|ro.product.model|ro.product.brand' /system/build.prop\"";
            string devicesInfo = Command.exec("adb", args);

            string pattern = @"(?<=release\=).*";
            Match m = Regex.Match(devicesInfo, pattern);
            if (m.Success)
            {
                buildVersionLb.Text = m.Value;
            }

            pattern = @"(?<=model\=).*";
            m = Regex.Match(devicesInfo, pattern);
            if (m.Success)
            {
                productModelLb.Text = m.Value;
            }

            pattern = @"(?<=brand\=).*";
            m = Regex.Match(devicesInfo, pattern);
            if (m.Success)
            {
                productBrandLb.Text = m.Value;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            showDeviceInfo(deviceIDCbx.Items[deviceIDCbx.SelectedIndex].ToString());
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            showDeviceInfo(deviceIDCbx.Items[deviceIDCbx.SelectedIndex].ToString());
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            showDeviceInfo(deviceIDCbx.Text);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.clearCurrentDeviceInfo();
            refreshBtn.Enabled = false;
            this.loadDevices();
            this.initPackageNameTbx(true);
            refreshBtn.Enabled = true;
        }

        /***
         * 清除当前显示的设备信息
         ***/
        private void clearCurrentDeviceInfo()
        {
            deviceIDCbx.Text = String.Empty;
            if (deviceIDCbx.Items.Count > 0)
            {
                deviceIDCbx.Items.Clear();
            }
            buildVersionLb.Text = String.Empty;
            productModelLb.Text = String.Empty;
            productBrandLb.Text = String.Empty;

            deviceInfoGrp.Refresh();
        }

        /***
         * 加载所有通过USB连接到电脑的设备
         ***/
        private void loadDevices()
        {
            string devices = Command.exec("adb", "devices");
            devices = devices.Substring(devices.IndexOf("\n") + 1).TrimEnd();

            if (devices != String.Empty)
            {
                if (deviceIDCbx.Items.Count > 0)
                {
                    deviceIDCbx.Items.Clear();
                }
                string[] lines = Regex.Split(devices, "\r\n");
                foreach (string line in lines)
                {
                    deviceIDCbx.Items.Add(line.Substring(0, line.IndexOf("\t")));
                }
                deviceIDCbx.SelectedIndex = 0;
            }
        }//loadDevices method end.

        private void getCurrentFocusedPacakgeNameBtn_Click(object sender, EventArgs e)
        {
            this.getCurrentFocusedPacakgeNameBtn.Enabled = false;

            string currentFocusedPacakgeName = Monkey.getCurrentFocusedPacakgeName();
            if (!String.IsNullOrEmpty(currentFocusedPacakgeName))
            {
                packageNameTbx.Text = currentFocusedPacakgeName;
            }
            else 
            {
                MessageBox.Show("获取当前App的package name失败，检查手机与电脑是否连接成功, 再重试!");
            }

            this.getCurrentFocusedPacakgeNameBtn.Enabled = true;
        }

        
    

    }
}
