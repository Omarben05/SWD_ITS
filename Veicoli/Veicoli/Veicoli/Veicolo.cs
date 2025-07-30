using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    internal class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public Carburante Carburante { get; set; }
        public Colore Colore { get; set; }
        
        public override string ToString()
        {
            return $"{nameof(Marca)}={Marca}" +
                $", {nameof(Modello)}={Modello}" +
                $", {nameof(Cilindrata)}={Cilindrata.ToString()}" +
                $", {nameof(Carburante)}={Carburante.ToString()}" +
                $", {nameof(Colore)}={Colore}";
        }

        
    }
}
