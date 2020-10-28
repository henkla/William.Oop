using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using William.Oop.Library;

namespace William.Oop.GUI
{
    public partial class Form1 : Form
    {
        private ICollection<Competitor> _competitors;
        private Race _race;

        public Form1()
        {
            _competitors = GetCompetitors(8);
            _race = new Race(_competitors);

            InitializeComponent();

            foreach (var competitor in _competitors)
            {
                competitorsListBox.Items.Add(competitor.Name);
            }

            var result = _race.Run();
            label1.Text = label1.Text + result.GetWinner().Name;

        }

        private ICollection<Competitor> GetCompetitors(int numberOfCompetitors)
        {
            var list = new List<Competitor>();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var length = 10;

            while (list.Count < numberOfCompetitors)
            {
                list.Add(new Competitor(list.Count + 1, new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray())));
            }

            return list;
        }
    }
}
