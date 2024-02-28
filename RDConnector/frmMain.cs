using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RDConnector
{
    public partial class frmMain : Form
    {
        private Point offset;
        string serverListPath = @"";

        public frmMain()
        {
            InitializeComponent();
        }

        #region Header
        private void pnl_Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void pnl_Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void pnl_Header_MouseUp(object sender, MouseEventArgs e)
        {
            offset = Point.Empty;
        }

        private void btn_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimized_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_About_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Developer: MrMean\nVersion: 1.0.0\n2024 ©️", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region File Selection
        private void btn_LoadServer_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog serverList = new OpenFileDialog();

            serverList.Title = "Server List";
            serverList.Filter = "Text Files (*.txt)|*.txt";

            if (serverList.ShowDialog() == DialogResult.OK && File.Exists(serverList.FileName))
            {
                lbx_ServerList.Items.Clear();
                llb_Path.Text = serverList.SafeFileName;
                serverListPath = serverList.FileName;

                foreach (string line in File.ReadAllLines(serverList.FileName))
                {
                    string[] parts = line.Split('@');
                    string[] addressParts = parts[0].Split(':');
                    string ip = addressParts[0];
                    int port = int.Parse(addressParts[1]);

                    string[] credentials = parts[1].Split(';');
                    string username = credentials[0].Split('\\')[1];
                    string password = credentials[1];

                    lbx_ServerList.Items.Add($"{ip}:{port}|{username}|{password}");
                }
            }
        }

        private void llb_Path_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists(serverListPath))
            {
                Process.Start("explorer.exe", $"/select,\"{serverListPath}\"");
            }
            else
            {
                MessageBox.Show("File not found!", "File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void btn_PingTest_Click(object sender, System.EventArgs e)
        {
            if (lbx_ServerList.SelectedItem == null)
            {
                return;
            }
            frmPing pingSection = new frmPing();
            pingSection.serverAddress = lbx_ServerList.SelectedItem.ToString().Split('|')[0];
            pingSection.Show();
        }
    }
}
