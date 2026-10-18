using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Administratör: Användare
    {
        public int AdminID { get; set; }
        public string Namn { get; set; }
        public string Epost { get; set; }

        public Administratör(int adminID, string namn, string epost, string användarnamn, string lösenord)
            : base(användarnamn, lösenord)
        { 
        AdminID = adminID;
            Namn = namn;
            Epost = epost;
        }

    }
}
