using System;
using System.Security.Cryptography;
using System.Text;

namespace CyberSecurityHashing
{
    class Program
    {
        //TODO: Globale salt (voor de hele applicatie)
        

        // Lokale "database"
        static string opgeslagenGebruikersnaam = null;
        static string opgeslagenWachtwoordHash = null;

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nKies een optie:");
                Console.WriteLine("1 - Aanmelden");
                Console.WriteLine("2 - Inloggen");
                Console.WriteLine("3 - Stoppen");
                Console.Write("Keuze: ");

                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        RegistreerGebruiker();
                        break;

                    case "2":
                        LoginGebruiker();
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        break;
                }
            }

            Console.WriteLine("Programma beëindigd.");
        }

        // 3. Functie voor aanmelden
        static void RegistreerGebruiker()
        {
            //TODO: Vraag de gebruiker om gegevens


            //TODO: Hash het wachtwoord
            

            //TODO: Server check
            

            //TODO: Opslaan (lokaal)


            Console.WriteLine("Account succesvol aangemaakt.");
        }

        // 4. Functie voor inloggen
        static void LoginGebruiker()
        {
            // TODO: Controle of er een gebruiker bestaat


            //TODO: Vraag de gebruiker om gegevens

            //TODO: Hash opnieuw met dezelfde salt


            //TODO: Vergelijken
            
        }

        // 3a & 4c. Hash functie (SHA256)
        static string HashWachtwoord(string wachtwoord)
        {
            //TODO: schrijf de Hashing functie


            return "";
        }
    }
}