namespace RDConnector
{
    partial class frmEditServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditServer));
            this.btn_CloseEdit = new System.Windows.Forms.Button();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Server = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CloseEdit
            // 
            this.btn_CloseEdit.BackColor = System.Drawing.Color.Black;
            this.btn_CloseEdit.ForeColor = System.Drawing.Color.Red;
            this.btn_CloseEdit.Location = new System.Drawing.Point(308, 13);
            this.btn_CloseEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CloseEdit.Name = "btn_CloseEdit";
            this.btn_CloseEdit.Size = new System.Drawing.Size(46, 40);
            this.btn_CloseEdit.TabIndex = 3;
            this.btn_CloseEdit.Text = "❌";
            this.btn_CloseEdit.UseVisualStyleBackColor = false;
            this.btn_CloseEdit.Click += new System.EventHandler(this.btn_CloseEdit_Click);
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(39, 105);
            this.lbl_Server.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(51, 18);
            this.lbl_Server.TabIndex = 4;
            this.lbl_Server.Text = "Server";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(54, 135);
            this.lbl_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(36, 18);
            this.lbl_Port.TabIndex = 5;
            this.lbl_Port.Text = "Port";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(13, 165);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(77, 18);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(15, 195);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(75, 18);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Server
            // 
            this.txt_Server.BackColor = System.Drawing.Color.Black;
            this.txt_Server.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_Server.Location = new System.Drawing.Point(97, 102);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(243, 24);
            this.txt_Server.TabIndex = 8;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.Black;
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_Username.Location = new System.Drawing.Point(97, 162);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(243, 24);
            this.txt_Username.TabIndex = 8;
            // 
            // txt_Port
            // 
            this.txt_Port.BackColor = System.Drawing.Color.Black;
            this.txt_Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_Port.Location = new System.Drawing.Point(97, 132);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(243, 24);
            this.txt_Port.TabIndex = 8;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Black;
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_Password.Location = new System.Drawing.Point(97, 192);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(243, 24);
            this.txt_Password.TabIndex = 8;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_Title.Location = new System.Drawing.Point(38, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(102, 24);
            this.lbl_Title.TabIndex = 9;
            this.lbl_Title.Text = "Edit Server";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Black;
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Save.Location = new System.Drawing.Point(57, 264);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(260, 29);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmEditServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(381, 344);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Server);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_Server);
            this.Controls.Add(this.btn_CloseEdit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditServer";
            this.Load += new System.EventHandler(this.frmEditServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CloseEdit;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Server;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Save;
    }
}