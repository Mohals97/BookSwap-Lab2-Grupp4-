using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Services
{
     public class AnnonsServices
    {
        private readonly InMemoryDatabase _databas;
        public AnnonsServices(InMemoryDatabase databas)
        {
            _databas = databas;
        }

        public bool ReserveraAnnons(int studentID, int annonsID)
        {

            Annons? annons = _databas.HämtaAnnons(annonsID);

            if (annons == null)
                return false;

           

            if (annons.Säljare.StudentID == studentID)
                return false;

            Student? köpare = _databas.Studenter.FirstOrDefault(s => s.StudentID == studentID);

            if (köpare == null)
                return false;
            
            if (annons.Status != AnnonsStatus.TillSalu)
            { 
            return false;
            }
            
            int nyttAffärID = _databas.Affärer.Count == 0 ? 1 : _databas.Affärer.Max(a => a.AffärID) + 1;

            annons.Reservera();

            Affär affär = new Affär(nyttAffärID, annons, köpare, annons.Säljare);

            _databas.LäggTillAffär(affär);

            return true;
            
        }

        public bool BekräftaKöp(int studentID, int annonsID)
        {
            Annons? annons = _databas.HämtaAnnons(annonsID);

            if (annons == null)
                return false;

            if (annons.Status != AnnonsStatus.Reserverad)
                return false;

            Affär? affär = _databas.Affärer.FirstOrDefault(a => a.Annons.AnnonsID == annonsID && a.Köpare.StudentID == studentID);

            if (affär == null)
                return false;

            if (affär.Status != AffärStatus.Reserverad)
                return false;

            affär.BekräftaKöp();

            return true;

        }

        public bool TaBortAnnons(int studentID, int annonsID)
        { 
        Annons? annons = _databas.HämtaAnnons(annonsID);

            if(annons == null)
                return false;

            if ( annons.Säljare.StudentID != studentID)
                return false;

            if (annons.Status != AnnonsStatus.TillSalu)
                    return false;

            _databas.Annonser.Remove(annons);
            return true;
        }

        public bool RedigeraAnnons(int studentID, int annonsID, string nyTitel, decimal nyttPris)
        {
            Annons? annons = _databas.HämtaAnnons(annonsID);

            if (annons == null)
                return false;

            if (annons.Säljare.StudentID != studentID )
                return false;

            if(annons.Status != AnnonsStatus.TillSalu)
                return false;

            if(string.IsNullOrWhiteSpace(nyTitel) || nyttPris < 0)
                return false;

            annons.Titel = nyTitel;
            annons.Pris = nyttPris;

            return true;



        }

        public bool SkapaAnnons(int studentID, string titel, decimal pris,
        string skick, string annonsTyp, string kurskod)
        {
            Student? säljare = _databas.Studenter.FirstOrDefault(s => s.StudentID == studentID);

            if (säljare == null)
            {
                Debug.WriteLine("Fel: Studenten finns inte i databasen.");
                return false;

            }

            if (string.IsNullOrWhiteSpace(titel) || pris < 0 || string.IsNullOrWhiteSpace(skick))
            {
                Debug.WriteLine("Fel: Titel, pris eller skick är ogiltigt.");
                return false;
            }

            Kurs? kurs = _databas.Kurser.FirstOrDefault(k => k.Kurskod == kurskod);

            if (kurs == null)
            {
                Debug.WriteLine("Fel: Kursen hittades inte. Kurskod: " + kurskod);
                return false;
            }

            int nyttID = _databas.Annonser.Count == 0 ? 1 : _databas.Annonser.Max(a => a.AnnonsID) + 1;

            Annons nyAnnons ;

            switch (annonsTyp)
            {
                case "Kursbok":
                    nyAnnons = new Kursbok(nyttID, titel, pris, skick, säljare, kurs, "9780000000000", "Okänd författare", 2024);
                    break;
                
                case "Kompendium":
                    nyAnnons = new Kompendium(nyttID, titel, pris, skick, säljare, kurs, 100, "Kursmaterial");
                    break;

                case "DigitalResurs":
                    nyAnnons = new DigitalResurs(nyttID, titel, pris, skick, säljare, kurs, "PDF", "https://example.com/resource");
                    break;

                default:
                    Debug.WriteLine("Fel: Ogiltig annonstyp: " + annonsTyp);
                    return false;
            }

            _databas.Annonser.Add(nyAnnons);

            return true;



        }

    }
}
