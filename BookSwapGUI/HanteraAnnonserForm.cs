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
    public partial class HanteraAnnonserForm : Form
    {
        private readonly InMemoryDatabase _databas;
        public HanteraAnnonserForm(InMemoryDatabase databas)
        {
            InitializeComponent();
            _databas = databas;
            VisaAnnonser();
        }

        private void VisaAnnonser()
        {
            dgvAnnonser.DataSource = null;
            dgvAnnonser.DataSource = _databas.Annonser.Select
             (a => new
             {
                 a.AnnonsID,
                 a.Titel,
                 a.Skick,
                 a.Pris,
                 a.Status,
                 AnnonsTyp = a.GetType().Name,
                 Säljare = a.Säljare.Förnamn + " " + a.Säljare.Efternamn,
                 Kurs = a.Kurs.Kursnamn,
                 a.Publiceringsdatum
             })

             .ToList();
        }

        private void btnTaBortAnnons_Click(object sender, EventArgs e)
        {
            if (dgvAnnonser.CurrentRow == null ||
                dgvAnnonser.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Välj en annons att ta bort.");
                return;
            }

            int annonsID = Convert.ToInt32(
                dgvAnnonser.CurrentRow.Cells["AnnonsID"].Value);

            Annons? annons = _databas.HämtaAnnons(annonsID);

            if (annons == null)
            {
                MessageBox.Show("Annonsen kunde inte hittas.");
                return;
            }

            
            bool harAffär = _databas.Affärer
                .Any(a => a.Annons == annons);

            if (harAffär)
            {
                MessageBox.Show(
                    "Annonsen kan inte tas bort eftersom den ingår i en affär.");
                return;
            }

                 DialogResult svar = MessageBox.Show(
                "Vill du verkligen ta bort annonsen: " + annons.Titel + "?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (svar != DialogResult.Yes)
                return;

            _databas.Annonser.Remove(annons);

            VisaAnnonser();

            MessageBox.Show("Annonsen har tagits bort!");

        }

        private void btnGranskaAnnons_Click(object sender, EventArgs e)
        {
            if (dgvAnnonser.CurrentRow == null || dgvAnnonser.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Välj en annons att granska.");
                return;
            }

            int annonsID = Convert.ToInt32(
                dgvAnnonser.CurrentRow.Cells["AnnonsID"].Value);

            Annons? annons = _databas.HämtaAnnons(annonsID);

            if (annons == null)
            {
                MessageBox.Show("Annonsen kunde inte hittas.");
                return;
            }

                string information =
                "AnnonsID: " + annons.AnnonsID + "\n" +
                "Titel: " + annons.Titel + "\n" +
                "Annonstyp: " + annons.GetType().Name + "\n" +
                "Pris: " + annons.Pris + " kr\n" +
                "Skick: " + annons.Skick + "\n" +
                "Status: " + annons.Status + "\n" +
                "Säljare: " + annons.Säljare.Förnamn + " " +
                             annons.Säljare.Efternamn + "\n" +
                "E-post: " + annons.Säljare.Epost + "\n" +
                "Kurs: " + annons.Kurs.Kursnamn + "\n" +
                "Publicerad: " +
                annons.Publiceringsdatum.ToString("yyyy-MM-dd");

                 MessageBox.Show(
                information,
                "Granska annons",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
