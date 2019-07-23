using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
 

namespace WpfDependency
{
    public class Program
    {
      
        public const string processName = "WpfDependency";
        [STAThread]
        [DebuggerNonUserCode()]//����degubʱ��ǰ�ļ������ϵ�
        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public static void Main()
        {
            try
            { 
                Process[] ps = Process.GetProcesses();
                int count = 0;
                foreach (Process item in ps)
                {
                    string currentProcessName = item.ProcessName.ToLower();
                    string processNameLower = processName.ToLower();
                    if (currentProcessName.Contains(processNameLower))
                    {
                        count++;

                    }
                }
                if (count > 1)
                {
                    
                    MessageBox.Show("����������ϵͳ��", "����");
                    return;
                }
                WpfDependency.App app = new WpfDependency.App();
                app.InitializeComponent();
                app.Run();

            }
            catch (Exception ex)
            {
             
            }
        }
    }
}
