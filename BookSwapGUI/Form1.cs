
using System;
using System.Linq;
using System.Windows.Forms;
using Models;
using Services;

namespace BookSwapGUI
{
    public partial class Form1 : Form
    {
        private readonly InMemoryDatabase _databas;
        private readonly AnnonsServices _annonsService;
        private readonly Student _inloggadStudent;

        public Form1(InMemoryDatabase databas, Student inloggadStudent)
        {
            InitializeComponent();

            _databas = databas;
            _inloggadStudent = inloggadStudent;

            _annonsService = new AnnonsServices(_databas);

            cmbAnnonsTyp.Items.Add("Kursbok");

            cmbAnnonsTyp.Items.Add("Kompendium");

            cmbAnnonsTyp.Items.Add("DigitalResurs");

            cmbAnnonsTyp.SelectedIndex = 0;



            cmbKurs.DataSource = _databas.Kurser.ToList();
            cmbKurs.DisplayMember = "Kursnamn";
            cmbKurs.ValueMember = "Kurskod";

            cmbFilterKurs.Items.Add("Alla kurser");
            foreach (Kurs kurs in _databas.Kurser)
            {
                cmbFilterKurs.Items.Add(kurs.Kursnamn);
            }

            cmbFilterKurs.SelectedIndex = 0;

            cmbFilterTyp.Items.AddRange(new object[]
            {
                 "Alla typer",
                 "Kursbok",
                 "Kompendium",
                 "DigitalResurs"
            }
            );

            cmbFilterTyp.SelectedIndex = 0;

            VisaAnnonser();
        }

        private void SkapaTestdata()
        {

            Student säljare = new Student(
                1, "Ali", "Ahmed",
                "ali@example.com", "0701234567",
                "ali123", "test123");

            Student köpare = new Student(
                2, "Sara", "Svensson",
                "sara@example.com", "0709876543",
                "sara123", "test123");

            _databas.Studenter.Add(säljare);
            _databas.Studenter.Add(köpare);


            Kurs kurs = new Kurs("NDA01G", "Databasteknik");
            _databas.Kurser.Add(kurs);

            _databas.Kurser.Add(new Kurs("PRG01G", "Programmering i C#"));
            _databas.Kurser.Add(new Kurs("SYS01G", "Systemutveckling"));
            _databas.Kurser.Add(new Kurs("MAR01G", "Marknadsföring"));
            _databas.Kurser.Add(new Kurs("C1IB1A", "Business Intelligence"));


            Kursbok bok = new Kursbok(
                1, "Databasteknik – kursbok",
                250m, "Bra skick",
                säljare, kurs,
                "9781234567890", "Anna Svensson", 2024);

            Kompendium kompendium = new Kompendium(
                2, "SQL-övningar",
                120m, "Bra skick",
                säljare, kurs,
                85, "Övningar inom SQL");

            _databas.Annonser.Add(bok);
            _databas.Annonser.Add(kompendium);

            Kursbok sarasBok = new Kursbok
            (
            3, "Introduktion till SQL",
            180m, "Mycket bra skick",
            köpare, kurs, "9781234567891",
            "Erik Anderson", 2023
            );

            _databas.Annonser.Add(sarasBok);
        }

