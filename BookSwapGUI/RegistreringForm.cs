using Models;
using Services;
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
    public partial class RegistreringForm : Form
    {
        private readonly RegistreringService _registreringService;

        public RegistreringForm(InMemoryDatabase databas)
        {
            InitializeComponent();
            _registreringService = new RegistreringService(databas);
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            string förnamn = txtFornamn.Text.Trim();
            string efternamn = txtEfternamn.Text.Trim();
            string epost = txtEpost.Text.Trim();
            string telefonnummer = txtTelefon.Text.Trim();
            string användarnamn = txtAnvandarnamn.Text.Trim();
            string lösenord = txtLosenord.Text;

            bool lyckadRegistrering = _registreringService.RegistreraStudent(
                förnamn,
                efternamn,
                epost,
                telefonnummer,
                användarnamn,
                lösenord);

            if (lyckadRegistrering)
            {
                MessageBox.Show("Kontot har skapats! Du kan nu logga in.");
                
                DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                MessageBox.Show("Registreringen misslyckades. Kontrollera uppgifterna eller välj en annan e-postadress och ett annat användarnamn.");
            }
        }
    }
}
