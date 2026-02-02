using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Caesar Cipher");
        Console.WriteLine("Wil je encoden of decoden? (E/D)");

        string choice = Console.ReadLine().ToUpper();

        Console.WriteLine("Geef de shift (bijvoorbeeld 3):");
        int shift = int.Parse(Console.ReadLine());

        Console.WriteLine("Geef het bericht:");
        string message = Console.ReadLine();

        string result = "";

        if (choice == "E")
        {
            // TODO:
            // Roep hier een methode aan die het bericht ENCODEERT
            // Gebruik de shift om elke letter te verplaatsen
            // Tip: werk met char en ASCII-waardes
        }
        else if (choice == "D")
        {
            // TODO:
            // Roep hier een methode aan die het bericht DECODEERT
            // Tip: Wat is het verschil tussen Encode en Decode qua shift?
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
    // Maak hier een methode Encode(string text, int shift)
    // Loop door elke letter in de tekst
    // - Controleer of het een letter is
    // - Verschuif de letter binnen het alfabet
    // - Zorg dat je binnen A-Z of a-z blijft
    // - Voeg het resultaat toe aan een nieuwe string

    // TODO:
    // Maak hier een methode Decode(string text, int shift)
    // Loop door elke letter in de tekst
    // - Controleer of het een letter is
    // - Verschuif de letter terug binnen het alfabet
    // - Zorg dat je binnen A-Z of a-z blijft
    // - Voeg het resultaat toe aan een nieuwe string

    
}