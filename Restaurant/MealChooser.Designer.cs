namespace Restaurant
{
    partial class MealChooser
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
            this.lName = new System.Windows.Forms.Label();
            this.eQuantity = new System.Windows.Forms.NumericUpDown();
            this.bExpandAdditives = new System.Windows.Forms.Button();
            this.lCost = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.bAdd = new System.Windows.Forms.Button();
            this.pAdditives = new System.Windows.Forms.Panel();
            this.pMargin = new System.Windows.Forms.Panel();
            this.pBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eQuantity)).BeginInit();
            this.pMain.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(3, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(33, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "name";
            // 
            // eQuantity
            // 
            this.eQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eQuantity.Location = new System.Drawing.Point(210, 7);
            this.eQuantity.Name = "eQuantity";
            this.eQuantity.Size = new System.Drawing.Size(55, 20);
            this.eQuantity.TabIndex = 1;
            this.eQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bExpandAdditives
            // 
            this.bExpandAdditives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExpandAdditives.Location = new System.Drawing.Point(271, 7);
            this.bExpandAdditives.Name = "bExpandAdditives";
            this.bExpandAdditives.Size = new System.Drawing.Size(20, 20);
            this.bExpandAdditives.TabIndex = 2;
            this.bExpandAdditives.Text = "v";
            this.bExpandAdditives.UseVisualStyleBackColor = true;
            this.bExpandAdditives.Click += new System.EventHandler(this.bExpandAdditives_Click);
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(3, 28);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(27, 13);
            this.lCost.TabIndex = 3;
            this.lCost.Text = "cost";
            // 
            // pMain
            // 
            this.pMain.AutoSize = true;
            this.pMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pMain.Controls.Add(this.bAdd);
            this.pMain.Controls.Add(this.bExpandAdditives);
            this.pMain.Controls.Add(this.lCost);
            this.pMain.Controls.Add(this.lName);
            this.pMain.Controls.Add(this.eQuantity);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(320, 41);
            this.pMain.TabIndex = 4;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(297, 7);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(20, 20);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // pAdditives
            // 
            this.pAdditives.AutoSize = true;
            this.pAdditives.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pAdditives.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pAdditives.Location = new System.Drawing.Point(40, 0);
            this.pAdditives.Name = "pAdditives";
            this.pAdditives.Size = new System.Drawing.Size(280, 0);
            this.pAdditives.TabIndex = 5;
            // 
            // pMargin
            // 
            this.pMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMargin.Location = new System.Drawing.Point(0, 0);
            this.pMargin.Name = "pMargin";
            this.pMargin.Size = new System.Drawing.Size(40, 0);
            this.pMargin.TabIndex = 4;
            // 
            // pBottom
            // 
            this.pBottom.AutoSize = true;
            this.pBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pBottom.Controls.Add(this.pAdditives);
            this.pBottom.Controls.Add(this.pMargin);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 41);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(320, 0);
            this.pBottom.TabIndex = 4;
            // 
            // MealChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pBottom);
            this.Name = "MealChooser";
            this.Size = new System.Drawing.Size(320, 41);
            this.Load += new System.EventHandler(this.MealChooser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eQuantity)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.pBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.NumericUpDown eQuantity;
        private System.Windows.Forms.Button bExpandAdditives;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pAdditives;
        private System.Windows.Forms.Panel pMargin;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Button bAdd;
    }
}
