using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : Användare
    {
        public int StudentID { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Epost { get; set; }
        public string Telefonnummer { get; set; }

        public Student(int studentID, string förnamn, string efternamn, string epost, string telefonnummer, string användarnamn, string lösenord)
            : base(användarnamn, lösenord)
        {
            StudentID = studentID;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Epost = epost;
            Telefonnummer = telefonnummer;

        }
    }
}
