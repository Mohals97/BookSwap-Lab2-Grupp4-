using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class InMemoryDatabase
    {
        public List<Student> Studenter { get; set; } = new List<Student>();
        public List<Administratör> Administratörer { get; set; } = new List<Administratör>();
        public List<Kurs> Kurser { get; set; } = new List<Kurs>();
        public List<Annons> Annonser { get; set; } = new List<Annons>();
        public List<Affär> Affärer { get; } = new List<Affär>();

        public Annons? HämtaAnnons(int annonsID)
        {
            return Annonser.FirstOrDefault(a => a.AnnonsID == annonsID);
        }
        public void LäggTillAffär(Affär affär)
        {
            Affärer.Add(affär);
        }

    }
}
