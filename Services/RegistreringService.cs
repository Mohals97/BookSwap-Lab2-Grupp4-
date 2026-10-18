
using Models;
using System;
using System.Linq;

namespace Services
{
    public class RegistreringService
    {
        private readonly InMemoryDatabase _databas;

        public RegistreringService(InMemoryDatabase databas)
        {
            _databas = databas;
        }

        public bool RegistreraStudent(
            string förnamn,
            string efternamn,
            string epost,
            string telefonnummer,
            string användarnamn,
            string lösenord)
        {
            if (string.IsNullOrWhiteSpace(förnamn) ||
                string.IsNullOrWhiteSpace(efternamn) ||
                string.IsNullOrWhiteSpace(epost) ||
                string.IsNullOrWhiteSpace(användarnamn) ||
                string.IsNullOrWhiteSpace(lösenord))
            {
                return false;
            }

            // Kontrollera om e-post eller användarnamn redan finns
            bool finnsRedan = _databas.Studenter.Any(s =>
                s.Epost.Equals(epost, StringComparison.OrdinalIgnoreCase) ||
                s.Användarnamn.Equals(användarnamn, StringComparison.OrdinalIgnoreCase));

            if (finnsRedan)
                return false;

            int nyttID = _databas.Studenter.Count == 0
                ? 1
                : _databas.Studenter.Max(s => s.StudentID) + 1;

            Student nyStudent = new Student(
                nyttID,
                förnamn,
                efternamn,
                epost,
                telefonnummer,
                användarnamn,
                lösenord);

            _databas.Studenter.Add(nyStudent);

            return true;
        }
    }
}
