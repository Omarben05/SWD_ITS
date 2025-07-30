/* Nome e Cognome: Omar Benagoub 
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C#
 * Classe: Meccanico
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione
{
    public class Meccanico : Persona
    {
        // Proprietà: Tipologia
        public string Tipologia { get; set; } // Carrozzeria o Meccanica

        public Meccanico(string nome, string cognome, decimal stipendio, string tipologia)
            : base(nome, cognome, stipendio)
        {
            Tipologia = tipologia;
        }

        // Metodi: Tredicesima
        public override decimal Tredicesima()
        {
            return Stipendio * 1.93m; // +93%
        }

        public override bool Equals(object obj)
        {
            if (obj is Meccanico altro)
            {
                return Nome == altro.Nome && Cognome == altro.Cognome && Tipologia == altro.Tipologia;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tipologia: {Tipologia}";
        }
    }
}
