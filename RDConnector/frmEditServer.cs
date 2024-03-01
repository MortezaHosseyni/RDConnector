using RDConnector.Classes;
using System;
using System.Windows.Forms;

namespace RDConnector
{
    public partial class frmEditServer : Form
    {
        private readonly frmMain _mainForm;

        public Server Server { get; set; }
        public frmEditServer(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void frmEditServer_Load(object sender, EventArgs e)
        {
            txt_Server.Text = Server.ServerName;
            txt_Port.Text = Server.Port;
            txt_Username.Text = Server.Username;
            txt_Password.Text = Server.Password;
        }

        private void btn_CloseEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var model = new Server()
            {
                Index = Server.Index,
                ServerName = txt_Server.Text,
                Port = txt_Port.Text,
                Username = txt_Username.Text,
                Password = txt_Password.Text,
                File = Server.File
            };
            _mainForm.EditedServer = model;
            Close();
        }
    }
}
