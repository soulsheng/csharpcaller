using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace callEXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "E:\\3d\\exe\\build_view_reconstruction.exe";
            textBox2.Text = "--input_images=E:\\3d\\170602\\170508DalianVolume-101-960p-gps\\ --output_images=E:\\3d\\output\\ --same_color=1 --color_point=(0,255,0) --color_sky=(0,0,0) --point_size=3 --flagfile=E:\\3d\\exe\\build_reconstruction_flags.txt --build=0 --view=1";
        }

        private void call(string exe, string parameter)
        {
            System.Diagnostics.ProcessStartInfo procInfo = new System.Diagnostics.ProcessStartInfo();
            //设置启动参数
            procInfo.FileName = exe; //运行的命令
            procInfo.Arguments = parameter;//运行的字符串
            procInfo.ErrorDialog = true;
            procInfo.UseShellExecute = true;
            procInfo.CreateNoWindow = false;
            procInfo.RedirectStandardOutput = false;
            //MyDll.Common.WriteLog(procInfo.FileName, true);
            //MyDll.Common.WriteLog(argumentString, true);

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc = System.Diagnostics.Process.Start(procInfo);//开始一个进程
            proc.WaitForExit();//等待执行的完成
        }

        private void button3_Click(object sender, EventArgs e)
        {
            call( textBox1.Text, textBox2.Text );
        }
    }
}
