/* Nome e Cognome: Omar Benagoub 
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C#
 * Classe: Persona
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione
{
    public abstract class Persona
    {
        // Proprietà: Nome, Cognome, Stipendio
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public decimal Stipendio { get; set; }

        public Persona(string nome, string cognome, decimal stipendio)
        {
            Nome = nome;
            Cognome = cognome;
            Stipendio = stipendio;
        }

        // Metodi : Tredicesima, ToString
        public abstract decimal Tredicesima();

        public override string ToString()
        {
            return $"{Nome} {Cognome}, Stipendio: {Stipendio} euro";
        }
    }
}
    
