namespace RDConnector
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Minimized = new System.Windows.Forms.Button();
            this.lbol_Title = new System.Windows.Forms.Label();
            this.lbx_ServerList = new System.Windows.Forms.ListBox();
            this.btn_LoadServer = new System.Windows.Forms.Button();
            this.btn_ExportList = new System.Windows.Forms.Button();
            this.lbl_ComingSoon = new System.Windows.Forms.Label();
            this.btn_About = new System.Windows.Forms.Button();
            this.cms_ServerListFunctions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_ConnectToServer = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ServerStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Divider = new System.Windows.Forms.ToolStripSeparator();
            this.btn_PingTest = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.llb_Path = new System.Windows.Forms.LinkLabel();
            this.pnl_Header.SuspendLayout();
            this.cms_ServerListFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.ForestGreen;
            this.pnl_Header.Controls.Add(this.btn_About);
            this.pnl_Header.Controls.Add(this.lbol_Title);
            this.pnl_Header.Controls.Add(this.btn_Minimized);
            this.pnl_Header.Controls.Add(this.btn_Exit);
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(800, 31);
            this.pnl_Header.TabIndex = 0;
            this.pnl_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Header_MouseDown);
            this.pnl_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Header_MouseMove);
            this.pnl_Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Header_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(769, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 31);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "❌";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Minimized
            // 
            this.btn_Minimized.BackColor = System.Drawing.Color.Blue;
            this.btn_Minimized.ForeColor = System.Drawing.Color.White;
            this.btn_Minimized.Location = new System.Drawing.Point(732, 0);
            this.btn_Minimized.Name = "btn_Minimized";
            this.btn_Minimized.Size = new System.Drawing.Size(31, 31);
            this.btn_Minimized.TabIndex = 2;
            this.btn_Minimized.Text = "⛔️";
            this.btn_Minimized.UseVisualStyleBackColor = false;
            this.btn_Minimized.Click += new System.EventHandler(this.btn_Minimized_Click);
            // 
            // lbol_Title
            // 
            this.lbol_Title.AutoSize = true;
            this.lbol_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbol_Title.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbol_Title.Location = new System.Drawing.Point(5, 6);
            this.lbol_Title.Name = "lbol_Title";
            this.lbol_Title.Size = new System.Drawing.Size(111, 20);
            this.lbol_Title.TabIndex = 1;
            this.lbol_Title.Text = "RD Connector";
            // 
            // lbx_ServerList
            // 
            this.lbx_ServerList.BackColor = System.Drawing.Color.Black;
            this.lbx_ServerList.ContextMenuStrip = this.cms_ServerListFunctions;
            this.lbx_ServerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbx_ServerList.ForeColor = System.Drawing.Color.Lime;
            this.lbx_ServerList.FormattingEnabled = true;
            this.lbx_ServerList.HorizontalScrollbar = true;
            this.lbx_ServerList.ItemHeight = 20;
            this.lbx_ServerList.Location = new System.Drawing.Point(12, 78);
            this.lbx_ServerList.Name = "lbx_ServerList";
            this.lbx_ServerList.Size = new System.Drawing.Size(379, 344);
            this.lbx_ServerList.TabIndex = 1;
            // 
            // btn_LoadServer
            // 
            this.btn_LoadServer.BackColor = System.Drawing.Color.Black;
            this.btn_LoadServer.ForeColor = System.Drawing.Color.Yellow;
            this.btn_LoadServer.Location = new System.Drawing.Point(12, 46);
            this.btn_LoadServer.Name = "btn_LoadServer";
            this.btn_LoadServer.Size = new System.Drawing.Size(136, 26);
            this.btn_LoadServer.TabIndex = 2;
            this.btn_LoadServer.Text = "Load Server List";
            this.btn_LoadServer.UseVisualStyleBackColor = false;
            this.btn_LoadServer.Click += new System.EventHandler(this.btn_LoadServer_Click);
            // 
            // btn_ExportList
            // 
            this.btn_ExportList.BackColor = System.Drawing.Color.Black;
            this.btn_ExportList.ForeColor = System.Drawing.Color.Yellow;
            this.btn_ExportList.Location = new System.Drawing.Point(238, 46);
            this.btn_ExportList.Name = "btn_ExportList";
            this.btn_ExportList.Size = new System.Drawing.Size(153, 26);
            this.btn_ExportList.TabIndex = 3;
            this.btn_ExportList.Text = "Ping List";
            this.btn_ExportList.UseVisualStyleBackColor = false;
            // 
            // lbl_ComingSoon
            // 
            this.lbl_ComingSoon.AutoSize = true;
            this.lbl_ComingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ComingSoon.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_ComingSoon.Location = new System.Drawing.Point(517, 209);
            this.lbl_ComingSoon.Name = "lbl_ComingSoon";
            this.lbl_ComingSoon.Size = new System.Drawing.Size(117, 20);
            this.lbl_ComingSoon.TabIndex = 3;
            this.lbl_ComingSoon.Text = "Coming Soon...";
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_About.ForeColor = System.Drawing.Color.White;
            this.btn_About.Location = new System.Drawing.Point(693, 0);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(31, 31);
            this.btn_About.TabIndex = 3;
            this.btn_About.Text = "❗️";
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // cms_ServerListFunctions
            // 
            this.cms_ServerListFunctions.BackColor = System.Drawing.Color.Black;
            this.cms_ServerListFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ConnectToServer,
            this.btn_ServerStatus,
            this.lbl_Divider,
            this.btn_PingTest});
            this.cms_ServerListFunctions.Name = "cms_ServerListFunctions";
            this.cms_ServerListFunctions.Size = new System.Drawing.Size(170, 76);
            // 
            // btn_ConnectToServer
            // 
            this.btn_ConnectToServer.ForeColor = System.Drawing.Color.Lime;
            this.btn_ConnectToServer.ImageTransparentColor = System.Drawing.Color.Black;
            this.btn_ConnectToServer.Name = "btn_ConnectToServer";
            this.btn_ConnectToServer.Size = new System.Drawing.Size(169, 22);
            this.btn_ConnectToServer.Text = "Connect To Server";
            // 
            // btn_ServerStatus
            // 
            this.btn_ServerStatus.ForeColor = System.Drawing.Color.Lime;
            this.btn_ServerStatus.ImageTransparentColor = System.Drawing.Color.Black;
            this.btn_ServerStatus.Name = "btn_ServerStatus";
            this.btn_ServerStatus.Size = new System.Drawing.Size(169, 22);
            this.btn_ServerStatus.Text = "Status";
            // 
            // lbl_Divider
            // 
            this.lbl_Divider.Name = "lbl_Divider";
            this.lbl_Divider.Size = new System.Drawing.Size(166, 6);
            // 
            // btn_PingTest
            // 
            this.btn_PingTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_PingTest.ImageTransparentColor = System.Drawing.Color.Black;
            this.btn_PingTest.Name = "btn_PingTest";
            this.btn_PingTest.Size = new System.Drawing.Size(169, 22);
            this.btn_PingTest.Text = "Ping Test";
            this.btn_PingTest.Click += new System.EventHandler(this.btn_PingTest_Click);
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.ForeColor = System.Drawing.Color.White;
            this.lbl_Path.Location = new System.Drawing.Point(12, 426);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(74, 13);
            this.lbl_Path.TabIndex = 5;
            this.lbl_Path.Text = "Selected File: ";
            // 
            // llb_Path
            // 
            this.llb_Path.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llb_Path.AutoSize = true;
            this.llb_Path.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.llb_Path.Location = new System.Drawing.Point(92, 426);
            this.llb_Path.Name = "llb_Path";
            this.llb_Path.Size = new System.Drawing.Size(44, 13);
            this.llb_Path.TabIndex = 6;
            this.llb_Path.TabStop = true;
            this.llb_Path.Text = "Nothing";
            this.llb_Path.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Path_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llb_Path);
            this.Controls.Add(this.lbl_Path);
            this.Controls.Add(this.lbl_ComingSoon);
            this.Controls.Add(this.btn_ExportList);
            this.Controls.Add(this.btn_LoadServer);
            this.Controls.Add(this.lbx_ServerList);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RD Connector";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.cms_ServerListFunctions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Minimized;
        private System.Windows.Forms.Label lbol_Title;
        private System.Windows.Forms.ListBox lbx_ServerList;
        private System.Windows.Forms.Button btn_LoadServer;
        private System.Windows.Forms.Button btn_ExportList;
        private System.Windows.Forms.Label lbl_ComingSoon;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.ContextMenuStrip cms_ServerListFunctions;
        private System.Windows.Forms.ToolStripMenuItem btn_ConnectToServer;
        private System.Windows.Forms.ToolStripMenuItem btn_ServerStatus;
        private System.Windows.Forms.ToolStripSeparator lbl_Divider;
        private System.Windows.Forms.ToolStripMenuItem btn_PingTest;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.LinkLabel llb_Path;
    }
}

