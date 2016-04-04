namespace MyMonkey
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.runBtn = new System.Windows.Forms.Button();
            this.packageNameTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eventCountTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logLevel0 = new System.Windows.Forms.RadioButton();
            this.logLevel1 = new System.Windows.Forms.RadioButton();
            this.logLevel2 = new System.Windows.Forms.RadioButton();
            this.seedTbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pctAnyeventTbx = new System.Windows.Forms.TextBox();
            this.pctSyskeysTbx = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pctAppswitchTbx = new System.Windows.Forms.TextBox();
            this.pctMajornavTbx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pctNavTbx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pctTrackballTbx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ptcMotionTbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pctTouchTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.throttleTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deviceIDCbx = new System.Windows.Forms.ComboBox();
            this.deviceInfoGrp = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buildVersionLb = new System.Windows.Forms.Label();
            this.productModelLb = new System.Windows.Forms.Label();
            this.productBrandLb = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.waitDbgChk = new System.Windows.Forms.CheckBox();
            this.monitorNativeCrashesChk = new System.Windows.Forms.CheckBox();
            this.killProcessAfterErrorChk = new System.Windows.Forms.CheckBox();
            this.ignoreSecurityExceptionsChk = new System.Windows.Forms.CheckBox();
            this.ignoreTimeoutsChk = new System.Windows.Forms.CheckBox();
            this.ignoreCrashesChk = new System.Windows.Forms.CheckBox();
            this.hprofChk = new System.Windows.Forms.CheckBox();
            this.dbgNoEventsChk = new System.Windows.Forms.CheckBox();
            this.consoleTxt = new System.Windows.Forms.TextBox();
            this.getCurrentFocusedPacakgeNameBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.deviceInfoGrp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(259, 346);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(235, 32);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "运行";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // packageNameTbx
            // 
            this.packageNameTbx.Location = new System.Drawing.Point(69, 20);
            this.packageNameTbx.Name = "packageNameTbx";
            this.packageNameTbx.Size = new System.Drawing.Size(160, 21);
            this.packageNameTbx.TabIndex = 1;
            this.packageNameTbx.Tag = "-p";
            this.packageNameTbx.Text = "com.qihoo.around";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "包名(-p)：";
            // 
            // eventCountTbx
            // 
            this.eventCountTbx.Location = new System.Drawing.Point(69, 82);
            this.eventCountTbx.Name = "eventCountTbx";
            this.eventCountTbx.Size = new System.Drawing.Size(160, 21);
            this.eventCountTbx.TabIndex = 24;
            this.eventCountTbx.Tag = "";
            this.eventCountTbx.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "事件数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "种子(-s)：";
            // 
            // logLevel0
            // 
            this.logLevel0.AutoSize = true;
            this.logLevel0.Location = new System.Drawing.Point(97, 138);
            this.logLevel0.Name = "logLevel0";
            this.logLevel0.Size = new System.Drawing.Size(29, 16);
            this.logLevel0.TabIndex = 4;
            this.logLevel0.Tag = "-v";
            this.logLevel0.Text = "0";
            this.logLevel0.UseVisualStyleBackColor = true;
            // 
            // logLevel1
            // 
            this.logLevel1.AutoSize = true;
            this.logLevel1.Location = new System.Drawing.Point(136, 138);
            this.logLevel1.Name = "logLevel1";
            this.logLevel1.Size = new System.Drawing.Size(29, 16);
            this.logLevel1.TabIndex = 5;
            this.logLevel1.Tag = "-v -v";
            this.logLevel1.Text = "1";
            this.logLevel1.UseVisualStyleBackColor = true;
            // 
            // logLevel2
            // 
            this.logLevel2.AutoSize = true;
            this.logLevel2.Checked = true;
            this.logLevel2.Location = new System.Drawing.Point(175, 138);
            this.logLevel2.Name = "logLevel2";
            this.logLevel2.Size = new System.Drawing.Size(29, 16);
            this.logLevel2.TabIndex = 6;
            this.logLevel2.TabStop = true;
            this.logLevel2.Tag = "-v -v -v";
            this.logLevel2.Text = "2";
            this.logLevel2.UseVisualStyleBackColor = true;
            // 
            // seedTbx
            // 
            this.seedTbx.Location = new System.Drawing.Point(69, 110);
            this.seedTbx.Name = "seedTbx";
            this.seedTbx.Size = new System.Drawing.Size(160, 21);
            this.seedTbx.TabIndex = 3;
            this.seedTbx.Tag = "-s";
            this.seedTbx.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getCurrentFocusedPacakgeNameBtn);
            this.groupBox1.Controls.Add(this.packageNameTbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.seedTbx);
            this.groupBox1.Controls.Add(this.eventCountTbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.logLevel0);
            this.groupBox1.Controls.Add(this.logLevel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.logLevel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 162);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常用参数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "日志级别(-v)：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.pctAnyeventTbx);
            this.groupBox2.Controls.Add(this.pctSyskeysTbx);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.pctAppswitchTbx);
            this.groupBox2.Controls.Add(this.pctMajornavTbx);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.pctNavTbx);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.pctTrackballTbx);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ptcMotionTbx);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pctTouchTbx);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.throttleTbx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 319);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "事件参数";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "--pct-anyevent:";
            // 
            // pctAnyeventTbx
            // 
            this.pctAnyeventTbx.Location = new System.Drawing.Point(123, 285);
            this.pctAnyeventTbx.Name = "pctAnyeventTbx";
            this.pctAnyeventTbx.Size = new System.Drawing.Size(100, 21);
            this.pctAnyeventTbx.TabIndex = 15;
            this.pctAnyeventTbx.Tag = "--pct-anyevent";
            // 
            // pctSyskeysTbx
            // 
            this.pctSyskeysTbx.Location = new System.Drawing.Point(123, 219);
            this.pctSyskeysTbx.Name = "pctSyskeysTbx";
            this.pctSyskeysTbx.Size = new System.Drawing.Size(100, 21);
            this.pctSyskeysTbx.TabIndex = 13;
            this.pctSyskeysTbx.Tag = "--pct-syskeys";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "--pct-syskeys:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "--pct-appswitch:";
            // 
            // pctAppswitchTbx
            // 
            this.pctAppswitchTbx.Location = new System.Drawing.Point(123, 252);
            this.pctAppswitchTbx.Name = "pctAppswitchTbx";
            this.pctAppswitchTbx.Size = new System.Drawing.Size(100, 21);
            this.pctAppswitchTbx.TabIndex = 14;
            this.pctAppswitchTbx.Tag = "--pct-appswitch";
            // 
            // pctMajornavTbx
            // 
            this.pctMajornavTbx.Location = new System.Drawing.Point(123, 186);
            this.pctMajornavTbx.Name = "pctMajornavTbx";
            this.pctMajornavTbx.Size = new System.Drawing.Size(100, 21);
            this.pctMajornavTbx.TabIndex = 12;
            this.pctMajornavTbx.Tag = "--pct-majornav";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "--pct-majornav:";
            // 
            // pctNavTbx
            // 
            this.pctNavTbx.Location = new System.Drawing.Point(123, 153);
            this.pctNavTbx.Name = "pctNavTbx";
            this.pctNavTbx.Size = new System.Drawing.Size(100, 21);
            this.pctNavTbx.TabIndex = 11;
            this.pctNavTbx.Tag = "--pct-nav";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "--pct-nav:";
            // 
            // pctTrackballTbx
            // 
            this.pctTrackballTbx.Location = new System.Drawing.Point(123, 120);
            this.pctTrackballTbx.Name = "pctTrackballTbx";
            this.pctTrackballTbx.Size = new System.Drawing.Size(100, 21);
            this.pctTrackballTbx.TabIndex = 10;
            this.pctTrackballTbx.Tag = "--pct-trackball";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "--pct-trackball:";
            // 
            // ptcMotionTbx
            // 
            this.ptcMotionTbx.Location = new System.Drawing.Point(123, 87);
            this.ptcMotionTbx.Name = "ptcMotionTbx";
            this.ptcMotionTbx.Size = new System.Drawing.Size(100, 21);
            this.ptcMotionTbx.TabIndex = 9;
            this.ptcMotionTbx.Tag = "--pct-motion";
            this.ptcMotionTbx.Text = "40";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "--pct-motion:";
            // 
            // pctTouchTbx
            // 
            this.pctTouchTbx.Location = new System.Drawing.Point(123, 54);
            this.pctTouchTbx.Name = "pctTouchTbx";
            this.pctTouchTbx.Size = new System.Drawing.Size(100, 21);
            this.pctTouchTbx.TabIndex = 8;
            this.pctTouchTbx.Tag = "--pct-touch";
            this.pctTouchTbx.Text = "60";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "--pct-touch:";
            // 
            // throttleTbx
            // 
            this.throttleTbx.Location = new System.Drawing.Point(123, 21);
            this.throttleTbx.Name = "throttleTbx";
            this.throttleTbx.Size = new System.Drawing.Size(100, 21);
            this.throttleTbx.TabIndex = 7;
            this.throttleTbx.Tag = "--throttle";
            this.throttleTbx.Text = "300";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "--throttle:";
            // 
            // deviceIDCbx
            // 
            this.deviceIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceIDCbx.FormattingEnabled = true;
            this.deviceIDCbx.Location = new System.Drawing.Point(14, 42);
            this.deviceIDCbx.Name = "deviceIDCbx";
            this.deviceIDCbx.Size = new System.Drawing.Size(200, 20);
            this.deviceIDCbx.TabIndex = 0;
            this.deviceIDCbx.Tag = "-s";
            this.deviceIDCbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.deviceIDCbx.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.deviceIDCbx.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // deviceInfoGrp
            // 
            this.deviceInfoGrp.Controls.Add(this.label19);
            this.deviceInfoGrp.Controls.Add(this.label18);
            this.deviceInfoGrp.Controls.Add(this.deviceIDCbx);
            this.deviceInfoGrp.Controls.Add(this.label17);
            this.deviceInfoGrp.Controls.Add(this.label16);
            this.deviceInfoGrp.Controls.Add(this.buildVersionLb);
            this.deviceInfoGrp.Controls.Add(this.productModelLb);
            this.deviceInfoGrp.Controls.Add(this.productBrandLb);
            this.deviceInfoGrp.Location = new System.Drawing.Point(12, 180);
            this.deviceInfoGrp.Name = "deviceInfoGrp";
            this.deviceInfoGrp.Size = new System.Drawing.Size(235, 151);
            this.deviceInfoGrp.TabIndex = 8;
            this.deviceInfoGrp.TabStop = false;
            this.deviceInfoGrp.Text = "设备信息";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 14;
            this.label19.Text = "设备ID(-s)：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 12);
            this.label18.TabIndex = 13;
            this.label18.Text = "Android版本：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "型号：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "品牌：";
            // 
            // buildVersionLb
            // 
            this.buildVersionLb.AutoSize = true;
            this.buildVersionLb.Location = new System.Drawing.Point(101, 123);
            this.buildVersionLb.Name = "buildVersionLb";
            this.buildVersionLb.Size = new System.Drawing.Size(35, 12);
            this.buildVersionLb.TabIndex = 10;
            this.buildVersionLb.Text = "11111";
            // 
            // productModelLb
            // 
            this.productModelLb.AutoSize = true;
            this.productModelLb.Location = new System.Drawing.Point(59, 97);
            this.productModelLb.Name = "productModelLb";
            this.productModelLb.Size = new System.Drawing.Size(47, 12);
            this.productModelLb.TabIndex = 10;
            this.productModelLb.Text = "1111111";
            // 
            // productBrandLb
            // 
            this.productBrandLb.AutoSize = true;
            this.productBrandLb.Location = new System.Drawing.Point(59, 69);
            this.productBrandLb.Name = "productBrandLb";
            this.productBrandLb.Size = new System.Drawing.Size(41, 12);
            this.productBrandLb.TabIndex = 10;
            this.productBrandLb.Text = "111111";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 346);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(235, 32);
            this.refreshBtn.TabIndex = 15;
            this.refreshBtn.Text = "刷新";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.waitDbgChk);
            this.groupBox4.Controls.Add(this.monitorNativeCrashesChk);
            this.groupBox4.Controls.Add(this.killProcessAfterErrorChk);
            this.groupBox4.Controls.Add(this.ignoreSecurityExceptionsChk);
            this.groupBox4.Controls.Add(this.ignoreTimeoutsChk);
            this.groupBox4.Controls.Add(this.ignoreCrashesChk);
            this.groupBox4.Controls.Add(this.hprofChk);
            this.groupBox4.Controls.Add(this.dbgNoEventsChk);
            this.groupBox4.Location = new System.Drawing.Point(506, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 319);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "调试参数";
            // 
            // waitDbgChk
            // 
            this.waitDbgChk.AutoSize = true;
            this.waitDbgChk.Location = new System.Drawing.Point(21, 285);
            this.waitDbgChk.Name = "waitDbgChk";
            this.waitDbgChk.Size = new System.Drawing.Size(84, 16);
            this.waitDbgChk.TabIndex = 23;
            this.waitDbgChk.Tag = "--wait-dbg";
            this.waitDbgChk.Text = "--wait-dbg";
            this.waitDbgChk.UseVisualStyleBackColor = true;
            // 
            // monitorNativeCrashesChk
            // 
            this.monitorNativeCrashesChk.AutoSize = true;
            this.monitorNativeCrashesChk.Location = new System.Drawing.Point(21, 248);
            this.monitorNativeCrashesChk.Name = "monitorNativeCrashesChk";
            this.monitorNativeCrashesChk.Size = new System.Drawing.Size(168, 16);
            this.monitorNativeCrashesChk.TabIndex = 22;
            this.monitorNativeCrashesChk.Tag = "--monitor-native-crashes";
            this.monitorNativeCrashesChk.Text = "--monitor-native-crashes";
            this.monitorNativeCrashesChk.UseVisualStyleBackColor = true;
            // 
            // killProcessAfterErrorChk
            // 
            this.killProcessAfterErrorChk.AutoSize = true;
            this.killProcessAfterErrorChk.Location = new System.Drawing.Point(21, 211);
            this.killProcessAfterErrorChk.Name = "killProcessAfterErrorChk";
            this.killProcessAfterErrorChk.Size = new System.Drawing.Size(180, 16);
            this.killProcessAfterErrorChk.TabIndex = 21;
            this.killProcessAfterErrorChk.Tag = "--kill-process-after-error";
            this.killProcessAfterErrorChk.Text = "--kill-process-after-error";
            this.killProcessAfterErrorChk.UseVisualStyleBackColor = true;
            // 
            // ignoreSecurityExceptionsChk
            // 
            this.ignoreSecurityExceptionsChk.AutoSize = true;
            this.ignoreSecurityExceptionsChk.Location = new System.Drawing.Point(21, 174);
            this.ignoreSecurityExceptionsChk.Name = "ignoreSecurityExceptionsChk";
            this.ignoreSecurityExceptionsChk.Size = new System.Drawing.Size(192, 16);
            this.ignoreSecurityExceptionsChk.TabIndex = 20;
            this.ignoreSecurityExceptionsChk.Tag = "--ignore-security-exceptions";
            this.ignoreSecurityExceptionsChk.Text = "--ignore-security-exceptions";
            this.ignoreSecurityExceptionsChk.UseVisualStyleBackColor = true;
            // 
            // ignoreTimeoutsChk
            // 
            this.ignoreTimeoutsChk.AutoSize = true;
            this.ignoreTimeoutsChk.Location = new System.Drawing.Point(21, 137);
            this.ignoreTimeoutsChk.Name = "ignoreTimeoutsChk";
            this.ignoreTimeoutsChk.Size = new System.Drawing.Size(126, 16);
            this.ignoreTimeoutsChk.TabIndex = 19;
            this.ignoreTimeoutsChk.Tag = "--ignore-timeouts";
            this.ignoreTimeoutsChk.Text = "--ignore-timeouts";
            this.ignoreTimeoutsChk.UseVisualStyleBackColor = true;
            // 
            // ignoreCrashesChk
            // 
            this.ignoreCrashesChk.AutoSize = true;
            this.ignoreCrashesChk.Location = new System.Drawing.Point(21, 100);
            this.ignoreCrashesChk.Name = "ignoreCrashesChk";
            this.ignoreCrashesChk.Size = new System.Drawing.Size(120, 16);
            this.ignoreCrashesChk.TabIndex = 18;
            this.ignoreCrashesChk.Tag = "--ignore-crashes";
            this.ignoreCrashesChk.Text = "--ignore-crashes";
            this.ignoreCrashesChk.UseVisualStyleBackColor = true;
            // 
            // hprofChk
            // 
            this.hprofChk.AutoSize = true;
            this.hprofChk.Location = new System.Drawing.Point(21, 63);
            this.hprofChk.Name = "hprofChk";
            this.hprofChk.Size = new System.Drawing.Size(66, 16);
            this.hprofChk.TabIndex = 17;
            this.hprofChk.Tag = "--hprof";
            this.hprofChk.Text = "--hprof";
            this.hprofChk.UseVisualStyleBackColor = true;
            // 
            // dbgNoEventsChk
            // 
            this.dbgNoEventsChk.AutoSize = true;
            this.dbgNoEventsChk.Location = new System.Drawing.Point(21, 26);
            this.dbgNoEventsChk.Name = "dbgNoEventsChk";
            this.dbgNoEventsChk.Size = new System.Drawing.Size(114, 16);
            this.dbgNoEventsChk.TabIndex = 16;
            this.dbgNoEventsChk.Tag = "--dbg-no-events";
            this.dbgNoEventsChk.Text = "--dbg-no-events";
            this.dbgNoEventsChk.UseVisualStyleBackColor = true;
            // 
            // consoleTxt
            // 
            this.consoleTxt.BackColor = System.Drawing.Color.Black;
            this.consoleTxt.ForeColor = System.Drawing.Color.White;
            this.consoleTxt.Location = new System.Drawing.Point(13, 384);
            this.consoleTxt.Multiline = true;
            this.consoleTxt.Name = "consoleTxt";
            this.consoleTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleTxt.Size = new System.Drawing.Size(728, 138);
            this.consoleTxt.TabIndex = 16;
            this.consoleTxt.WordWrap = false;
            // 
            // getCurrentFocusedPacakgeNameBtn
            // 
            this.getCurrentFocusedPacakgeNameBtn.Location = new System.Drawing.Point(69, 47);
            this.getCurrentFocusedPacakgeNameBtn.Name = "getCurrentFocusedPacakgeNameBtn";
            this.getCurrentFocusedPacakgeNameBtn.Size = new System.Drawing.Size(160, 23);
            this.getCurrentFocusedPacakgeNameBtn.TabIndex = 25;
            this.getCurrentFocusedPacakgeNameBtn.Text = "获取包名";
            this.getCurrentFocusedPacakgeNameBtn.UseVisualStyleBackColor = true;
            this.getCurrentFocusedPacakgeNameBtn.Click += new System.EventHandler(this.getCurrentFocusedPacakgeNameBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 534);
            this.Controls.Add(this.consoleTxt);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deviceInfoGrp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.runBtn);
            this.Name = "Main";
            this.Text = "Monkey";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.deviceInfoGrp.ResumeLayout(false);
            this.deviceInfoGrp.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.TextBox packageNameTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eventCountTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton logLevel0;
        private System.Windows.Forms.RadioButton logLevel1;
        private System.Windows.Forms.RadioButton logLevel2;
        private System.Windows.Forms.TextBox seedTbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox pctAnyeventTbx;
        private System.Windows.Forms.TextBox pctSyskeysTbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pctAppswitchTbx;
        private System.Windows.Forms.TextBox pctMajornavTbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pctNavTbx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pctTrackballTbx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ptcMotionTbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pctTouchTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox throttleTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox deviceIDCbx;
        private System.Windows.Forms.GroupBox deviceInfoGrp;
        private System.Windows.Forms.Label buildVersionLb;
        private System.Windows.Forms.Label productModelLb;
        private System.Windows.Forms.Label productBrandLb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox waitDbgChk;
        private System.Windows.Forms.CheckBox monitorNativeCrashesChk;
        private System.Windows.Forms.CheckBox killProcessAfterErrorChk;
        private System.Windows.Forms.CheckBox ignoreSecurityExceptionsChk;
        private System.Windows.Forms.CheckBox ignoreTimeoutsChk;
        private System.Windows.Forms.CheckBox ignoreCrashesChk;
        private System.Windows.Forms.CheckBox hprofChk;
        private System.Windows.Forms.CheckBox dbgNoEventsChk;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox consoleTxt;
        private System.Windows.Forms.Button getCurrentFocusedPacakgeNameBtn;
    }
}

