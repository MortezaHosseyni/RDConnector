using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDConnector
{
    public partial class frmPing : Form
    {
        public string serverAddress;
        public frmPing()
        {
            InitializeComponent();
        }

        private void btn_ClosePinging_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void frmPing_Load(object sender, EventArgs e)
        {
            lbl_ServerAddress.Text = serverAddress;

            if (string.IsNullOrEmpty(serverAddress.Split(':')[0]))
            {
                MessageBox.Show("Please enter a host name.");
                return;
            }

            int port;
            if (!int.TryParse(serverAddress.Split(':')[1], out port))
            {
                MessageBox.Show("Please enter a valid port number.");
                return;
            }

            rtb_PingLog.Clear();

            await PingWithPortAsync(serverAddress.Split(':')[0], port, 4);
        }

        private async Task PingWithPortAsync(string hostName, int port, int numberOfPings)
        {
            Ping ping = new Ping();
            for (int i = 0; i < numberOfPings; i++)
            {
                try
                {
                    PingReply reply = await ping.SendPingAsync(hostName, 1000);
                    if (reply.Status == IPStatus.Success)
                    {
                        AppendLog($"Ping {i + 1}: Reply from {reply.Address}: bytes={reply.Buffer.Length} time={reply.RoundtripTime}ms TTL={reply.Options.Ttl}");
                    }
                    else
                    {
                        AppendLog($"Ping {i + 1}: Request timed out.");
                    }
                }
                catch (SocketException ex)
                {
                    AppendLog($"Ping {i + 1}: Failed to connect to {hostName}:{port} *** {ex.Message}");
                }
            }
        }

        private void AppendLog(string logMessage)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(AppendLog), logMessage);
                return;
            }

            rtb_PingLog.AppendText($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} *** {logMessage}\n");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveLogs = new SaveFileDialog();
            saveLogs.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveLogs.Title = "Save Rich Text Box Contents";

            if (saveLogs.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveLogs.FileName;

                try
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        sw.Write(rtb_PingLog.Text);
                    }
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btn_RePing_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serverAddress.Split(':')[0]))
            {
                MessageBox.Show("Please enter a host name.");
                return;
            }

            int port;
            if (!int.TryParse(serverAddress.Split(':')[1], out port))
            {
                MessageBox.Show("Please enter a valid port number.");
                return;
            }

            rtb_PingLog.Clear();

            await PingWithPortAsync(serverAddress.Split(':')[0], port, 4);
        }
    }
}
