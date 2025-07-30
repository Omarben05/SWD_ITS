using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Editore
    {
        public string ragionesociale { get; set; }
        internal class Indirizzo
        {
            public string? Via { get; set; }
            public string? Cap { get; set; }
            public string? Citta { get; set; }
            public string? Provincia { get; set; }
        }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Sitoweb { get; set; }
    }
}
