using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
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
                startInfo.Arguments = "/c netsh wlan show profiles \"" + cbmain.Text + "\" key=clear";//cmd command like this "/c ipconfig"
                process.StartInfo = startInfo;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();

                string pattern = @"Key Content\s*:\s*(\S+)";
                Match match = Regex.Match(output, pattern);
                if (match.Success)
                {
                    string keyContent = match.Groups[1].Value;
                    txtpass.Text = keyContent;
                }
                else
                    txtpass.Text = "No wifi password";
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbmain.Items.Clear();
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/c netsh wlan show profiles";//cmd command like this "/c ipconfig"
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();

            List<string> wifiNames = GetUserProfiles(output);
            cbmain.Items.AddRange(wifiNames.ToArray());

            process.WaitForExit();
        }
        public List<string> GetUserProfiles(string text)
        {
            List<string> profiles = new List<string>();

            string pattern = @"All User Profile\s+:\s+(.+)";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string profileName = match.Groups[1].Value.Trim();
                profiles.Add(profileName);
            }

            return profiles;
        }
    }
}
