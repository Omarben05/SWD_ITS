/* Nome e Cognome: Omar Benagoub
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C# 
 * Classe: Libro 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione2
{
    public class Libro
    {
        public int Codice { get; set; }
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public string Editore { get; set; }
        public int Anno { get; set; }
        public string Luogo { get; set; }
        public int Pagine { get; set; }
        public string Classificazione { get; set; }
        public string Collocazione { get; set; }
        public int Copie { get; set; }

        public override string ToString()
        {
            return $"\"{Titolo}\" di {Autore} ({Editore}, {Anno}) - Classificazione: {Classificazione}";
        }
    }
}
