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
    public partial class FormDrawResults : Form
    {
        MainForm1 formMain;


        public FormDrawResults(Form frmMain)
        {
            formMain = (MainForm1)frmMain;
            formMain.Hide();
            InitializeComponent();
        }

        private void FormDrawResults_Load(object sender, EventArgs e)
        {
            GenerateAndOrganizeNumbers();
            CompareNumbers();

        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            formMain.labelWinnings.Text = Convert.ToString(Convert.ToDouble(labelWon.Text) + Convert.ToDouble(formMain.labelWinnings.Text));
            formMain.labelJPAmount.Text = Convert.ToString(Convert.ToDouble(formMain.labelJPAmount.Text) + 5000000);
            formMain.listLastWinners.Items[0] = listDrawNumbers.Items[0];
            Close();
            formMain.Show();
        }

        public void GenerateAndOrganizeNumbers()
        {
            int[] numbersDrawn = new int[5];
            int powerBall;
            Random randNumbers = new Random();

            for (int x = 0; x < formMain.listPurchased.Items.Count; x++)
            {
                listDrawResults.Items.Add(formMain.listPurchased.Items[x]);
            }

            formMain.listPurchased.Items.Clear();


            powerBall = randNumbers.Next(1, 25);

            for (int x = 0; x < numbersDrawn.Count(); x++)
            {
                numbersDrawn[x] = randNumbers.Next(1, 69);
            }

            for (int k = 0; k < numbersDrawn.Count(); k++)
            {
                int temp;

                for (int u = numbersDrawn.Count(); u >= 0; u--)
                {
                    if (u < 4 && numbersDrawn[u] == numbersDrawn[u + 1])
                    {
                        numbersDrawn[u] = randNumbers.Next(1, 69);
                    }

                    if (u < 4)
                    {
                        if (numbersDrawn[u + 1] < numbersDrawn[u])
                        {
                            temp = numbersDrawn[u + 1];
                            numbersDrawn[u + 1] = numbersDrawn[u];
                            numbersDrawn[u] = temp;
                        }
                    }
                } //end for(u)
            } // end for(k)

            string tempString;
            tempString = "" + numbersDrawn[0] + "-" + numbersDrawn[1] + "-" + numbersDrawn[2] + "-" + numbersDrawn[3] + "-" + numbersDrawn[4] + "\t" + powerBall;

            listDrawNumbers.Items.Add(tempString);
        }

        public void CompareNumbers()
        {
            string[] drawNumbers;
            string[] pickedNumbers;
            string draw;
            string picked;
            string drawPB;
            string pickedPB;

            labelWon.Text = "0";

            draw = listDrawNumbers.Items[0].ToString();
            drawNumbers = draw.Split(new char[] {'-', '\t' });
            drawPB = drawNumbers[drawNumbers.Count() - 1];
            drawNumbers = drawNumbers.Take(drawNumbers.Count() - 1).ToArray();

            for (int i = 0; i < listDrawResults.Items.Count; i++)
            {
                int countOfPicked = 0;

                picked = listDrawResults.Items[i].ToString();
                pickedNumbers = picked.Split(new char[] {'-', '\t' });
                pickedPB = pickedNumbers[pickedNumbers.Count() - 1];
                pickedNumbers = pickedNumbers.Take(pickedNumbers.Count() - 1).ToArray();

                foreach(string num in drawNumbers)
                {
                    foreach(string pick in pickedNumbers)
                    {
                        if (num == pick)
                        {
                            countOfPicked++;
                        }
                    }
                }

                if(countOfPicked == 3)
                {
                    if(drawPB == pickedPB)
                    {
                        listDrawResults.Items[i] = picked + ("\t" + countOfPicked) + "\t" + "Winner";
                        labelWon.Text = Convert.ToString(Convert.ToDouble(labelWon.Text) + 20);
                    }
                    else
                    {
                        listDrawResults.Items[i] = picked + ("\t" + countOfPicked) + "\t" + "Winner";
                        labelWon.Text = Convert.ToString(Convert.ToDouble(labelWon.Text) + 10);
                    }
                }
                else if(countOfPicked == 4)
                {
                    if(drawPB == pickedPB)
                    {
                        listDrawResults.Items[i] = picked + ("\t" + countOfPicked) + "\t" + "Winner";
                        labelWon.Text = Convert.ToString(Convert.ToDouble(labelWon.Text) + 50000);
                    }
                    else
                    {
                        listDrawResults.Items[i] = picked + ("\t" + countOfPicked) + "\t" + "Winner";
                        labelWon.Text = Convert.ToString(Convert.ToDouble(labelWon.Text) + 10000);
                    }
                }
                else if(countOfPicked == 5)
                {
                    if(drawPB == pickedPB)
                    {
                        listDrawResults.Items[i] = picked + ("\t" + countOfPicked) + "\t" + "Winner";
                        labelWon.Text = Convert.ToString(Convert.ToDouble(labelWon.Text) + Convert.ToDouble(formMain.labelJPAmount.Text));
                        formMain.labelJPAmount.Text = "30000000";
                    }
                    else
                    {
                        listDrawResults.Items[i] = picked + ("\t" + countOfPicked) + "\t" + "Winner";
                        labelWon.Text = Convert.ToString(Convert.ToDouble(labelWon.Text) + 1000000);
                    }
                }
                else if(drawPB == pickedPB)
                {
                    listDrawResults.Items[i] = picked + ("\t" + countOfPicked) + "\t" + "Winner";
                    labelWon.Text = Convert.ToString(Convert.ToDouble(labelWon.Text) + 10);
                }
                else
                {
                    listDrawResults.Items[i] = picked + ("\t" + countOfPicked);
                }                
            }
        }
    }
}
