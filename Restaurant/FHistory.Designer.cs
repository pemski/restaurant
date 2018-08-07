namespace Restaurant
{
    partial class FHistory
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
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMain = new System.Windows.Forms.Panel();
            this.pText = new System.Windows.Forms.Panel();
            this.eText = new System.Windows.Forms.TextBox();
            this.pFiles = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            this.pMain.SuspendLayout();
            this.pText.SuspendLayout();
            this.pFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFiles
            // 
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToDeleteRows = false;
            this.dgFiles.AllowUserToResizeRows = false;
            this.dgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File});
            this.dgFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFiles.Location = new System.Drawing.Point(0, 0);
            this.dgFiles.MultiSelect = false;
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.ReadOnly = true;
            this.dgFiles.RowHeadersVisible = false;
            this.dgFiles.Size = new System.Drawing.Size(321, 450);
            this.dgFiles.TabIndex = 0;
            this.dgFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFiles_CellClick);
            // 
            // File
            // 
            this.File.HeaderText = "Plik";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.pText);
            this.pMain.Controls.Add(this.pFiles);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(800, 450);
            this.pMain.TabIndex = 1;
            // 
            // pText
            // 
            this.pText.BackColor = System.Drawing.Color.Transparent;
            this.pText.Controls.Add(this.eText);
            this.pText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pText.Location = new System.Drawing.Point(321, 0);
            this.pText.Name = "pText";
            this.pText.Size = new System.Drawing.Size(479, 450);
            this.pText.TabIndex = 1;
            // 
            // eText
            // 
            this.eText.BackColor = System.Drawing.Color.White;
            this.eText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eText.Location = new System.Drawing.Point(0, 0);
            this.eText.Multiline = true;
            this.eText.Name = "eText";
            this.eText.ReadOnly = true;
            this.eText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.eText.Size = new System.Drawing.Size(479, 450);
            this.eText.TabIndex = 0;
            // 
            // pFiles
            // 
            this.pFiles.BackColor = System.Drawing.Color.Transparent;
            this.pFiles.Controls.Add(this.dgFiles);
            this.pFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.pFiles.Location = new System.Drawing.Point(0, 0);
            this.pFiles.Name = "pFiles";
            this.pFiles.Size = new System.Drawing.Size(321, 450);
            this.pFiles.TabIndex = 0;
            // 
            // FHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMain);
            this.Name = "FHistory";
            this.ShowIcon = false;
            this.Text = "Historia zamówień";
            this.Load += new System.EventHandler(this.FHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pText.ResumeLayout(false);
            this.pText.PerformLayout();
            this.pFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pText;
        private System.Windows.Forms.TextBox eText;
        private System.Windows.Forms.Panel pFiles;
    }
}