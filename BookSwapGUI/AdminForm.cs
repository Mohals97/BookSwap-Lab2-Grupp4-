using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSwapGUI
{
    public partial class AdminForm : Form
    {
        private readonly InMemoryDatabase _databas;
        private readonly Administratör _adnin;

        public AdminForm(InMemoryDatabase databas, Administratör admin)
        {
            InitializeComponent();

            _databas = databas;
            _adnin = admin;

            Text = "BookSwap - Administration";
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void btnHanteraKurser_Click(object sender, EventArgs e)
        {
            using (HanteraKurserForm kurserForm = new HanteraKurserForm(_databas))
            {
                kurserForm.ShowDialog();
            }
        }

        private void btnHanteraAnnonser_Click(object sender, EventArgs e)
        {
            using (HanteraAnnonserForm annonserForm = new HanteraAnnonserForm(_databas))
            {
                annonserForm.ShowDialog();
            }
        }
    }
}
