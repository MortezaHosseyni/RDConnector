namespace RDConnector
{
    partial class frmPing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPing));
            this.lbl_ServerAddress = new System.Windows.Forms.Label();
            this.rtb_PingLog = new System.Windows.Forms.RichTextBox();
            this.btn_ClosePinging = new System.Windows.Forms.Button();
            this.btn_RePing = new System.Windows.Forms.Button();
            this.ttp_ToolStrip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ServerAddress
            // 
            this.lbl_ServerAddress.AutoSize = true;
            this.lbl_ServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_ServerAddress.Location = new System.Drawing.Point(12, 38);
            this.lbl_ServerAddress.Name = "lbl_ServerAddress";
            this.lbl_ServerAddress.Size = new System.Drawing.Size(118, 24);
            this.lbl_ServerAddress.TabIndex = 0;
            this.lbl_ServerAddress.Text = "Address:Port";
            // 
            // rtb_PingLog
            // 
            this.rtb_PingLog.BackColor = System.Drawing.Color.Black;
            this.rtb_PingLog.ForeColor = System.Drawing.Color.Lime;
            this.rtb_PingLog.Location = new System.Drawing.Point(12, 75);
            this.rtb_PingLog.Name = "rtb_PingLog";
            this.rtb_PingLog.ReadOnly = true;
            this.rtb_PingLog.Size = new System.Drawing.Size(853, 149);
            this.rtb_PingLog.TabIndex = 1;
            this.rtb_PingLog.Text = "";
            // 
            // btn_ClosePinging
            // 
            this.btn_ClosePinging.BackColor = System.Drawing.Color.Black;
            this.btn_ClosePinging.ForeColor = System.Drawing.Color.Red;
            this.btn_ClosePinging.Location = new System.Drawing.Point(834, 12);
            this.btn_ClosePinging.Name = "btn_ClosePinging";
            this.btn_ClosePinging.Size = new System.Drawing.Size(31, 29);
            this.btn_ClosePinging.TabIndex = 2;
            this.btn_ClosePinging.Text = "❌";
            this.ttp_ToolStrip.SetToolTip(this.btn_ClosePinging, "Close pinging section");
            this.btn_ClosePinging.UseVisualStyleBackColor = false;
            this.btn_ClosePinging.Click += new System.EventHandler(this.btn_ClosePinging_Click);
            // 
            // btn_RePing
            // 
            this.btn_RePing.BackColor = System.Drawing.Color.Black;
            this.btn_RePing.ForeColor = System.Drawing.Color.Gold;
            this.btn_RePing.Location = new System.Drawing.Point(797, 12);
            this.btn_RePing.Name = "btn_RePing";
            this.btn_RePing.Size = new System.Drawing.Size(31, 29);
            this.btn_RePing.TabIndex = 3;
            this.btn_RePing.Text = "♻️";
            this.ttp_ToolStrip.SetToolTip(this.btn_RePing, "Re-Ping server");
            this.btn_RePing.UseVisualStyleBackColor = false;
            this.btn_RePing.Click += new System.EventHandler(this.btn_RePing_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Black;
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Save.Location = new System.Drawing.Point(760, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(31, 29);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "💾";
            this.ttp_ToolStrip.SetToolTip(this.btn_Save, "Save ping log");
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(877, 236);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_RePing);
            this.Controls.Add(this.btn_ClosePinging);
            this.Controls.Add(this.rtb_PingLog);
            this.Controls.Add(this.lbl_ServerAddress);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinging";
            this.Load += new System.EventHandler(this.frmPing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ServerAddress;
        private System.Windows.Forms.RichTextBox rtb_PingLog;
        private System.Windows.Forms.Button btn_ClosePinging;
        private System.Windows.Forms.Button btn_RePing;
        private System.Windows.Forms.ToolTip ttp_ToolStrip;
        private System.Windows.Forms.Button btn_Save;
    }
}