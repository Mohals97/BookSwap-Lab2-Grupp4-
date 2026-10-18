using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kursbok : Annons
    {
        public string ISBN { get; set; }
        public string Författare { get; set; }
            public int Utgivningsår { get; set; }

        public Kursbok(int annonsID, string titel, decimal pris, string skick, Student säljare, Kurs kurs, string isbn, string författare, int utgivningsår)
            : base(annonsID, titel, pris, skick, säljare, kurs)
        {
            ISBN = isbn;
            Författare = författare;
            Utgivningsår = utgivningsår;

        }
    }
}
