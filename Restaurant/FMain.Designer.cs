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
            this.pSummary = new System.Windows.Forms.Panel();
            this.pOrder = new System.Windows.Forms.Panel();
            this.bOrder = new System.Windows.Forms.Button();
            this.pCart = new System.Windows.Forms.FlowLayoutPanel();
            this.lOrder = new System.Windows.Forms.Label();
            this.pMeals = new System.Windows.Forms.Panel();
            this.lCart = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.pSummary.SuspendLayout();
            this.pOrder.SuspendLayout();
            this.pCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.pSummary);
            this.pMain.Controls.Add(this.pMeals);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(689, 473);
            this.pMain.TabIndex = 0;
            // 
            // pSummary
            // 
            this.pSummary.BackColor = System.Drawing.Color.Transparent;
            this.pSummary.Controls.Add(this.pOrder);
            this.pSummary.Controls.Add(this.pCart);
            this.pSummary.Controls.Add(this.lOrder);
            this.pSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSummary.Location = new System.Drawing.Point(427, 0);
            this.pSummary.Name = "pSummary";
            this.pSummary.Size = new System.Drawing.Size(262, 473);
            this.pSummary.TabIndex = 1;
            // 
            // pOrder
            // 
            this.pOrder.Controls.Add(this.bOrder);
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOrder.Location = new System.Drawing.Point(0, 44);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(262, 36);
            this.pOrder.TabIndex = 0;
            // 
            // bOrder
            // 
            this.bOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.bOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOrder.Location = new System.Drawing.Point(149, 0);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(113, 36);
            this.bOrder.TabIndex = 0;
            this.bOrder.Text = "Zamów";
            this.bOrder.UseVisualStyleBackColor = true;
            // 
            // pCart
            // 
            this.pCart.AutoSize = true;
            this.pCart.Controls.Add(this.lCart);
            this.pCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pCart.Location = new System.Drawing.Point(0, 31);
            this.pCart.Name = "pCart";
            this.pCart.Size = new System.Drawing.Size(262, 13);
            this.pCart.TabIndex = 2;
            // 
            // lOrder
            // 
            this.lOrder.AutoSize = true;
            this.lOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOrder.Location = new System.Drawing.Point(0, 0);
            this.lOrder.Name = "lOrder";
            this.lOrder.Size = new System.Drawing.Size(168, 31);
            this.lOrder.TabIndex = 1;
            this.lOrder.Text = "Zamówienie:";
            // 
            // pMeals
            // 
            this.pMeals.AutoScroll = true;
            this.pMeals.BackColor = System.Drawing.Color.Transparent;
            this.pMeals.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMeals.Location = new System.Drawing.Point(0, 0);
            this.pMeals.Name = "pMeals";
            this.pMeals.Size = new System.Drawing.Size(427, 473);
            this.pMeals.TabIndex = 0;
            // 
            // lCart
            // 
            this.lCart.AutoSize = true;
            this.lCart.Location = new System.Drawing.Point(3, 0);
            this.lCart.Name = "lCart";
            this.lCart.Size = new System.Drawing.Size(0, 13);
            this.lCart.TabIndex = 3;
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
            this.pSummary.ResumeLayout(false);
            this.pSummary.PerformLayout();
            this.pOrder.ResumeLayout(false);
            this.pCart.ResumeLayout(false);
            this.pCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pMeals;
        private System.Windows.Forms.Panel pSummary;
        private System.Windows.Forms.Panel pOrder;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.FlowLayoutPanel pCart;
        private System.Windows.Forms.Label lOrder;
        private System.Windows.Forms.Label lCart;
    }
}

