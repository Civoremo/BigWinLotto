namespace BigWinLotto
{
    partial class FormRandomGenerator
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
            this.listGenerate = new System.Windows.Forms.ListBox();
            this.listPBNum = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.listQuickPickBought = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTicketAmount = new System.Windows.Forms.Label();
            this.labelWalletAmountQP = new System.Windows.Forms.Label();
            this.btnDoneQP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfTimes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listGenerate
            // 
            this.listGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listGenerate.FormattingEnabled = true;
            this.listGenerate.ItemHeight = 20;
            this.listGenerate.Location = new System.Drawing.Point(12, 38);
            this.listGenerate.Name = "listGenerate";
            this.listGenerate.Size = new System.Drawing.Size(162, 24);
            this.listGenerate.TabIndex = 0;
            // 
            // listPBNum
            // 
            this.listPBNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listPBNum.FormattingEnabled = true;
            this.listPBNum.ItemHeight = 20;
            this.listPBNum.Location = new System.Drawing.Point(193, 38);
            this.listPBNum.Name = "listPBNum";
            this.listPBNum.Size = new System.Drawing.Size(59, 24);
            this.listPBNum.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 87);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(107, 87);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // listQuickPickBought
            // 
            this.listQuickPickBought.FormattingEnabled = true;
            this.listQuickPickBought.Location = new System.Drawing.Point(13, 138);
            this.listQuickPickBought.Name = "listQuickPickBought";
            this.listQuickPickBought.Size = new System.Drawing.Size(239, 121);
            this.listQuickPickBought.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cost/Ticket";
            // 
            // labelTicketAmount
            // 
            this.labelTicketAmount.AutoSize = true;
            this.labelTicketAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketAmount.Location = new System.Drawing.Point(92, 13);
            this.labelTicketAmount.Name = "labelTicketAmount";
            this.labelTicketAmount.Size = new System.Drawing.Size(25, 13);
            this.labelTicketAmount.TabIndex = 6;
            this.labelTicketAmount.Text = "$ 5";
            // 
            // labelWalletAmountQP
            // 
            this.labelWalletAmountQP.AutoSize = true;
            this.labelWalletAmountQP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWalletAmountQP.Location = new System.Drawing.Point(185, 13);
            this.labelWalletAmountQP.Name = "labelWalletAmountQP";
            this.labelWalletAmountQP.Size = new System.Drawing.Size(49, 13);
            this.labelWalletAmountQP.TabIndex = 7;
            this.labelWalletAmountQP.Text = "346234";
            // 
            // btnDoneQP
            // 
            this.btnDoneQP.Location = new System.Drawing.Point(95, 275);
            this.btnDoneQP.Name = "btnDoneQP";
            this.btnDoneQP.Size = new System.Drawing.Size(75, 23);
            this.btnDoneQP.TabIndex = 8;
            this.btnDoneQP.Text = "Done";
            this.btnDoneQP.UseVisualStyleBackColor = true;
            this.btnDoneQP.Click += new System.EventHandler(this.btnDoneQP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // textBoxNumberOfTimes
            // 
            this.textBoxNumberOfTimes.Location = new System.Drawing.Point(188, 90);
            this.textBoxNumberOfTimes.MaxLength = 4;
            this.textBoxNumberOfTimes.Name = "textBoxNumberOfTimes";
            this.textBoxNumberOfTimes.Size = new System.Drawing.Size(40, 20);
            this.textBoxNumberOfTimes.TabIndex = 10;
            this.textBoxNumberOfTimes.Text = "100";
            // 
            // FormRandomGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 310);
            this.Controls.Add(this.textBoxNumberOfTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoneQP);
            this.Controls.Add(this.labelWalletAmountQP);
            this.Controls.Add(this.labelTicketAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listQuickPickBought);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.listPBNum);
            this.Controls.Add(this.listGenerate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRandomGenerator";
            this.Text = "Quick Pick";
            this.Load += new System.EventHandler(this.FormRandomGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listGenerate;
        private System.Windows.Forms.ListBox listPBNum;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox listQuickPickBought;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTicketAmount;
        private System.Windows.Forms.Label labelWalletAmountQP;
        private System.Windows.Forms.Button btnDoneQP;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxNumberOfTimes;
    }
}