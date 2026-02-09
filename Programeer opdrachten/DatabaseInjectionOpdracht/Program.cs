using System;
using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace SQLInjectionDemo
{

    //Probeer dit in te voeren: 
    // Skyrim
    // ' OR 1=1 -- 
    // Zelda

    //TODO: verander de code zodat injections opgevangen worden

    class Program
    {
        static void Main(string[] args)
        {
            SQLitePCL.Batteries.Init();

            while (true) { 
                Console.WriteLine("=== Game Library ===");
                Console.Write("Zoek een game op titel: ");
                string userInput = Console.ReadLine();

                string connectionString = "Data Source=games.db;";

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string query =
                        "SELECT title, genre, year FROM games WHERE title = '" + userInput + "'";

                    using (var command = new SqliteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        bool gevonden = false;

                        while (reader.Read())
                        {
                            gevonden = true;
                            Console.WriteLine("\nGame gevonden:");
                            Console.WriteLine("Titel: " + reader["title"]);
                            Console.WriteLine("Genre: " + reader["genre"]);
                            Console.WriteLine("Jaar: " + reader["year"]);
                        }

                        if (!gevonden)
                            Console.WriteLine("\nGeen games gevonden.");
                    }
                }
            }
            Console.WriteLine("\nDruk op een toets om af te sluiten...");
            Console.ReadKey();
        }
    }
}


