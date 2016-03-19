using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigWinLotto
{
    public partial class FormPurchase : Form
    {
        MainForm1 formMain;
        bool[] numberOfSelected = new bool[5] { false, false, false, false, false };
        bool pbNumberSelected = false;

        public FormPurchase(Form mainFrm)
        {
            formMain = (MainForm1)mainFrm;
            formMain.Hide();
            InitializeComponent();
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            labelWalletAmountPrchs.Text = formMain.labelWinnings.Text;
        }

        private void btnPurchaseNmbrs_Click(object sender, EventArgs e)
        {
            double tempMoney;

            tempMoney = Convert.ToDouble(labelWalletAmountPrchs.Text);
            tempMoney -= 5;
            labelWalletAmountPrchs.Text = Convert.ToString(tempMoney);
        }

        private void btnPrchsDone_Click(object sender, EventArgs e)
        {
            formMain.labelWinnings.Text = labelWalletAmountPrchs.Text;
            Close();
            formMain.Show();
        }
    }
}
