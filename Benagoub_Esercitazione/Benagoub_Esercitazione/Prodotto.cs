/* Nome e Cognome: Omar Benagoub 
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C#
 * Classe: Prodotto
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione
{
    public class Prodotto
    {
        public string Codice { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }

        public Prodotto(string codice, string nome, string descrizione, decimal prezzo)
        {
            Codice = codice;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }

        public override string ToString()
        {
            return $"{Codice} - {Nome}: {Descrizione} ({Prezzo})";
        }
    }

}
