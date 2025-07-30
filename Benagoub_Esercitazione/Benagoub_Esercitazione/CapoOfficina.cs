/* Nome e Cognome: Omar Benagoub 
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C#
 * Classe: CapoOfficina
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione
{

    public class CapoOfficina : Meccanico
    {
        public List<Ordine> OrdiniGestiti { get; set; }

        public CapoOfficina(string nome, string cognome, decimal stipendio, string tipologia)
            : base(nome, cognome, stipendio, tipologia)
        {
            OrdiniGestiti = new List<Ordine>();
        }

        public override decimal Tredicesima()
        {
            decimal importoTotale = 0;
            foreach (var ordine in OrdiniGestiti)
            {
                importoTotale += ordine.Totale();
            }

            return (Stipendio * 2) + (importoTotale * 0.05m);
        }

        public override string ToString()
        {
            return base.ToString() + $", Ordini gestiti: {OrdiniGestiti.Count}";
        }
    }
}
