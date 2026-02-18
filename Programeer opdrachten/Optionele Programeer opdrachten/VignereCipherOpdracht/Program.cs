using System;

class VigenereCipher
{
    static void Main()
    {
        Console.WriteLine("Vigenere Cipher");
        Console.WriteLine("Wil je encoden of decoden? (E/D)");

        string choice = Console.ReadLine().ToUpper();

        Console.WriteLine("Geef het sleutelwoord (minstens 5 letters):");
        string key = Console.ReadLine();

        // Controle op sleutel-lengte
        if (key.Length < 5)
        {
            Console.WriteLine("Sleutelwoord is te kort.");
            return;
        }

        Console.WriteLine("Geef het bericht:");
        string message = Console.ReadLine();

        string result = "";

        if (choice == "E")
        {
            // TODO:
            // Roep hier een methode aan die het bericht ENCODEERT met Vigenere
            // Tip: gebruik de letters van het sleutelwoord als shifts (Vergelijkbaar met Caesar)
        }
        else if (choice == "D")
        {
            // TODO:
            // Roep hier een methode aan die het bericht DECODEERT
            // Tip: Hoe verschilt encoden met decoden?
        }
        else
        {
            Console.WriteLine("Ongeldige keuze.");
            return;
        }

        Console.WriteLine("Resultaat:");
        Console.WriteLine(result);
    }

    // TODO:
    // Maak hier een methode VigenereEncode(string text, string key)
    // Hints:
    // - Gebruik een index voor het sleutelwoord
    // - Als je aan het einde van de sleutel bent, begin je weer bij 0
    // - Zet elke sleutelletter om naar een shift (A = 0, B = 1, etc.)
    // - Sla niet-letter tekens over (maar tel ze wel mee in de output)

    // TODO:
    // Maak hier ook een methode VigenereDecode(string text, string key)
    // Hint: kijk in het tekstbestand ;)

}