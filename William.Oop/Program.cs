using System;
using System.Collections.Generic;
using William.Oop.Library;

namespace William.Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            // skapa tävlanden
            var competitors = GetSomeCompetitors();

            // skriv ut alla tävlanden
            Console.WriteLine("De tävlande är:");
            foreach (var competitor in competitors)
            {
                Console.WriteLine(competitor.Name);
            }

            // skapa ett race och lägg till de tävlande
            var race = new Race(competitors);

            // kör tävlingen och få resultat
            var result = race.Run();

            // visa vem som vann
            Console.WriteLine($"\nVinnaren är {result.GetWinner().Name} med startnummer {result.GetWinner().StartNumber}!");

            // visa resultatet för hela tävlingen
            Console.WriteLine("Resultatet för hela racet är:");
            foreach (var standing in result.Standings)
            {
                Console.WriteLine($"{standing.Key} -- {standing.Value.Name} [{standing.Value.StartNumber}]");
            }
        }

        private static List<Competitor> GetSomeCompetitors()
        {
            var competitors = new List<Competitor>();
            competitors.Add(new Competitor(1, "William"));
            competitors.Add(new Competitor(2, "Kenth"));
            competitors.Add(new Competitor(3, "Henrik"));
            competitors.Add(new Competitor(4, "Benny"));
            competitors.Add(new Competitor(5, "Kurth"));
            return competitors;
        }
    }
}
