using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spodify
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
        void spotterfy()
        {
            string url = "https://raw.githack.com/amd64fox/SpotX/main/scripts/Install_Auto.bat"; // Replace with your file URL
            string downloadPath = Path.Combine(Path.GetTempPath(), "install.bat");

            using (WebClient client = new WebClient())
            {
                client.DownloadFileCompleted += (s, ev) =>
                {
                    // Run as admin
                    ProcessStartInfo psi = new ProcessStartInfo(downloadPath)
                    {
                        UseShellExecute = true,
                        Verb = "runas"
                    };
                    try
                    {
                        Process.Start(psi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to run as admin: " + ex.Message);
                    }
                };
                client.DownloadFileAsync(new Uri(url), downloadPath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spotterfy();
        }

        // P/Invoke to set window foreground for SendKeys fallback
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private void button2_Click(object sender, EventArgs e)
        {
            string psCommand = "iwr -useb https://raw.githubusercontent.com/spicetify/cli/main/install.ps1 | iex";
            string args = $"-NoProfile -ExecutionPolicy Bypass -Command \"{psCommand}\"";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = args,
                UseShellExecute = false, // needed to redirect stdin
                RedirectStandardInput = true,
                // Optional: capture output if desired
                RedirectStandardOutput = false,
                RedirectStandardError = false,
                CreateNoWindow = false, // try to show the window so users can see progress
                WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            };

            try
            {
                Process proc = Process.Start(psi);
                if (proc == null)
                {
                    MessageBox.Show("Failed to start PowerShell process.", "Start Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Best-effort: write "Y" to redirected StandardInput (buffers if prompt occurs later)
                try
                {
                    if (proc.StandardInput != null && !proc.StandardInput.BaseStream.CanWrite == false)
                    {
                        proc.StandardInput.WriteLine("Y");
                        proc.StandardInput.Flush();
                        // Do not necessarily close input immediately; closing might terminate interactive prompts unexpectedly.
                    }
                }
                catch (Exception)
                {
                    // Swallow; we'll attempt SendKeys fallback below if necessary.
                }

                // Fallback: try to bring the console window to foreground and send keystrokes.
                // Wait for MainWindowHandle to be available (timeout after ~3 seconds).
                const int maxRetries = 30;
                int retries = 0;
                while (retries < maxRetries && proc.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(100); // 100ms * 30 = 3s
                    proc.Refresh(); // refresh process info so MainWindowHandle may be updated
                    retries++;
                }

                if (proc.MainWindowHandle != IntPtr.Zero)
                {
                    try
                    {
                        // Bring to foreground and send Y + Enter
                        SetForegroundWindow(proc.MainWindowHandle);
                        // Small delay to ensure window gets focus
                        Thread.Sleep(100);
                        SendKeys.SendWait("Y{ENTER}");
                    }
                    catch (Exception)
                    {
                        // Ignore SendKeys errors; process already received stdin write attempt.
                    }
                }
            }
            catch (Win32Exception win32Ex)
            {
                // PowerShell not found or blocked
                MessageBox.Show("Failed to start PowerShell: " + win32Ex.Message, "Start Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://qntm.org/camtime");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
