
using Models;
using System.Globalization;

namespace BookSwapGUI
{
    public static class Testdata
    {
        public static void Skapa(InMemoryDatabase databas)
        {
            Student mohammed = new Student( 1, "Mohammed", "ALsadi","moha@student.com", "0701234567", "moa123", "test123");

            Student jamie = new Student(2, "Jamie", "Svensson", "jamie@student.com", "0709876543", "jamie123", "test123");

            databas.Studenter.Add(mohammed);
            databas.Studenter.Add(jamie);

            Administratör admin = new Administratör(1, "BookSwap Admin", "admin@bookswap.se", "admin", "admin123");
            databas.Administratörer.Add(admin);

            Kurs databasteknik = new Kurs(
                "NDA01G", "Databasteknik");

            databas.Kurser.Add(databasteknik);

            databas.Kurser.Add(
                new Kurs("PRG01G", "Programmering i C#"));

            databas.Kurser.Add(
                new Kurs("SYS01G", "Systemutveckling"));

            databas.Kurser.Add(
                new Kurs("MAR01G", "Marknadsföring"));

            databas.Annonser.Add(new Kursbok(
                1, "Databasteknik – kursbok",
                250m, "Bra skick", mohammed, databasteknik,
                "9781234567890", "Anna Svensson", 2024));

            databas.Annonser.Add(new Kompendium(
                2, "SQL-övningar",
                120m, "Bra skick", mohammed, databasteknik,
                85, "Övningar inom SQL"));

            databas.Annonser.Add(new Kursbok(
                3, "Introduktion till SQL",
                180m, "Mycket bra skick", jamie, databasteknik,
                "9781234567891", "Erik Andersson", 2023));
        }
    }
}
