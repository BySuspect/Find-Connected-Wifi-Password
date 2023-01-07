using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiPassReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "CMD.exe";
                startInfo.Arguments = "/c netsh wlan show profiles \"" + txtssid.Text + "\" key=clear";//cmd command like this "/c ipconfig"
                process.StartInfo = startInfo;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();

                string pattern = @"Key Content\s*:\s*(\S+)";
                Match match = Regex.Match(output, pattern);
                if (match.Success)
                {
                    string keyContent = match.Groups[1].Value;
                    MessageBox.Show(keyContent, "Password");
                }
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
