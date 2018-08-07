namespace Restaurant
{
    partial class FMail
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
            this.pMain = new System.Windows.Forms.Panel();
            this.eSender = new System.Windows.Forms.TextBox();
            this.lSender = new System.Windows.Forms.Label();
            this.rbSSLOn = new System.Windows.Forms.RadioButton();
            this.rbSSLOff = new System.Windows.Forms.RadioButton();
            this.lPassword = new System.Windows.Forms.Label();
            this.ePassword = new System.Windows.Forms.TextBox();
            this.lReceiver = new System.Windows.Forms.Label();
            this.eReceiver = new System.Windows.Forms.TextBox();
            this.lSmtp = new System.Windows.Forms.Label();
            this.eSmtp = new System.Windows.Forms.TextBox();
            this.ePort = new System.Windows.Forms.NumericUpDown();
            this.lPort = new System.Windows.Forms.Label();
            this.lSsl = new System.Windows.Forms.Label();
            this.gbSSL = new System.Windows.Forms.GroupBox();
            this.bSend = new System.Windows.Forms.Button();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePort)).BeginInit();
            this.gbSSL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.bSend);
            this.pMain.Controls.Add(this.gbSSL);
            this.pMain.Controls.Add(this.lSsl);
            this.pMain.Controls.Add(this.lPort);
            this.pMain.Controls.Add(this.ePort);
            this.pMain.Controls.Add(this.lSmtp);
            this.pMain.Controls.Add(this.eSmtp);
            this.pMain.Controls.Add(this.lReceiver);
            this.pMain.Controls.Add(this.eReceiver);
            this.pMain.Controls.Add(this.lPassword);
            this.pMain.Controls.Add(this.ePassword);
            this.pMain.Controls.Add(this.lSender);
            this.pMain.Controls.Add(this.eSender);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(251, 248);
            this.pMain.TabIndex = 0;
            // 
            // eSender
            // 
            this.eSender.Location = new System.Drawing.Point(71, 12);
            this.eSender.Name = "eSender";
            this.eSender.Size = new System.Drawing.Size(168, 20);
            this.eSender.TabIndex = 0;
            // 
            // lSender
            // 
            this.lSender.AutoSize = true;
            this.lSender.Location = new System.Drawing.Point(12, 15);
            this.lSender.Name = "lSender";
            this.lSender.Size = new System.Drawing.Size(53, 13);
            this.lSender.TabIndex = 1;
            this.lSender.Text = "Nadawca";
            // 
            // rbSSLOn
            // 
            this.rbSSLOn.AutoSize = true;
            this.rbSSLOn.Checked = true;
            this.rbSSLOn.Location = new System.Drawing.Point(6, 10);
            this.rbSSLOn.Name = "rbSSLOn";
            this.rbSSLOn.Size = new System.Drawing.Size(44, 17);
            this.rbSSLOn.TabIndex = 0;
            this.rbSSLOn.TabStop = true;
            this.rbSSLOn.Text = "Tak";
            this.rbSSLOn.UseVisualStyleBackColor = true;
            // 
            // rbSSLOff
            // 
            this.rbSSLOff.AutoSize = true;
            this.rbSSLOff.Location = new System.Drawing.Point(72, 10);
            this.rbSSLOff.Name = "rbSSLOff";
            this.rbSSLOff.Size = new System.Drawing.Size(41, 17);
            this.rbSSLOff.TabIndex = 1;
            this.rbSSLOff.TabStop = true;
            this.rbSSLOff.Text = "Nie";
            this.rbSSLOff.UseVisualStyleBackColor = true;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 41);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(36, 13);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Hasło";
            // 
            // ePassword
            // 
            this.ePassword.Location = new System.Drawing.Point(71, 38);
            this.ePassword.Name = "ePassword";
            this.ePassword.PasswordChar = '*';
            this.ePassword.Size = new System.Drawing.Size(168, 20);
            this.ePassword.TabIndex = 1;
            // 
            // lReceiver
            // 
            this.lReceiver.AutoSize = true;
            this.lReceiver.Location = new System.Drawing.Point(12, 67);
            this.lReceiver.Name = "lReceiver";
            this.lReceiver.Size = new System.Drawing.Size(43, 13);
            this.lReceiver.TabIndex = 7;
            this.lReceiver.Text = "Adresat";
            // 
            // eReceiver
            // 
            this.eReceiver.Location = new System.Drawing.Point(71, 64);
            this.eReceiver.Name = "eReceiver";
            this.eReceiver.Size = new System.Drawing.Size(168, 20);
            this.eReceiver.TabIndex = 2;
            // 
            // lSmtp
            // 
            this.lSmtp.AutoSize = true;
            this.lSmtp.Location = new System.Drawing.Point(12, 105);
            this.lSmtp.Name = "lSmtp";
            this.lSmtp.Size = new System.Drawing.Size(37, 13);
            this.lSmtp.TabIndex = 9;
            this.lSmtp.Text = "SMTP";
            // 
            // eSmtp
            // 
            this.eSmtp.Location = new System.Drawing.Point(71, 102);
            this.eSmtp.Name = "eSmtp";
            this.eSmtp.Size = new System.Drawing.Size(168, 20);
            this.eSmtp.TabIndex = 3;
            // 
            // ePort
            // 
            this.ePort.Location = new System.Drawing.Point(71, 129);
            this.ePort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ePort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ePort.Name = "ePort";
            this.ePort.Size = new System.Drawing.Size(67, 20);
            this.ePort.TabIndex = 4;
            this.ePort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(12, 131);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 11;
            this.lPort.Text = "Port";
            // 
            // lSsl
            // 
            this.lSsl.AutoSize = true;
            this.lSsl.Location = new System.Drawing.Point(12, 167);
            this.lSsl.Name = "lSsl";
            this.lSsl.Size = new System.Drawing.Size(27, 13);
            this.lSsl.TabIndex = 12;
            this.lSsl.Text = "SSL";
            // 
            // gbSSL
            // 
            this.gbSSL.Controls.Add(this.rbSSLOn);
            this.gbSSL.Controls.Add(this.rbSSLOff);
            this.gbSSL.Location = new System.Drawing.Point(71, 155);
            this.gbSSL.Name = "gbSSL";
            this.gbSSL.Size = new System.Drawing.Size(119, 34);
            this.gbSSL.TabIndex = 5;
            this.gbSSL.TabStop = false;
            // 
            // bSend
            // 
            this.bSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSend.Location = new System.Drawing.Point(143, 206);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(96, 30);
            this.bSend.TabIndex = 6;
            this.bSend.Text = "Wyślij";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // FMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 248);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FMail";
            this.ShowIcon = false;
            this.Text = "Wysyłka zamówienia";
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePort)).EndInit();
            this.gbSSL.ResumeLayout(false);
            this.gbSSL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gbSSL;
        private System.Windows.Forms.RadioButton rbSSLOn;
        private System.Windows.Forms.RadioButton rbSSLOff;
        private System.Windows.Forms.Label lSsl;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.NumericUpDown ePort;
        private System.Windows.Forms.Label lSmtp;
        private System.Windows.Forms.TextBox eSmtp;
        private System.Windows.Forms.Label lReceiver;
        private System.Windows.Forms.TextBox eReceiver;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox ePassword;
        private System.Windows.Forms.Label lSender;
        private System.Windows.Forms.TextBox eSender;
        private System.Windows.Forms.Button bSend;
    }
}