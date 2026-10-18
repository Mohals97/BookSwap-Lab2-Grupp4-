using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kompendium : Annons
    {
        public int AntalSidor { get; set; }
        public string Beskrivning { get; set; }

        public Kompendium(int annonsID, string titel, decimal pris, string skick, Student säljare, Kurs kurs, int antalSidor, string beskrivning)
            : base(annonsID, titel, pris, skick, säljare, kurs)
        {
            AntalSidor = antalSidor;
            Beskrivning = beskrivning;
        }
    }
}