        private void VisaAnnonser()
        {
            dgvAnnonser.DataSource = null;

            dgvAnnonser.DataSource = _databas.Annonser
                .Select(a => new
                {
                    a.AnnonsID,
                    a.Titel,
                    a.Pris,
                    a.Skick,
                    Status = a.Status.ToString(),
                    Kurs = a.Kurs.Kursnamn,
                    Annonstyp = a.GetType().Name
                })
                .ToList();

            dgvAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnReservera_Click(object sender, EventArgs e)
        {

            if (dgvAnnonser.CurrentRow == null)
            {
                MessageBox.Show("Välj en annons först.");
                return;
            }


            int annonsID = Convert.ToInt32(
                dgvAnnonser.CurrentRow.Cells["AnnonsID"].Value);


            bool lyckades = _annonsService.ReserveraAnnons(
                _inloggadStudent.StudentID,
                annonsID);

            if (lyckades)
            {
                MessageBox.Show("Annonsen har reserverats!");
                VisaAnnonser();
            }
            else
            {
                MessageBox.Show(
                    "Annonsen kunde inte reserveras.");
            }

        }
        private void llabel1_Click(object sender, EventArgs e)
        {
        }

        private void btnBekraftaKop_Click(object sender, EventArgs e)
        {
            if (dgvAnnonser.CurrentRow == null)
            {
                MessageBox.Show("Välj en annons först.");
                return;
            }

            int annonsID = Convert.ToInt32(dgvAnnonser.CurrentRow.Cells["AnnonsID"].Value);

            bool lyckades = _annonsService.BekräftaKöp(_inloggadStudent.StudentID, annonsID);
            if (lyckades)
            {
                MessageBox.Show("Köpet har bekräftats!");
                VisaAnnonser();
            }
            else
            {
                MessageBox.Show("Köpet kunde inte bekräftas. Annonsen måste vara reserverad av dig");
            }
        }

        private void btnMinaAnnonser_Click(object sender, EventArgs e)
        {
            dgvAnnonser.DataSource = null;

            dgvAnnonser.DataSource = _databas.Annonser
                .Where(a => a.Säljare.StudentID == _inloggadStudent.StudentID)
                .Select(a => new
                {
                    a.AnnonsID,
                    a.Titel,
                    a.Pris,
                    a.Skick,
                    Status = a.Status.ToString(),
                    Kurs = a.Kurs.Kursnamn
                })
                .ToList();
        }

        private void btnVisaAlla_Click(object sender, EventArgs e)
        {
            VisaAnnonser();
        }

        private void btnTaBortAnnons_Click(object sender, EventArgs e)
        {
            if (dgvAnnonser.CurrentRow == null)
            {
                MessageBox.Show("Välj en annons först.");
                return;
            }

            int annonsID = Convert.ToInt32(dgvAnnonser.CurrentRow.Cells["AnnonsID"].Value);

            DialogResult svar = MessageBox.Show("Är du säker på att du vill ta bort annonsen?",
                "Bekräfta borttagning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (svar != DialogResult.Yes)
                return;

            bool lyckades = _annonsService.TaBortAnnons(_inloggadStudent.StudentID, annonsID);

            if (lyckades)
            {
                MessageBox.Show("Annonsen har tagits bort!");
                VisaAnnonser();
            }
            else
            {
                MessageBox.Show("Du kan bara ta bort dina egna annonser som är till salu.");
            }
        }

        private void lblNyTitel_Click(object sender, EventArgs e)
        {

        }

        private void btnSparaAndringar_Click(object sender, EventArgs e)
        {
            if (dgvAnnonser.CurrentRow == null)
            {
                MessageBox.Show("Välj en annons först.");
                return;
            }

            int annonsID = Convert.ToInt32(
                dgvAnnonser.CurrentRow.Cells["AnnonsID"].Value);

            string nyTitel = txtNyTitel.Text.Trim();

            if (!decimal.TryParse(txtNyttPris.Text, out decimal nyttPris))
            {
                MessageBox.Show("Ange ett giltigt pris.");
                return;
            }

            bool lyckades = _annonsService.RedigeraAnnons(
                _inloggadStudent.StudentID,
                annonsID,
                nyTitel,
                nyttPris);

            if (lyckades)
            {
                MessageBox.Show("Annonsen har uppdaterats!");

                txtNyTitel.Clear();
                txtNyttPris.Clear();

                VisaAnnonser();
            }
            else
            {
                MessageBox.Show(
                    "Annonsen kunde inte uppdateras. Du får bara redigera dina egna annonser som är till salu.");
            }
        }

        private void btnSkapaAnnons_Click(object sender, EventArgs e)
        {
            string titel = txtTitel.Text.Trim();
            string skick = txtSkick.Text.Trim();

            if (!decimal.TryParse(txtPris.Text, out decimal pris))
            {
                MessageBox.Show("Ange ett giltigt pris.");
                return;
            }
            string annonsTyp = cmbAnnonsTyp.SelectedItem?.ToString() ?? "";
            string kurskod = cmbKurs.SelectedValue?.ToString() ?? "";

            MessageBox.Show(
                     $"StudentID: {_inloggadStudent.StudentID}\n" +
                     $"Titel: {titel}\n" +
                     $"Pris: {pris}\n" +
                     $"Skick: {skick}\n" +
                     $"Annonstyp: {annonsTyp}\n" +
                     $"Kurskod: {kurskod}"
                            );

            bool lyckades = _annonsService.SkapaAnnons(
                _inloggadStudent.StudentID,
                titel,
                pris,
                skick,
                annonsTyp,
                kurskod
                );

            if (lyckades)
            {
                MessageBox.Show("Annonsen har skapats!");

                txtTitel.Clear();
                txtPris.Clear();
                txtSkick.Clear();

                VisaAnnonser();
            }
            else
            {
                MessageBox.Show(
                    "Annonsen kunde inte skapas. Kontrollera titel, pris och skick.");
            }
        }

        private void btnMinaKop_Click(object sender, EventArgs e)
        {
            dgvAnnonser.DataSource = null;

            dgvAnnonser.DataSource = _databas.Affärer.Where(a => a.Köpare.StudentID == _inloggadStudent.StudentID).Select
            (a => new
                {
                    a.AffärID,
                    a.Annons.AnnonsID,
                    a.Annons.Titel,
                    a.Annons.Pris,
                    AnnonsStatus = a.Annons.Status.ToString(),
                    AffärStatus = a.Status.ToString(),
                    a.Datum,
                    Säljare = a.Säljare.Förnamn
                }
            )
                .ToList();

            dgvAnnonser.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void btnSokAnnons_Click(object sender, EventArgs e)
        {
            string sokord = txtSokAnnons.Text.Trim();

            var resultat = _databas.Annonser
                .Where(a =>
                    a.Titel.Contains(sokord,
                        StringComparison.OrdinalIgnoreCase) ||
                    a.Kurs.Kursnamn.Contains(sokord,
                        StringComparison.OrdinalIgnoreCase) ||
                    a.GetType().Name.Contains(sokord,
                        StringComparison.OrdinalIgnoreCase))
                .Select(a => new
                {
                    a.AnnonsID,
                    a.Titel,
                    a.Pris,
                    a.Skick,
                    Status = a.Status.ToString(),
                    Kurs = a.Kurs.Kursnamn,
                    Annonstyp = a.GetType().Name
                })
                .ToList();

            dgvAnnonser.DataSource = null;
            dgvAnnonser.DataSource = resultat;

            dgvAnnonser.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (resultat.Count == 0)
            {
                MessageBox.Show("Inga annonser hittades.");
            }
        }

        private void lblNyttPris_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrera_Click(object sender, EventArgs e)
        {
            string valdKurs = cmbFilterKurs.SelectedItem?.ToString() ?? "Alla kurser";
            string valdTyp = cmbFilterTyp.SelectedItem?.ToString() ?? "Alla typer";

            var annonser = _databas.Annonser.AsEnumerable();

            
            if (valdKurs != "Alla kurser")
            {
                annonser = annonser.Where(a =>
                    a.Kurs.Kursnamn == valdKurs);
            }

            
            if (valdTyp != "Alla typer")
            {
                annonser = annonser.Where(a =>
                    a.GetType().Name == valdTyp);
            }

            
            dgvAnnonser.DataSource = null;

            dgvAnnonser.DataSource = annonser
                .Select(a => new
                {
                    a.AnnonsID,
                    a.Titel,
                    a.Pris,
                    a.Skick,
                    Status = a.Status.ToString(),
                    Kurs = a.Kurs.Kursnamn,
                    Annonstyp = a.GetType().Name
                })
                .ToList();

            dgvAnnonser.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}           
