namespace Restaurant
{
    partial class FMain
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
            this.pMeals = new System.Windows.Forms.Panel();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.pMeals);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(689, 473);
            this.pMain.TabIndex = 0;
            // 
            // pMeals
            // 
            this.pMeals.AutoScroll = true;
            this.pMeals.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMeals.Location = new System.Drawing.Point(0, 0);
            this.pMeals.Name = "pMeals";
            this.pMeals.Size = new System.Drawing.Size(427, 473);
            this.pMeals.TabIndex = 0;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 473);
            this.Controls.Add(this.pMain);
            this.Name = "FMain";
            this.ShowIcon = false;
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pMeals;
    }
}

