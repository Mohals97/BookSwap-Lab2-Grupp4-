using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DigitalResurs : Annons
    {
        public string Filformat { get; set; }
        public string Länk { get; set; }

        public DigitalResurs(int annonsID, string titel, decimal pris, string skick, Student säljare, Kurs kurs, string filformat, string länk)
            : base(annonsID, titel, pris, skick, säljare, kurs)
        {
            Filformat = filformat;
            Länk = länk;
        }
    }
}
