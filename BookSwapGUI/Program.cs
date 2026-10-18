
using Models;

namespace BookSwapGUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            InMemoryDatabase databas = new InMemoryDatabase();
            Testdata.Skapa(databas);

            while (true)
            {
                using (LoginFoem login = new LoginFoem(databas))
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }

                    
                    if (login.InloggadStudent != null)
                    {
                        using (Form1 huvudfonster =
                            new Form1(databas, login.InloggadStudent))
                        {
                            Application.Run(huvudfonster);

                            if (huvudfonster.DialogResult != DialogResult.Retry)
                            {
                                break;
                            }
                        }
                    }
                   
                    else if (login.InloggadAdmin != null)
                    {
                        using (AdminForm adminfonster =
                            new AdminForm(databas, login.InloggadAdmin))
                        {
                            Application.Run(adminfonster);

                            if (adminfonster.DialogResult != DialogResult.Retry)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
