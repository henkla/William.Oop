using System;
using System.Collections.Generic;
using System.Linq;

namespace William.Oop.Library
{
    public class Result
    {
        private IEnumerable<Competitor> _competitors;
        private Random _random;
        public IDictionary<int, Competitor> Standings { get; private set; }

        public Result(IEnumerable<Competitor> competitors)
        {
            _random = new Random();
            _competitors = competitors;

            Standings = new Dictionary<int, Competitor>();

            ShuffleCompetitors();
            GetStandings();
        }

        private void ShuffleCompetitors()
        {
            var shuffledList = _competitors.Select(x => new { Number = _random.Next(), Item = x }).OrderBy(x => x.Number).Select(x => x.Item);
            _competitors = shuffledList;
        }

        private void GetStandings()
        {
            var racePosition = 1;

            _competitors.First().MakeWinner();

            foreach (var competitor in _competitors)
            {
                Standings.Add(racePosition++, competitor);
            }
        }

        public Competitor GetWinner()
        {
            var winner = Standings.First().Value;
            winner.MakeWinner();
            return winner;
        }
    }
}