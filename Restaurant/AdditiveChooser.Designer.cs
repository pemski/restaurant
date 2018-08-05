namespace Restaurant
{
    partial class AdditiveChooser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMain = new System.Windows.Forms.Panel();
            this.pAdditives = new System.Windows.Forms.Panel();
            this.pMandatoryAddives = new System.Windows.Forms.Panel();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.AutoSize = true;
            this.pMain.BackColor = System.Drawing.SystemColors.Control;
            this.pMain.Controls.Add(this.pAdditives);
            this.pMain.Controls.Add(this.pMandatoryAddives);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(307, 94);
            this.pMain.TabIndex = 0;
            this.pMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pMain_Paint);
            // 
            // pAdditives
            // 
            this.pAdditives.AutoSize = true;
            this.pAdditives.BackColor = System.Drawing.Color.Transparent;
            this.pAdditives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAdditives.Location = new System.Drawing.Point(0, 0);
            this.pAdditives.Name = "pAdditives";
            this.pAdditives.Size = new System.Drawing.Size(307, 94);
            this.pAdditives.TabIndex = 1;
            // 
            // pMandatoryAddives
            // 
            this.pMandatoryAddives.AutoSize = true;
            this.pMandatoryAddives.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pMandatoryAddives.BackColor = System.Drawing.Color.Transparent;
            this.pMandatoryAddives.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMandatoryAddives.Location = new System.Drawing.Point(0, 0);
            this.pMandatoryAddives.Name = "pMandatoryAddives";
            this.pMandatoryAddives.Size = new System.Drawing.Size(307, 0);
            this.pMandatoryAddives.TabIndex = 0;
            // 
            // AdditiveChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pMain);
            this.Name = "AdditiveChooser";
            this.Size = new System.Drawing.Size(307, 94);
            this.Load += new System.EventHandler(this.AdditiveChooser_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pAdditives;
        private System.Windows.Forms.Panel pMandatoryAddives;
    }
}
