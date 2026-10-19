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
    public partial class HanteraKurserForm : Form
    {
        private readonly InMemoryDatabase _databas;
        public HanteraKurserForm(InMemoryDatabase databas)
        {
            InitializeComponent();

            _databas = databas;

            VisaKurser();
        }

        private void VisaKurser()
        {
            dgvKurser.DataSource = null;

            dgvKurser.DataSource = _databas.Kurser.Select
             (k => new
             {
                 k.Kurskod,
                 k.Kursnamn,
                 k.Status
             }
             )
             .ToList();

        }

        private void btnLaggTillKurs_Click(object sender, EventArgs e)
        {
            string kurskod = txtKurskod.Text.Trim();
            string kursnamn = txtKursnamn.Text.Trim();

            if (string.IsNullOrWhiteSpace(kurskod) ||
                string.IsNullOrWhiteSpace(kursnamn))
            {
                MessageBox.Show("Ange både kurskod och kursnamn.");
                return;
            }

            bool finnsRedan = _databas.Kurser.Any(k =>
            k.Kurskod.Equals(kurskod,
            StringComparison.OrdinalIgnoreCase));

            if (finnsRedan)
            {
                MessageBox.Show("En kurs med denna kurskod finns redan.");
                return;
            }

            Kurs nyKurs = new Kurs(kurskod, kursnamn);
            _databas.Kurser.Add(nyKurs);

            VisaKurser();

            txtKurskod.Clear();
            txtKursnamn.Clear();
            MessageBox.Show("Kursen har lagts till!");
        }

        private void dgvKurser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow rad = dgvKurser.Rows[e.RowIndex];

            txtKurskod.Text = rad.Cells["Kurskod"].Value?.ToString();
            txtKursnamn.Text = rad.Cells["Kursnamn"].Value?.ToString();


        }

        private void btnRedigeraKurs_Click(object sender, EventArgs e)
        {
            if (dgvKurser.CurrentRow == null ||
                dgvKurser.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Välj en kurs att redigera.");
                return;
            }

            string gammalKurskod = dgvKurser.CurrentRow.Cells["Kurskod"].Value?.ToString() ?? "";

            string nyttKursnamn = txtKursnamn.Text.Trim();

            if (string.IsNullOrWhiteSpace(nyttKursnamn))
            {
                MessageBox.Show("Ange ett nytt kursnamn.");
                return;
            }

            Kurs? kurs = _databas.Kurser.FirstOrDefault(k => k.Kurskod == gammalKurskod);

            if (kurs == null)
            {
                MessageBox.Show("Kursen hittades inte.");
                return;
            }

            kurs.Kursnamn = nyttKursnamn;
            VisaKurser();
            MessageBox.Show("Kursen har uppdaterats!");
        }

        private void btnTaBortKurs_Click(object sender, EventArgs e)
        {
            if (dgvKurser.CurrentRow == null || dgvKurser.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Välj en kurs att ta bort.");
                return;
            }

            string kurskod = dgvKurser.CurrentRow.Cells["Kurskod"].Value?.ToString() ?? "";

            Kurs? kurs = _databas.Kurser.FirstOrDefault(k => k.Kurskod == kurskod);

            if (kurs == null)
            {
                MessageBox.Show("Kursen kunde inte hittas.");
                return;
            }

            bool används = _databas.Annonser.Any(a => a.Kurs == kurs);

            if (används)
            {
                MessageBox.Show("Kursen kan inte tas bort eftersom den används av annonser.");
                return;
            }

            DialogResult svar = MessageBox.Show
                ("Vill du verkligen ta bort kursen?", "Bekräfta borttagning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (svar != DialogResult.Yes)
                return;

            _databas.Kurser.Remove(kurs);

            VisaKurser();

            txtKurskod.Clear();
            txtKursnamn.Clear();
            MessageBox.Show("Kursen har tagits bort!");



        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
