using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace MyMonkey
{
    class Command
    {
        /***
         * 执行cmd命令，并返回执行结果
         ***/
        public static string exec(string cmd, string args)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            //If the UseShellExecute property is true or the UserName and Password properties are not null, 
            //the CreateNoWindow property value is ignored and a new window is created.
            p.StartInfo.UseShellExecute = false;
            //不显示cmd窗口
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = cmd;
            p.StartInfo.Arguments = args;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
            return output;

        }//exec end.


    }
}
