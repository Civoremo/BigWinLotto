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
    public partial class FormFavoriteNumbers : Form
    {
        MainForm1 formMain;

        public FormFavoriteNumbers(MainForm1 frmMain)
        {
            formMain = (MainForm1)frmMain;
            InitializeComponent();
        }

        private void FormFavoriteNumbers_Load(object sender, EventArgs e)
        {
            formMain.Hide();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
            formMain.Show();
        }
    }
}
