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
    public partial class FormRandomGenerator : Form
    {
        MainForm1 formMain;

        public FormRandomGenerator(Form mainFrm)
        {
            formMain = (MainForm1)mainFrm;
            formMain.Hide();
            InitializeComponent();
        }

        private void FormRandomGenerator_Load(object sender, EventArgs e)
        {
            labelWalletAmountQP.Text = formMain.labelWinnings.Text;
        }

        private  void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateQPList();

        }

        private async void btnBuy_Click(object sender, EventArgs e)
        {
            if (textBoxNumberOfTimes.Text != "")
            {
                for (int x = 0; x < Convert.ToDouble(textBoxNumberOfTimes.Text); x++)
                {
                    GenerateQPList();
                    PurchaseTicket();
                    await Task.Delay(5);

                }
            }
            else
            {
                PurchaseTicket();
            }
        }

        private void btnDoneQP_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < listQuickPickBought.Items.Count; x++)
            {
                formMain.listPurchased.Items.Add(listQuickPickBought.Items[x]);
            }

            formMain.labelWinnings.Text = labelWalletAmountQP.Text;

            Close();
            formMain.Show();
        }

        public void GenerateQPList()
        {
            int pbNumber;
            int[] generatedNums = new int[5];
            Random ranNumber = new Random();

            listGenerate.Items.Clear();
            listPBNum.Items.Clear();

            pbNumber = ranNumber.Next(1, 25);

            for (int x = 0; x < generatedNums.Count(); x++)
            {
                generatedNums[x] = ranNumber.Next(1, 69);
            }

            for (int k = 0; k < generatedNums.Count(); k++)
            {
                int temp;

                for (int u = generatedNums.Count(); u >= 0; u--)
                {
                    if (u < 4 && generatedNums[u] == generatedNums[u + 1])
                    {
                        generatedNums[u] = ranNumber.Next(1, 69);
                    }

                    if (u < 4)
                    {
                        if (generatedNums[u + 1] < generatedNums[u])
                        {
                            temp = generatedNums[u + 1];
                            generatedNums[u + 1] = generatedNums[u];
                            generatedNums[u] = temp;
                        }
                    }
                } //end for(u)
            } // end for(k)

            string tempString = "" + generatedNums[0].ToString() + "-" + generatedNums[1].ToString() + "-" + generatedNums[2].ToString() + "-" + generatedNums[3].ToString() + "-" + generatedNums[4].ToString();

            listGenerate.Items.Insert(0, tempString);
            listPBNum.Items.Insert(0, pbNumber);
        }

        public void PurchaseTicket()
        {
            try
            {
                string tempString;
                string pbString;
                double tempNum;

                pbString = listPBNum.Items[0].ToString();

                tempNum = Convert.ToDouble(labelWalletAmountQP.Text);
                tempNum -= 5;
                labelWalletAmountQP.Text = Convert.ToString(tempNum);

                tempString = listGenerate.Items[0].ToString() + "\t" + listPBNum.Items[0].ToString();

                listQuickPickBought.Items.Add(tempString);

                listGenerate.Items.Clear();
                listPBNum.Items.Clear();
            }
            catch
            {
                double tempNum;

                tempNum = Convert.ToDouble(labelWalletAmountQP.Text);
                tempNum += 5;
                labelWalletAmountQP.Text = Convert.ToString(tempNum);

                MessageBox.Show("Generate Numbers to Continue.");
            }
        }
    }
}
