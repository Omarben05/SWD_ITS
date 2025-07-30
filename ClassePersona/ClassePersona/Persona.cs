using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassePersona
{
    internal class Persona
    {
        public string Cognome { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNascita { get; set;}
        public string LuogoNascita { get; set; } = string.Empty;
        public Sesso Sesso { get; set; }

        //overloading
        public Persona()
        {
        }
        public Persona(string cognome, string nome)
        {
            Cognome = cognome;
            Nome = nome;
        }

        public Persona(string cognome, string nome, DateTime dataNascita, string luogoNascita) : this(cognome, nome)
        {
            DataNascita = dataNascita;
            LuogoNascita = luogoNascita;
        }

        public Persona(string cognome, string nome, DateTime dataNascita, string luogoNascita, Sesso sesso) : this(cognome, nome, dataNascita, luogoNascita)
        {
            Sesso = sesso;
        }

        public int Eta()
        {
            int eta = DateTime.Now.Year-DataNascita.Year;
            //da raffinare

            return eta;
        }
        
        //metodo "consumer" - usa e getta
        private string Stampa(string separatore)
        {
            return $"{nameof(Cognome)}={Cognome}" +
                $"{separatore}{nameof(Nome)}={Nome}" +
                $"{separatore}{nameof(DataNascita)}={DataNascita.ToShortDateString()}" +
                $"{separatore}{nameof(LuogoNascita)}={LuogoNascita}" +
                $"{separatore}{nameof(Sesso)}={Sesso.ToString()}" +
                $"{separatore}Eta={Eta()}";
        }
        public string StampaLineare()
        {
            return Stampa(", ");
        }

        public string StampaDettaglio()
        {
            return Stampa("\n");
        }

        public override string ToString()
        {
            return $"{{{StampaLineare()}}}";
        }
    }
}
