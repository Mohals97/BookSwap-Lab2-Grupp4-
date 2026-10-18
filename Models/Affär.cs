using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Affär
    {
        public int AffärID { get; set; }
        public Annons Annons { get; set; }
        public Student Köpare { get; set; }
        public Student Säljare { get; set; }
        public DateTime Datum { get; set; }
        public AffärStatus Status { get; private set; }

        public Affär(int affärID, Annons annons, Student köpare, Student säljare)
        {
            AffärID = affärID;
            Annons = annons;
            Köpare = köpare;
            Säljare = säljare;
            Datum = DateTime.Now;
            Status = AffärStatus.Reserverad;
        }

        public void BekräftaKöp()
        {
            if (Status != AffärStatus.Reserverad)
            {
                throw new InvalidOperationException("Affären måste vara reserverad först.");
            }
            Annons.MarkeraSomSåld();
            Status = AffärStatus.Genomförd;
        }



    }
}
