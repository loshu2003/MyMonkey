using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using System.Text.RegularExpressions;

namespace MyMonkey
{
    class Monkey
    {
        private static string FILE_NAME = "adb";
        private string cmd = String.Empty;
        private string args = String.Empty;
        private string log = String.Empty;
        private string pacakgeName = String.Empty;

        private static ArrayList intalledPackages;


        static Monkey()
        {
            Monkey.initInstalledPackages();
        }

        public static ArrayList InstalledPackages
        {
            get { return Monkey.intalledPackages; }
        }

        public Monkey(string args)
        {
            this.args = args;
            this.cmd = Monkey.FILE_NAME + " " + this.args;
        }

        public string Cmd
        {
            get { return this.cmd; }
            set { this.cmd = value; }
        }

        public string Args
        {
            get { return this.args; }
            set { this.args = value; }
        }

        public string Log
        {
            get { return this.log; }
        }

        public string PackageName
        {
            get { return this.pacakgeName; }
            set { this.PackageName = value; }
        }

        /*
        void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            //* Do your stuff with the output (write to console/log/StringBuilder)
            Console.WriteLine(outLine.Data);
            if (!string.IsNullOrEmpty(outLine.Data))
            {
                this.mainForm.setText(outLine.Data);
            }
        }
        */

        public void run()
        {
            /*
             * 本来想做一个输出monkey日志的功能，但是不能逐句输出，先暂停此功能
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            //If the UseShellExecute property is true or the UserName and Password properties are not null, 
            //the CreateNoWindow property value is ignored and a new window is created.
            p.StartInfo.UseShellExecute = false;
            //不显示cmd窗口
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = Monkey.FILE_NAME;
            p.StartInfo.Arguments = this.Args;

            p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            p.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            //* Start process and handlers
            p.Start();
            p.BeginOutputReadLine();
            //p.BeginErrorReadLine();
            p.WaitForExit();
            */

            //清除手机logcat日志
            clearLogcat();

            //强制停止app
            stopApp();

            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            //If the UseShellExecute property is true or the UserName and Password properties are not null, 
            //the CreateNoWindow property value is ignored and a new window is created.
            p.StartInfo.UseShellExecute = false;
            //不显示cmd窗口
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = Monkey.FILE_NAME;
            p.StartInfo.Arguments = this.Args;
            p.Start();
            this.log += p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
        }//run end.
        
        /***
         * 清除手机中的logcat日志
         ***/
        public void clearLogcat()
        {
            //清除手机中的logcat日志
            string cmd = "adb";
            string args = "logcat -c";
            this.log += Command.exec(cmd, args);
        }

        private void stopApp()
        {
            string cmd = "adb";
            string package = "com.qihoo.around";
            string args = "shell am force-stop " + package;
            this.log += Command.exec(cmd, args);
        }

        /***
         * Checking whether the package is installed.
         ***/
        public static bool isPacakgeInstalled(string packageName)
        {
            bool isInstalled = false;
            if( Monkey.InstalledPackages.Contains(packageName) )
            {
                isInstalled = true;
            }
            return isInstalled;
        }

        public static void resetInstalledPacakges()
        {
            initInstalledPackages();
        }

        private static void initInstalledPackages()
        {
            string cmd = "adb";
            string args = "shell pm list packages | cut -f 2 -d ':'";
            string packages = Command.exec(cmd, args);
            /**
             * 将字符串以\r\r\n分割成数组
             **/
            string[] stringSeparators = new string[] { "\r\r\n" };
            intalledPackages = new ArrayList(packages.Split(stringSeparators, StringSplitOptions.None));
        }

        public static string getCurrentFocusedPacakgeName()
        {
            string currentFocusedPackageName = String.Empty;
            string cmd = "adb";
            string args = "shell dumpsys window windows|grep -E 'mFocusedApp'";
            string result = Command.exec(cmd, args);

            string pattern = @"(?<=u0 ).*(?=/)";
            Match m = Regex.Match(result, pattern);
            if (m.Success)
            {
                currentFocusedPackageName = m.Value;

                if( !Monkey.InstalledPackages.Contains(currentFocusedPackageName) )
                {
                    Monkey.InstalledPackages.Add(currentFocusedPackageName);
                }
            }
            
            return currentFocusedPackageName;
        }

    } //Monkey class end.
}
