using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Användare
    {
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }

        protected Användare(string användaenamn, string lösenord)
        {
            Användarnamn = användaenamn;
            Lösenord = lösenord;
        }
    }
}
