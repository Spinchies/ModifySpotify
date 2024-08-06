using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Net;

namespace ModifySpotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void airForm1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
            // "Easter Egg"
            Process.Start("explorer","https://github.com/Spinchies/ModifySpotify/blob/main/README.md");

        }

        private async void foreverButton1_Click(object sender, EventArgs e)
        {
            // SpotX
            await Download();

        }

        private void foreverButton2_Click(object sender, EventArgs e)
        {
            // Spicetify 
            MessageBox.Show("If you want to install the theme & plugin marketplace, Press Y when prompted");
            Process.Start("powerShell.exe", "iwr -useb https://raw.githubusercontent.com/spicetify/cli/main/install.ps1 | iex ");
        }
        async Task Download()
        {
            using (WebClient client = new WebClient())
            {
                Directory.SetCurrentDirectory(Application.StartupPath);
                Directory.CreateDirectory("resources");
                string dir = Application.StartupPath + "/resources" + "/auto_install.bat";
                client.DownloadFileAsync(new Uri("https://raw.githack.com/amd64fox/SpotX/main/scripts/Install_Auto.bat"), dir);
                Directory.SetCurrentDirectory(Application.StartupPath + "/resources");
                int x = 1;
                while (x == 1)
                {
                    if (File.Exists("auto_install.bat"))
                    {
                        Thread.Sleep(500);
                        Process.Start("auto_install.bat");
                        x = 2;
                        break;
                    }
                    else
                        Thread.Sleep(500);
                }   

                
                    
            }
        }
    }
}
