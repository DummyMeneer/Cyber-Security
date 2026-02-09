using System;
using System.Collections.Generic;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een wachtwoord in:");
            string password = Console.ReadLine();

            List<string> fouten = new List<string>();

            // ===== CONTROLES =====

            // TODO 1: Controleer lengte van het wachtwoord
            // Indien te kort: voeg een foutmelding toe aan de lijst "fouten"

            // TODO 2: Controleer gebruikte tekens
            // Alleen cijfers? Alleen letters? Of combinatie?
            // Voeg indien nodig een foutmelding toe

            // TODO 3: Controleer of er minimaal één hoofdletter aanwezig is
            // Zo niet: foutmelding toevoegen

            // TODO 4: Controleer of het wachtwoord vaak gebruikt wordt
            // Gebruik een lijst met zwakke wachtwoorden
            // Indien gevonden: foutmelding toevoegen

            // ===== RESULTAAT =====

            if (fouten.Count > 0)
            {
                Console.WriteLine("\nWachtwoord is ONVEILIG:");
                foreach (string fout in fouten)
                {
                    Console.WriteLine("- " + fout);
                }
            }
            else
            {
                Console.WriteLine("\nWachtwoord is GOED.");
            }

            Console.WriteLine("\nDruk op een toets om af te sluiten...");
            Console.ReadKey();
        }

        // ===== HULPFUNCTIES (OPTIONEEL) =====

        // TODO: Functie voor lengtecontrole
        // static bool IsLengteCorrect(string password)

        // TODO: Functie voor tekencontrole
        // static bool BevatGoedeTekens(string password)

        // TODO: Functie voor hoofdlettercontrole
        // static bool BevatHoofdletter(string password)

        // TODO: Functie voor controle op veelgebruikte wachtwoorden
        // static bool IsVeelGebruiktWachtwoord(string password)
    }
}