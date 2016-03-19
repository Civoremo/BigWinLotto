using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BigWinLotto
{
    public partial class FormPowerballPurchase : Form
    {
        MainForm1 formMain;

        string buttonText;
        bool[] bNumbersSelected = new bool[5] { false, false, false, false, false };
        bool bPBSelected = false;
        int[] numbers = new int[6];

        Button[] pbNumberButtons = new Button[25];
        Button[] numberButtons = new Button[69];

        public FormPowerballPurchase(MainForm1 frmMain)
        {
            formMain = (MainForm1)frmMain;
            formMain.Hide();
            InitializeComponent();
        }

        private void FormPowerballPurchase_Load(object sender, EventArgs e)
        {
            labelWalletAmountPrchs.Text = formMain.labelWinnings.Text;
            ButtonGridGenerator();
            ButtonPBGridNumbers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < listBoxPowerBallPurchase.Items.Count; x++)
            {
                formMain.listPurchased.Items.Add(listBoxPowerBallPurchase.Items[x]);
            }

            formMain.labelWinnings.Text = labelWalletAmountPrchs.Text;

            Close();
            formMain.Show();
        }

        public void ButtonGridGenerator()
        {
            ArrayList alButtonLocationY = new ArrayList();
            ArrayList alButtonLocationX = new ArrayList();
            

            Point buttonLocation = new Point(7, 15);
            Point buttonOrigin = new Point(7, 15);

            int t = 1;
            bool done = false;

            if (done == false)
            {
                for (int d = 0; d < 69; d++)
                {
                    alButtonLocationX.Add(buttonLocation.X);
                    alButtonLocationY.Add(buttonLocation.Y);
                    buttonLocation.X += 30;

                    if (d == 8 || d == 17 || d == 26 || d == 35 || d == 44 || d == 53 || d == 62)
                    {
                        Point temp = new Point((int)alButtonLocationX[d], (int)alButtonLocationY[d]);

                        buttonLocation.X = 7;
                        buttonLocation.Y += 25;
                        Button button = new Button();
                        button.BackColor = Color.Gray;
                        button.Text = "" + (t); t++;
                        buttonText = button.Text.ToString();
                        button.Click += bt_NumberClick;
                        button.Size = new Size(30, 25);
                        button.Location = temp;
                        numberButtons[d] = button;
                        Controls.Add(numberButtons[d]);
                    } //end if
                    else
                    {
                        Point temp = new Point((int)alButtonLocationX[d], (int)alButtonLocationY[d]);

                        Button button = new Button();
                        button.BackColor = Color.Gray;
                        button.Text = "" + (t); t++;
                        buttonText = button.Text.ToString();
                        button.Click += bt_NumberClick;
                        button.Size = new Size(30, 25);
                        button.Location = temp;
                        numberButtons[d] = button;
                        Controls.Add(numberButtons[d]);
                    }//end else
                } // end for(d)
            } //end if

            done = true; //change bool(done)
        }

        public void ButtonPBGridNumbers()
        {
            ArrayList alButtonLocationY = new ArrayList();
            ArrayList alButtonLocationX = new ArrayList();
            

            Point buttonLocation = new Point(7, 240);
            Point buttonOrigin = new Point(7, 240);

            int t = 1;
            bool done = false;

            if (done == false)
            {
                for (int d = 0; d < 25; d++)
                {
                    alButtonLocationX.Add(buttonLocation.X);
                    alButtonLocationY.Add(buttonLocation.Y);
                    buttonLocation.X += 30;

                    if (d == 8 || d == 17 || d == 26 || d == 35 || d == 44 || d == 53 || d == 62)
                    {
                        Point temp = new Point((int)alButtonLocationX[d], (int)alButtonLocationY[d]);

                        buttonLocation.X = 7;
                        buttonLocation.Y += 25;
                        Button button = new Button();
                        button.BackColor = Color.Gray;
                        button.Text = "" + (t); t++;
                        buttonText = button.Text.ToString();
                        button.Click += bt_PBClick;
                        button.Size = new Size(30, 25);
                        button.Location = temp;
                        pbNumberButtons[d] = button;
                        Controls.Add(pbNumberButtons[d]);
                    } //end if
                    else
                    {
                        Point temp = new Point((int)alButtonLocationX[d], (int)alButtonLocationY[d]);

                        Button button = new Button();
                        button.BackColor = Color.Gray;
                        button.Text = "" + (t); t++;
                        buttonText = button.Text.ToString();
                        button.Click += bt_PBClick;
                        button.Size = new Size(30, 25);
                        button.Location = temp;
                        pbNumberButtons[d] = button;
                        Controls.Add(pbNumberButtons[d]);
                    }//end else
                } // end for(d)
            } //end if

            done = true; //change bool(done)
        }

        private void bt_NumberClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (bNumbersSelected[0] == false)
            {
                listBoxCurrentSelectedNumbers.Items.Add("");
                listBoxCurrentSelectedNumbers.Items[0] = "";
                clickedButton.BackColor = Color.Green;
                NumbersPicked(clickedButton.Text);
                clickedButton.Enabled = false;
                bNumbersSelected[0] = true;
            }
            else if (bNumbersSelected[1] == false)
            {
                clickedButton.BackColor = Color.Green;
                NumbersPicked(clickedButton.Text);
                clickedButton.Enabled = false;
                bNumbersSelected[1] = true;
            }
            else if(bNumbersSelected[2] == false)
            {
                clickedButton.BackColor = Color.Green;
                NumbersPicked(clickedButton.Text);
                clickedButton.Enabled = false;
                bNumbersSelected[2] = true;
            }
            else if(bNumbersSelected[3] == false)
            {
                clickedButton.BackColor = Color.Green;
                NumbersPicked(clickedButton.Text);
                clickedButton.Enabled = false;
                bNumbersSelected[3] = true;
            }
            else if(bNumbersSelected[4] == false)
            {
                clickedButton.BackColor = Color.Green;
                NumbersPicked(clickedButton.Text);
                clickedButton.Enabled = false;
                bNumbersSelected[4] = true;
            }
            else
            {

            }
        }

        private void bt_PBClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if(bPBSelected == false && bNumbersSelected[0] == true && bNumbersSelected[1] == true && bNumbersSelected[2] == true && bNumbersSelected[3] == true)
            {
                clickedButton.BackColor = Color.Red;
                PBNumberPicked(clickedButton.Text);
                clickedButton.Enabled = false;
                bPBSelected = true;
                
            }
            else
            {
                MessageBox.Show("Pick Numbers Before the PowerBall.");
            }
        }

        public void NumbersPicked(string numSelected)
        {
            string tempString = listBoxCurrentSelectedNumbers.Items[0].ToString();

            tempString = tempString + numSelected + " ";

            listBoxCurrentSelectedNumbers.Items[0] = tempString;
        }

        public void PBNumberPicked(string numSelected)
        {
            string tempString = listBoxCurrentSelectedNumbers.Items[0].ToString();

            tempString = tempString + numSelected;

            listBoxCurrentSelectedNumbers.Items[0] = tempString;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelectionsOfNumbers();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (bNumbersSelected[0] == true && bNumbersSelected[1] == true && bNumbersSelected[2] == true && bNumbersSelected[3] == true && bNumbersSelected[4] == true && bPBSelected == true)
            {
                string temp = listBoxCurrentSelectedNumbers.Items[0].ToString();
                double tempNum;
                // listBoxPowerBallPurchase.Items.Add(listBoxCurrentSelectedNumbers.Items[0].ToString());
                SortPurchasedNumbers(temp);
                ClearSelectionsOfNumbers();

                tempNum = Convert.ToDouble(labelWalletAmountPrchs.Text);
                tempNum -= 5;
                labelWalletAmountPrchs.Text = Convert.ToString(tempNum);
            }
            else
            {
                MessageBox.Show("Not Enough Numbers Picked.");
            }
        }

        public void ClearSelectionsOfNumbers()
        {
            bNumbersSelected[0] = false;
            bNumbersSelected[1] = false;
            bNumbersSelected[2] = false;
            bNumbersSelected[3] = false;
            bNumbersSelected[4] = false;

            bPBSelected = false;

            listBoxCurrentSelectedNumbers.Items.Clear();

            foreach (Button btn in numberButtons)
            {
                btn.Enabled = true;
                btn.BackColor = Color.Gray;
            }

            foreach (Button btn in pbNumberButtons)
            {
                btn.Enabled = true;
                btn.BackColor = Color.Gray;
            }
        }

        public void SortPurchasedNumbers(string numbs)
        {
            string numsString = numbs;
            int index = 0;
            int[] numbersSel = new int[6];
            int[] tempNum = new int[5];
            int pbNumber;
            string[] selectedNumbersString;
            Random ranNumber = new Random();

            selectedNumbersString = numsString.Split(new char[] { ' ' });

            for (int i = 0; i < selectedNumbersString.Count(); i++)
            {
                numbersSel[index] = Convert.ToInt16(selectedNumbersString[i]);
                index++;
            }

            pbNumber = numbersSel[5];

            for (int x = 0; x < tempNum.Count(); x++)
            {
                tempNum[x] = numbersSel[x];
            }

            for (int k = 0; k < tempNum.Count() - 1; k++)
            {
                int temp;

                for (int u = tempNum.Count() - 1; u >= 0; u--)
                {
                    if (u < 4 && tempNum[u] == tempNum[u + 1])
                    {
                        tempNum[u] = ranNumber.Next(1, 69);
                    }

                    if (u < 4)
                    {
                        if (tempNum[u + 1] < tempNum[u])
                        {
                            temp = tempNum[u + 1];
                            tempNum[u + 1] = tempNum[u];
                            tempNum[u] = temp;
                        }
                    }
                } //end for(u)
            } // end for(k)

            listBoxPowerBallPurchase.Items.Add("" + tempNum[0] + "-" + tempNum[1] + "-" + tempNum[2] + "-" + tempNum[3] + "-" + tempNum[4] + "\t" + pbNumber);

        }

        private void btnAddFavorite_Click(object sender, EventArgs e)
        {

        }
    }
}
