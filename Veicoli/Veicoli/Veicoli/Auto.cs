using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    internal class Auto:Veicolo
    {
        public int NumeroPorte { get; set; }
        public TipoCambio Cambio { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                $", {nameof(NumeroPorte)}={NumeroPorte.ToString()}" +
                $",{nameof(TipoCambio)}={Cambio.ToString()}";
        }
    }
}
