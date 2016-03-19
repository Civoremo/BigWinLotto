namespace BigWinLotto
{
    partial class FormPowerballPurchase
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPowerBallPurchase = new System.Windows.Forms.ListBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.listBoxCurrentSelectedNumbers = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWalletAmountPrchs = new System.Windows.Forms.Label();
            this.btnAddFavorite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPowerBallPurchase
            // 
            this.listBoxPowerBallPurchase.FormattingEnabled = true;
            this.listBoxPowerBallPurchase.Location = new System.Drawing.Point(320, 33);
            this.listBoxPowerBallPurchase.Name = "listBoxPowerBallPurchase";
            this.listBoxPowerBallPurchase.Size = new System.Drawing.Size(158, 264);
            this.listBoxPowerBallPurchase.TabIndex = 1;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(161, 342);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // listBoxCurrentSelectedNumbers
            // 
            this.listBoxCurrentSelectedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxCurrentSelectedNumbers.FormattingEnabled = true;
            this.listBoxCurrentSelectedNumbers.ItemHeight = 16;
            this.listBoxCurrentSelectedNumbers.Location = new System.Drawing.Point(12, 342);
            this.listBoxCurrentSelectedNumbers.Name = "listBoxCurrentSelectedNumbers";
            this.listBoxCurrentSelectedNumbers.Size = new System.Drawing.Size(143, 20);
            this.listBoxCurrentSelectedNumbers.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(242, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "$";
            // 
            // labelWalletAmountPrchs
            // 
            this.labelWalletAmountPrchs.AutoSize = true;
            this.labelWalletAmountPrchs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWalletAmountPrchs.Location = new System.Drawing.Point(385, 9);
            this.labelWalletAmountPrchs.Name = "labelWalletAmountPrchs";
            this.labelWalletAmountPrchs.Size = new System.Drawing.Size(49, 13);
            this.labelWalletAmountPrchs.TabIndex = 9;
            this.labelWalletAmountPrchs.Text = "346237";
            // 
            // btnAddFavorite
            // 
            this.btnAddFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddFavorite.Location = new System.Drawing.Point(459, 303);
            this.btnAddFavorite.Name = "btnAddFavorite";
            this.btnAddFavorite.Size = new System.Drawing.Size(19, 23);
            this.btnAddFavorite.TabIndex = 11;
            this.btnAddFavorite.Text = "+";
            this.btnAddFavorite.UseVisualStyleBackColor = true;
            this.btnAddFavorite.Click += new System.EventHandler(this.btnAddFavorite_Click);
            // 
            // FormPowerballPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 377);
            this.Controls.Add(this.btnAddFavorite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWalletAmountPrchs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBoxCurrentSelectedNumbers);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.listBoxPowerBallPurchase);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPowerballPurchase";
            this.Text = "PowerBall Purchase Form";
            this.Load += new System.EventHandler(this.FormPowerballPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPowerBallPurchase;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.ListBox listBoxCurrentSelectedNumbers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWalletAmountPrchs;
        private System.Windows.Forms.Button btnAddFavorite;
    }
}