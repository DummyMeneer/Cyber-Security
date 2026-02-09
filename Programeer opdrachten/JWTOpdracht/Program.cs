using System;
using System.Threading;

namespace JWTSimulatie
{
    class Program
    {
        // ===== "DATABASE" =====
        static string correcteGebruikersnaam = "admin";
        static string correcteWachtwoord = "password";

        // ===== JWT OPSLAG (lokaal) =====
        static string jwtToken = null;
        static DateTime jwtVerloopTijd;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Login ===");

            // 1. Inloggen
            Console.Write("Gebruikersnaam: ");
            string username = Console.ReadLine();

            Console.Write("Wachtwoord: ");
            string password = Console.ReadLine();

            // 2. Controle login
            // TODO: Controleer of gebruikersnaam en wachtwoord correct zijn
            // Indien fout: print foutmelding en stop programma

            // 3. JWT aanmaken
            // TODO: Maak een JWT (string)
            // TODO: Zet de verloopdatum op NU + 1 minuut
            // TODO: Sla token en verloopdatum lokaal op

            Console.WriteLine("\nLogin succesvol.");
            Console.WriteLine("JWT ontvangen door gebruiker.");

            // 4. Actie-loop
            bool actief = true;
            while (actief)
            {
                Console.WriteLine("\nKies een actie:");
                Console.WriteLine("1 - Doe actie");
                Console.WriteLine("2 - Stop");
                Console.Write("Keuze: ");

                string keuze = Console.ReadLine();

                

                if (keuze == "1")
                {

                    Console.WriteLine("Actie wordt uitgevoerd...");
                    // 4a. JWT controle bij iedere actie
                    // TODO: Controleer of JWT nog geldig is
                    // Indien ongeldig: print melding en stop applicatie

                    // Simuleer server verwerking
                    Thread.Sleep(2000);

                    Console.WriteLine("Actie voltooid.");
                }
                else if (keuze == "2")
                {
                    actief = false;
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze.");
                }
            }

            Console.WriteLine("\nApplicatie gestopt.");
        }

        // ===== HULPFUNCTIES (SKELETON) =====

        // TODO: Functie om JWT aan te maken
        // static string GenereerJWT(string gebruikersnaam)

        // TODO: Functie om JWT te controleren
        // static bool IsJWTGeldig()
    }
}