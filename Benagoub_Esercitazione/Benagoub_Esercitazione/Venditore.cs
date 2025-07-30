/* Nome e Cognome: Omar Benagoub 
 * Data: 30-06-2025
 * Corso: SWD 
 * Materia: Programmazione - C#
 * Classe: Venditori
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione
{
    public class Venditore : Persona
    {
        public string Settore { get; set; }

        public Venditore(string nome, string cognome, decimal stipendio, string settore)
            : base(nome, cognome, stipendio)
        {
            Settore = settore;
        }

        public override decimal Tredicesima()
        {
            return Stipendio * 1.91m;
        }

        public Venditore Clone()
        {
            return new Venditore(Nome, Cognome, Stipendio, Settore);
        }

        public override string ToString()
        {
            return base.ToString() + $", Settore: {Settore}";
        }
    }
}
