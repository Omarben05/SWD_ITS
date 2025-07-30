using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioGUI
{
    internal class Commento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string Testo { get; set; } = string.Empty;

        public string Stampa()
        {
            return $"{Id} - {Data}: {Testo}";
        }

        public string StampaCSV()
        {
            return $"{Id};{Data};{Testo}";
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Data)}={Data.ToString()}, {nameof(Testo)}={Testo}}}";
        }
    }
}
