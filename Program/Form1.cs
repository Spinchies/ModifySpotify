using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void hopeButton1_Click(object sender, EventArgs e)
        {
            // URL of the batch file to download
            string batchUrl = "https://raw.githack.com/amd64fox/SpotX/main/scripts/Install_Auto.bat";
            // Local path to save the batch file
            string localBatchPath = Path.Combine(Path.GetTempPath(), "spotx.bat");

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                try
                {
                    var batchContent = await httpClient.GetByteArrayAsync(batchUrl);
                    File.WriteAllBytes(localBatchPath, batchContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to download file: " + ex.Message);
                    return;
                }
            }

            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = localBatchPath,
                    UseShellExecute = true,
                    Verb = "runas", // Run as administrator
                    WindowStyle = ProcessWindowStyle.Normal
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Run file as administrator: " + ex.Message);
            }
            hopeButton2.Visible = true;
        }

        private void hopeButton2_Click(object sender, EventArgs e)
        {
            string scriptPath = Path.Combine(Path.GetTempPath(), "script.ps1");

            string scriptContent = "iwr -useb https://raw.githubusercontent.com/spicetify/cli/main/install.ps1 | iex";
            File.WriteAllText(scriptPath, scriptContent);

            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{scriptPath}\"",
                    UseShellExecute = false, // Required for redirecting input
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    Verb = "runas", // Run as administrator
                    WindowStyle = ProcessWindowStyle.Normal
                };

                using (var process = Process.Start(psi))
                {
                    if (process != null)
                    {
                        // Send 'y' followed by Enter to the process input
                        process.StandardInput.WriteLine("y");
                        process.StandardInput.Flush();
                        process.StandardInput.Close();
                        process.WaitForExit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to run PowerShell as administrator: " + ex.Message);
            }
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
