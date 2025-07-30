/* Nome e Cognome: Omar Benagoub
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C# 
 * Classe: Studente 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione2
{
    public class Studente
    {
        public string Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Classe { get; set; }

        public override string ToString()
        {
            return $"{Nome} {Cognome} ({Matricola}) - {Classe}";
        }
    }

}
