using System;
using System.Text;
using System.Diagnostics;

using System.Windows.Forms;

namespace IPSW_Restorer
{
    public partial class MainWindow : Form
    {
        private string ipswFilePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            StringBuilder information = new StringBuilder();
            information.AppendLine("- iOS 10<= support.");
            information.AppendLine("- No iTunes needed.");
            information.AppendLine("- Using a precompiled version for Windows! / https://github.com/elrhk/Libimobiledevice-idevicerestore-for-Windows");
            information.AppendLine("- Using libimobiledevice, libirecovery & idevicerestore.");

            MessageBox.Show(information.ToString(), "IPSW Restore about", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            openIPSW.Filter = "IPSW files|*.ipsw;*.zip";
            if(openIPSW.ShowDialog() == DialogResult.OK)
            {
                ipswFilePath = openIPSW.FileName;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder cmd = new StringBuilder();
            // cmd.Append("idevicrestore.exe ");

            // Step 1
            if (latestFirmware.Checked)
            {
                cmd.Append("-l ");
            }
            else if (ipswFilePath == null)
            {
                MessageBox.Show("No ipsw selected!", "Select one option in the first step", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2

            if(basebandOption.Checked)
            {
                cmd.Append("-x ");
            }

            if(tssFromCydia.Checked)
            {
                cmd.Append("-s ");
            }

            if(fetchTSS.Checked)
            {
                cmd.Append("-t ");
            }

            if(limer4in.Checked)
            {
                cmd.Append("-p ");
            }

            if(fullyRestore.Checked)
            {
                cmd.Append("-e ");
            }

            if(ipswFilePath != null)
            {
                cmd.Append(" \"" + ipswFilePath + "\" ");
            }

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "idevicerestore.exe",
                    Arguments = cmd.ToString()
                }
            };
            process.Start();
            process.WaitForExit();

            MessageBox.Show("Everything done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/BananaProject/idevicerestore-gui/");
        }
    }
}
