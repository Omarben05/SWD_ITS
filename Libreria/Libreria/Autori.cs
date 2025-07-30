using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Autori
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string? Email { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }
        public string NCognome { get
            {
                return Nome[0] + "." + Cognome;
            } }
    }
}
