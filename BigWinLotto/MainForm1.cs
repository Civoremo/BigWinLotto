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
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void btnPurchaseTix_Click(object sender, EventArgs e)
        {
            //FormPurchase frmPrchs = new FormPurchase(this);
            //frmPrchs.ControlBox = false;
            //frmPrchs.Show();

            FormPowerballPurchase frmPBPurchase = new FormPowerballPurchase(this);
            frmPBPurchase.ControlBox = false;
            frmPBPurchase.Show();
            
        }

        private void btnQuickPick_Click(object sender, EventArgs e)
        {
            FormRandomGenerator frmRndGnrt = new FormRandomGenerator(this);
            frmRndGnrt.ControlBox = false;
            frmRndGnrt.Show();
        }

        private void btnDrawNumbers_Click(object sender, EventArgs e)
        {
            if(listPurchased.Items.Count > 0)
            {
                FormDrawResults frmDrwRslts = new FormDrawResults(this);
                frmDrwRslts.ControlBox = false;
                frmDrwRslts.Show();
            }
            else
            {
                MessageBox.Show("Purchase Ticket to Play.");
            }
        }

        private void listLastWinners_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            listLastWinners.Items.Add("");
        }

        private void btnFavoriteNumbers_Click(object sender, EventArgs e)
        {
            FormFavoriteNumbers frmFav = new FormFavoriteNumbers(this);
            frmFav.ControlBox = false;
            frmFav.Show();
        }
    }
}
