namespace BigWinLotto
{
    partial class MainForm1
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
            this.listRecentTickets = new System.Windows.Forms.ListBox();
            this.listPurchased = new System.Windows.Forms.ListBox();
            this.btnDrawNumbers = new System.Windows.Forms.Button();
            this.btnPurchaseTix = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnFavoriteNumbers = new System.Windows.Forms.Button();
            this.listLastWinners = new System.Windows.Forms.ListBox();
            this.btnQuickPick = new System.Windows.Forms.Button();
            this.labelJackpot = new System.Windows.Forms.Label();
            this.labelJPAmount = new System.Windows.Forms.Label();
            this.labelWinnings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listRecentTickets
            // 
            this.listRecentTickets.FormattingEnabled = true;
            this.listRecentTickets.Location = new System.Drawing.Point(12, 191);
            this.listRecentTickets.Name = "listRecentTickets";
            this.listRecentTickets.Size = new System.Drawing.Size(208, 134);
            this.listRecentTickets.TabIndex = 0;
            // 
            // listPurchased
            // 
            this.listPurchased.FormattingEnabled = true;
            this.listPurchased.Location = new System.Drawing.Point(12, 44);
            this.listPurchased.Name = "listPurchased";
            this.listPurchased.Size = new System.Drawing.Size(208, 134);
            this.listPurchased.TabIndex = 1;
            // 
            // btnDrawNumbers
            // 
            this.btnDrawNumbers.Location = new System.Drawing.Point(226, 138);
            this.btnDrawNumbers.Name = "btnDrawNumbers";
            this.btnDrawNumbers.Size = new System.Drawing.Size(75, 40);
            this.btnDrawNumbers.TabIndex = 2;
            this.btnDrawNumbers.Text = "Start Drawing";
            this.btnDrawNumbers.UseVisualStyleBackColor = true;
            this.btnDrawNumbers.Click += new System.EventHandler(this.btnDrawNumbers_Click);
            // 
            // btnPurchaseTix
            // 
            this.btnPurchaseTix.Location = new System.Drawing.Point(226, 44);
            this.btnPurchaseTix.Name = "btnPurchaseTix";
            this.btnPurchaseTix.Size = new System.Drawing.Size(75, 40);
            this.btnPurchaseTix.TabIndex = 3;
            this.btnPurchaseTix.Text = "Purchase Tickets";
            this.btnPurchaseTix.UseVisualStyleBackColor = true;
            this.btnPurchaseTix.Click += new System.EventHandler(this.btnPurchaseTix_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(226, 239);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 40);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Player Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnFavoriteNumbers
            // 
            this.btnFavoriteNumbers.Location = new System.Drawing.Point(226, 285);
            this.btnFavoriteNumbers.Name = "btnFavoriteNumbers";
            this.btnFavoriteNumbers.Size = new System.Drawing.Size(75, 40);
            this.btnFavoriteNumbers.TabIndex = 5;
            this.btnFavoriteNumbers.Text = "Favorite Numbers";
            this.btnFavoriteNumbers.UseVisualStyleBackColor = true;
            this.btnFavoriteNumbers.Click += new System.EventHandler(this.btnFavoriteNumbers_Click);
            // 
            // listLastWinners
            // 
            this.listLastWinners.FormattingEnabled = true;
            this.listLastWinners.Location = new System.Drawing.Point(181, 331);
            this.listLastWinners.Name = "listLastWinners";
            this.listLastWinners.Size = new System.Drawing.Size(120, 30);
            this.listLastWinners.TabIndex = 6;
            this.listLastWinners.SelectedIndexChanged += new System.EventHandler(this.listLastWinners_SelectedIndexChanged);
            // 
            // btnQuickPick
            // 
            this.btnQuickPick.Location = new System.Drawing.Point(226, 92);
            this.btnQuickPick.Name = "btnQuickPick";
            this.btnQuickPick.Size = new System.Drawing.Size(75, 40);
            this.btnQuickPick.TabIndex = 7;
            this.btnQuickPick.Text = "Quick Pick";
            this.btnQuickPick.UseVisualStyleBackColor = true;
            this.btnQuickPick.Click += new System.EventHandler(this.btnQuickPick_Click);
            // 
            // labelJackpot
            // 
            this.labelJackpot.AutoSize = true;
            this.labelJackpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJackpot.Location = new System.Drawing.Point(11, 343);
            this.labelJackpot.Name = "labelJackpot";
            this.labelJackpot.Size = new System.Drawing.Size(62, 13);
            this.labelJackpot.TabIndex = 8;
            this.labelJackpot.Text = "JACKPOT";
            // 
            // labelJPAmount
            // 
            this.labelJPAmount.AutoSize = true;
            this.labelJPAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJPAmount.Location = new System.Drawing.Point(72, 343);
            this.labelJPAmount.Name = "labelJPAmount";
            this.labelJPAmount.Size = new System.Drawing.Size(63, 13);
            this.labelJPAmount.TabIndex = 9;
            this.labelJPAmount.Text = "45000000";
            // 
            // labelWinnings
            // 
            this.labelWinnings.AutoSize = true;
            this.labelWinnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinnings.Location = new System.Drawing.Point(133, 9);
            this.labelWinnings.Name = "labelWinnings";
            this.labelWinnings.Size = new System.Drawing.Size(42, 13);
            this.labelWinnings.TabIndex = 11;
            this.labelWinnings.Text = "30000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "$";
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWinnings);
            this.Controls.Add(this.labelJPAmount);
            this.Controls.Add(this.labelJackpot);
            this.Controls.Add(this.btnQuickPick);
            this.Controls.Add(this.listLastWinners);
            this.Controls.Add(this.btnFavoriteNumbers);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnPurchaseTix);
            this.Controls.Add(this.btnDrawNumbers);
            this.Controls.Add(this.listPurchased);
            this.Controls.Add(this.listRecentTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm1";
            this.Text = "Big Win Lotto";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRecentTickets;
        private System.Windows.Forms.Button btnDrawNumbers;
        private System.Windows.Forms.Button btnPurchaseTix;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnFavoriteNumbers;
        private System.Windows.Forms.Button btnQuickPick;
        private System.Windows.Forms.Label labelJackpot;
        public System.Windows.Forms.ListBox listPurchased;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelWinnings;
        public System.Windows.Forms.Label labelJPAmount;
        public System.Windows.Forms.ListBox listLastWinners;
    }
}

