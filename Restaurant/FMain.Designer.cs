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
            this.pGroupSum = new System.Windows.Forms.Panel();
            this.pCancel = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.pOrder = new System.Windows.Forms.Panel();
            this.lSummary = new System.Windows.Forms.Label();
            this.bOrder = new System.Windows.Forms.Button();
            this.pCart = new System.Windows.Forms.FlowLayoutPanel();
            this.lCart = new System.Windows.Forms.Label();
            this.pHistory = new System.Windows.Forms.Panel();
            this.bHistory = new System.Windows.Forms.Button();
            this.lOrder = new System.Windows.Forms.Label();
            this.pMeals = new System.Windows.Forms.Panel();
            this.pOrderComment = new System.Windows.Forms.Panel();
            this.lOrderComment = new System.Windows.Forms.Label();
            this.eOrderComment = new System.Windows.Forms.TextBox();
            this.pMain.SuspendLayout();
            this.pSummary.SuspendLayout();
            this.pGroupSum.SuspendLayout();
            this.pCancel.SuspendLayout();
            this.pOrder.SuspendLayout();
            this.pCart.SuspendLayout();
            this.pHistory.SuspendLayout();
            this.pOrderComment.SuspendLayout();
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
            this.pSummary.Controls.Add(this.pGroupSum);
            this.pSummary.Controls.Add(this.pHistory);
            this.pSummary.Controls.Add(this.lOrder);
            this.pSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSummary.Location = new System.Drawing.Point(427, 0);
            this.pSummary.Name = "pSummary";
            this.pSummary.Size = new System.Drawing.Size(262, 473);
            this.pSummary.TabIndex = 1;
            // 
            // pGroupSum
            // 
            this.pGroupSum.AutoScroll = true;
            this.pGroupSum.Controls.Add(this.pCancel);
            this.pGroupSum.Controls.Add(this.pOrder);
            this.pGroupSum.Controls.Add(this.pOrderComment);
            this.pGroupSum.Controls.Add(this.pCart);
            this.pGroupSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGroupSum.Location = new System.Drawing.Point(0, 31);
            this.pGroupSum.Name = "pGroupSum";
            this.pGroupSum.Size = new System.Drawing.Size(262, 404);
            this.pGroupSum.TabIndex = 5;
            // 
            // pCancel
            // 
            this.pCancel.Controls.Add(this.bCancel);
            this.pCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCancel.Location = new System.Drawing.Point(0, 123);
            this.pCancel.Name = "pCancel";
            this.pCancel.Size = new System.Drawing.Size(262, 22);
            this.pCancel.TabIndex = 4;
            // 
            // bCancel
            // 
            this.bCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.Location = new System.Drawing.Point(184, 0);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(78, 22);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // pOrder
            // 
            this.pOrder.Controls.Add(this.lSummary);
            this.pOrder.Controls.Add(this.bOrder);
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOrder.Location = new System.Drawing.Point(0, 87);
            this.pOrder.Name = "pOrder";
            this.pOrder.Size = new System.Drawing.Size(262, 36);
            this.pOrder.TabIndex = 0;
            // 
            // lSummary
            // 
            this.lSummary.AutoSize = true;
            this.lSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSummary.Location = new System.Drawing.Point(6, 11);
            this.lSummary.Name = "lSummary";
            this.lSummary.Size = new System.Drawing.Size(60, 17);
            this.lSummary.TabIndex = 1;
            this.lSummary.Text = "Razem: ";
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
            this.bOrder.Click += new System.EventHandler(this.bOrder_Click);
            // 
            // pCart
            // 
            this.pCart.AutoSize = true;
            this.pCart.Controls.Add(this.lCart);
            this.pCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pCart.Location = new System.Drawing.Point(0, 0);
            this.pCart.Name = "pCart";
            this.pCart.Size = new System.Drawing.Size(262, 13);
            this.pCart.TabIndex = 2;
            // 
            // lCart
            // 
            this.lCart.AutoSize = true;
            this.lCart.Location = new System.Drawing.Point(3, 0);
            this.lCart.Name = "lCart";
            this.lCart.Size = new System.Drawing.Size(0, 13);
            this.lCart.TabIndex = 3;
            // 
            // pHistory
            // 
            this.pHistory.Controls.Add(this.bHistory);
            this.pHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pHistory.Location = new System.Drawing.Point(0, 435);
            this.pHistory.Name = "pHistory";
            this.pHistory.Size = new System.Drawing.Size(262, 38);
            this.pHistory.TabIndex = 6;
            // 
            // bHistory
            // 
            this.bHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bHistory.Location = new System.Drawing.Point(127, 3);
            this.bHistory.Name = "bHistory";
            this.bHistory.Size = new System.Drawing.Size(132, 32);
            this.bHistory.TabIndex = 3;
            this.bHistory.Text = "Historia zamówień";
            this.bHistory.UseVisualStyleBackColor = true;
            this.bHistory.Click += new System.EventHandler(this.bHistory_Click);
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
            // pOrderComment
            // 
            this.pOrderComment.Controls.Add(this.eOrderComment);
            this.pOrderComment.Controls.Add(this.lOrderComment);
            this.pOrderComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOrderComment.Location = new System.Drawing.Point(0, 13);
            this.pOrderComment.Name = "pOrderComment";
            this.pOrderComment.Size = new System.Drawing.Size(262, 74);
            this.pOrderComment.TabIndex = 5;
            // 
            // lOrderComment
            // 
            this.lOrderComment.AutoSize = true;
            this.lOrderComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOrderComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lOrderComment.Location = new System.Drawing.Point(0, 0);
            this.lOrderComment.Name = "lOrderComment";
            this.lOrderComment.Size = new System.Drawing.Size(49, 16);
            this.lOrderComment.TabIndex = 0;
            this.lOrderComment.Text = "Uwagi:";
            // 
            // eOrderComment
            // 
            this.eOrderComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eOrderComment.Location = new System.Drawing.Point(0, 16);
            this.eOrderComment.Multiline = true;
            this.eOrderComment.Name = "eOrderComment";
            this.eOrderComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eOrderComment.Size = new System.Drawing.Size(262, 58);
            this.eOrderComment.TabIndex = 1;
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
            this.pGroupSum.ResumeLayout(false);
            this.pGroupSum.PerformLayout();
            this.pCancel.ResumeLayout(false);
            this.pOrder.ResumeLayout(false);
            this.pOrder.PerformLayout();
            this.pCart.ResumeLayout(false);
            this.pCart.PerformLayout();
            this.pHistory.ResumeLayout(false);
            this.pOrderComment.ResumeLayout(false);
            this.pOrderComment.PerformLayout();
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
        private System.Windows.Forms.Label lSummary;
        private System.Windows.Forms.Button bHistory;
        private System.Windows.Forms.Panel pCancel;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Panel pGroupSum;
        private System.Windows.Forms.Panel pHistory;
        private System.Windows.Forms.Panel pOrderComment;
        private System.Windows.Forms.TextBox eOrderComment;
        private System.Windows.Forms.Label lOrderComment;
    }
}

