using System.Diagnostics;
using System.Net;

namespace ModifySpotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Application.StartupPath);
            Directory.CreateDirectory(Application.StartupPath + "/resources");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to install the marketplace, Press Y when prompted");
            Process.Start("powerShell.exe", "iwr -useb https://raw.githubusercontent.com/spicetify/cli/main/install.ps1 | iex ");
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            await Download(); 
            Process.Start("auto_install.bat");

        }
        async Task Download()
        {
            using (WebClient client = new WebClient())
            {
                string dir = Application.StartupPath + "/resources" + "/auto_install.bat";
                client.DownloadFileAsync(new Uri("https://raw.githack.com/amd64fox/SpotX/main/scripts/Install_Auto.bat"), dir);
                Directory.SetCurrentDirectory(Application.StartupPath + "/resources");
                Thread.Sleep(350);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Close Button aka X
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Help Button
            var uri = "https://github.com/Spinchies/ModifySpotify/blob/main/README.md";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}
