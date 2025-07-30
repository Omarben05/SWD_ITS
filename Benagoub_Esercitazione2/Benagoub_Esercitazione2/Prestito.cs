/* Nome e Cognome: Omar Benagoub
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C# 
 * Classe: Prestito 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione2
{
    public class Prestito
    {
        public int IdLibro { get; set; }                // codice del libro
        public string Matricola { get; set; }          // matricola/studente
        public DateTime DataPrestito { get; set; }
        public DateTime? DataRestituzione { get; set; } // può essere null

        public bool Restituito => DataRestituzione.HasValue;
        public int GiorniPrestito => (DataRestituzione ?? DateTime.Now).Subtract(DataPrestito).Days;
        public bool ÈScaduto
        {
            get
            {
                int durata = GiorniPrestito;
                if (Restituito)
                    return false;
                return durata > 30; // se supera il massimo previsto
            }
        }
    }

}
