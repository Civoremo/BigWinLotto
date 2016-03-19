namespace BigWinLotto
{
    partial class FormFavoriteNumbers
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
            this.listBoxFavoriteNumbers = new System.Windows.Forms.ListBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.listBoxFavoritesPurchased = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxFavoriteNumbers
            // 
            this.listBoxFavoriteNumbers.FormattingEnabled = true;
            this.listBoxFavoriteNumbers.Location = new System.Drawing.Point(12, 12);
            this.listBoxFavoriteNumbers.Name = "listBoxFavoriteNumbers";
            this.listBoxFavoriteNumbers.Size = new System.Drawing.Size(165, 290);
            this.listBoxFavoriteNumbers.TabIndex = 0;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(53, 313);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Purchase";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(241, 313);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // listBoxFavoritesPurchased
            // 
            this.listBoxFavoritesPurchased.FormattingEnabled = true;
            this.listBoxFavoritesPurchased.Location = new System.Drawing.Point(208, 12);
            this.listBoxFavoritesPurchased.Name = "listBoxFavoritesPurchased";
            this.listBoxFavoritesPurchased.Size = new System.Drawing.Size(152, 290);
            this.listBoxFavoritesPurchased.TabIndex = 3;
            // 
            // FormFavoriteNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 348);
            this.Controls.Add(this.listBoxFavoritesPurchased);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.listBoxFavoriteNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFavoriteNumbers";
            this.Text = "Favorite Numbers";
            this.Load += new System.EventHandler(this.FormFavoriteNumbers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFavoriteNumbers;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox listBoxFavoritesPurchased;
    }
}