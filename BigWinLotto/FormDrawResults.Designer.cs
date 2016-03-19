namespace BigWinLotto
{
    partial class FormDrawResults
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
            this.listDrawResults = new System.Windows.Forms.ListBox();
            this.btnCollect = new System.Windows.Forms.Button();
            this.labelWon = new System.Windows.Forms.Label();
            this.listDrawNumbers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listDrawResults
            // 
            this.listDrawResults.FormattingEnabled = true;
            this.listDrawResults.Location = new System.Drawing.Point(12, 52);
            this.listDrawResults.Name = "listDrawResults";
            this.listDrawResults.Size = new System.Drawing.Size(260, 199);
            this.listDrawResults.TabIndex = 0;
            // 
            // btnCollect
            // 
            this.btnCollect.Location = new System.Drawing.Point(197, 261);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(75, 30);
            this.btnCollect.TabIndex = 2;
            this.btnCollect.Text = "Collect";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // labelWon
            // 
            this.labelWon.AutoSize = true;
            this.labelWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelWon.Location = new System.Drawing.Point(91, 265);
            this.labelWon.Name = "labelWon";
            this.labelWon.Size = new System.Drawing.Size(59, 20);
            this.labelWon.TabIndex = 3;
            this.labelWon.Text = "34832";
            // 
            // listDrawNumbers
            // 
            this.listDrawNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.listDrawNumbers.FormattingEnabled = true;
            this.listDrawNumbers.ItemHeight = 20;
            this.listDrawNumbers.Location = new System.Drawing.Point(44, 12);
            this.listDrawNumbers.Name = "listDrawNumbers";
            this.listDrawNumbers.Size = new System.Drawing.Size(195, 24);
            this.listDrawNumbers.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "$";
            // 
            // FormDrawResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDrawNumbers);
            this.Controls.Add(this.labelWon);
            this.Controls.Add(this.btnCollect);
            this.Controls.Add(this.listDrawResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDrawResults";
            this.Text = "Draw Results";
            this.Load += new System.EventHandler(this.FormDrawResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDrawResults;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Label labelWon;
        private System.Windows.Forms.ListBox listDrawNumbers;
        private System.Windows.Forms.Label label2;
    }
}