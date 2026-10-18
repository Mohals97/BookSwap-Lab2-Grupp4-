
using Models;
using System.Linq;

namespace Services
{
    public class InloggningService
    {
        private readonly InMemoryDatabase _databas;

        public InloggningService(InMemoryDatabase databas)
        {
            _databas = databas;
        }

        public Student? LoggaIn(string epost, string lösenord)
        {
            Student? student = _databas.Studenter
                .FirstOrDefault(s =>
                    s.Epost == epost &&
                    s.Lösenord == lösenord);

            return student;
        }

        public Administratör? LoggaInAdmin(string epost, string lösenord)
        { 
        Administratör? admin = _databas.Administratörer.FirstOrDefault(a =>
                    a.Epost == epost &&
                    a.Lösenord == lösenord);
            return admin;
        }
    }
}
