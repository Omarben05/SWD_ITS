using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    internal class Scooter:Veicolo
    {
        public int NumeroRuote { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                $", {nameof(NumeroRuote)}={NumeroRuote.ToString()}";
        }
    }
}
