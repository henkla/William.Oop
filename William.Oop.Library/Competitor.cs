using System.Runtime.CompilerServices;

namespace William.Oop.Library
{
    public class Competitor
    {
        public string Name { get; private set; }
        public int StartNumber { get; private set; }
        public bool IsWinner { get; private set; }

        public Competitor(int number, string name)
        {
            StartNumber = number;
            Name = name;
            IsWinner = false;
        }

        public void MakeWinner()
        {
            IsWinner = true;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}