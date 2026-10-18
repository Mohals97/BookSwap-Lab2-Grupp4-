
using Models;
using Services;
using System;
using System.Windows.Forms;

namespace BookSwapGUI
{
    public partial class LoginFoem : Form
    {
        private readonly InloggningService _inloggningService;
        private readonly InMemoryDatabase _databas;

        public Student? InloggadStudent { get; private set; }
        public Administratör? InloggadAdmin { get; private set; }

        public LoginFoem(InMemoryDatabase database)
        {
            InitializeComponent();

            _databas = database;
            _inloggningService = new InloggningService(database);
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string epost = txtEpost.Text.Trim();
            string lösenord = txtLosenord.Text;

            Student? student = _inloggningService.LoggaIn(
                epost, lösenord);

            if (student != null)
            {
                InloggadStudent = student;
                InloggadAdmin = null;
                MessageBox.Show("Välkommen " + student.Förnamn + "!");
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            Administratör? administratör = _inloggningService.LoggaInAdmin(
                epost, lösenord);
            if (administratör != null)
            {
                InloggadAdmin = administratör;
                InloggadStudent = null;
                MessageBox.Show("Välkommen " + administratör.Namn + "!");
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("Fel e-postadress eller lösenord.");
        }

        private void btnSkapaKonto_Click(object sender, EventArgs e)
        {
           using (RegistreringForm registrering = new RegistreringForm(_databas))

            registrering.ShowDialog();
        }
    }
}
