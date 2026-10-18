using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kurs
    {
        public string Kurskod { get; set; }
        public string Kursnamn { get; set; }
        public string Status { get; set; }

        public Kurs(string kurskod, string kursnamn)
        {
            Kurskod = kurskod;
            Kursnamn = kursnamn;
            Status = "Aktiv";
        }
    }
}
