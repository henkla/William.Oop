using System;
using System.Collections.Generic;

namespace William.Oop.Library
{
    public class Race
    {
        private IEnumerable<Competitor> _competitors;

        public Race(IEnumerable<Competitor> competitors)
        {
            _competitors = competitors;
        }

        public Result Run()
        {
            var result = new Result(_competitors);
            return result;
        }
    }
}