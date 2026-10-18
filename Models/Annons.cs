using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Annons
    {
        public int AnnonsID { get; set; }
        public string Titel { get; set; }
        public decimal Pris { get; set; }
        public string Skick { get; set; }
        public DateTime Publiceringsdatum { get; set; }
        public AnnonsStatus Status { get; set; }

        public Student Säljare { get; set; }
        public Kurs Kurs { get; set; }

        protected Annons(int annonsID, string titel, decimal pris, string skick, Student säljare, Kurs kurs)
        {
            AnnonsID = annonsID;
            Titel= titel;
            Pris = pris;
            Skick = skick;
            Säljare = säljare;
            this.Kurs = kurs;
            Publiceringsdatum = DateTime.Now;
            Status = AnnonsStatus.TillSalu;


        }
        public void Reservera()
        {
            if (Status != AnnonsStatus.TillSalu)
            {
                throw new InvalidOperationException("Annonsen är inte tillgänglig för reservation");
            }
            Status = AnnonsStatus.Reserverad;
        }
        public void MarkeraSomSåld()
        {
            if (Status != AnnonsStatus.Reserverad)
            {
                throw new InvalidOperationException("Annonsen måste vara reserverad först.");
            }
            Status = AnnonsStatus.Såld;
        }
    }
}
