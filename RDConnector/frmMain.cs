using RDConnector.Classes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDConnector
{
    public partial class frmMain : Form
    {
        private Point offset;
        string serverListPath = @"";
        public Server Server { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            if (Server != null)
            {
                serverListPath = Server.File;
                foreach (string line in File.ReadAllLines(Server.File))
                {
                    string[] parts = line.Split(';');
                    string[] addressParts = parts[0].Split('@');
                    string ip = addressParts[0].Split(':')[0];
                    int port = int.Parse(addressParts[0].Split(':')[1]);

                    string username = parts[0].Split('\\')[1];
                    string password = parts[1];

                    lbx_ServerList.Items.Add($"{ip}:{port}|{username}|{password}");
                }
                lbx_ServerList.Items[Server.Index] = $"{Server.ServerName}:{Server.Port}|{Server.Username}|{Server.Password}";
            }
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
                    string[] parts = line.Split(';');
                    string[] addressParts = parts[0].Split('@');
                    string ip = addressParts[0].Split(':')[0];
                    int port = int.Parse(addressParts[0].Split(':')[1]);

                    string username = parts[0].Split('\\')[1];
                    string password = parts[1];

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

        #region Pinging
        private void btn_PingTest_Click(object sender, System.EventArgs e)
        {
            if (lbx_ServerList.SelectedItem == null)
            {
                return;
            }
            frmPing pingSection = new frmPing();
            pingSection.serverAddress = lbx_ServerList.SelectedItem.ToString().Split('|')[0];
            pingSection.ShowDialog();
        }

        private async void btn_PingList_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < lbx_ServerList.Items.Count; i++)
            {
                string address = lbx_ServerList.Items[i].ToString().Split('|')[0].Split(':')[0];
                lbx_ServerList.Items[i] = lbx_ServerList.Items[i] + "|" + await PingWithPortAsync(address.Split(':')[0]);
            }
        }

        private async Task<string> PingWithPortAsync(string hostName)
        {
            Ping ping = new Ping();
            try
            {
                PingReply reply = await ping.SendPingAsync(hostName, 1000);
                if (reply.Status == IPStatus.Success)
                {
                    return $"bytes={reply.Buffer.Length}|time={reply.RoundtripTime}ms|TTL={reply.Options.Ttl}";
                }
                else
                {
                    return $"Request timed out.";
                }
            }
            catch (SocketException)
            {
                return $"Failed to connect";
            }
        }
        #endregion

        private void btn_SaveList_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveServers = new SaveFileDialog();
            saveServers.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveServers.Title = "Save Good Servers";

            if (saveServers.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveServers.FileName;

                ListBox.ObjectCollection items = lbx_ServerList.Items;

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var item in items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Good servers list saved successfully!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_EditServer_Click(object sender, System.EventArgs e)
        {
            frmEditServer edit = new frmEditServer();
            var server = new Server()
            {
                Index = lbx_ServerList.SelectedIndex,
                ServerName = lbx_ServerList.SelectedItem.ToString().Split('|')[0].Split(':')[0],
                Port = lbx_ServerList.SelectedItem.ToString().Split('|')[0].Split(':')[1],
                Username = lbx_ServerList.SelectedItem.ToString().Split('|')[1],
                Password = lbx_ServerList.SelectedItem.ToString().Split('|')[2],
                File = serverListPath
            };

            edit.Server = server;

            edit.Show();
        }
    }
}
