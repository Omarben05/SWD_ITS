using System;                        // Importa funzionalità di base (console, ecc.)
using System.Collections.Generic;    // Importa strutture dati come liste

namespace Polimorfismo               // Definisce uno spazio dei nomi per organizzare il codice
{
    // Classe base che rappresenta un dipendente generico
    public class Dipendente
    {
        public string Cognome { get; set; }          // Cognome del dipendente
        public string Nome { get; set; }             // Nome del dipendente
        public double PagaOraria { get; set; }       // Compenso per ogni ora lavorata
        public int OreLavorate { get; set; }         // Totale ore lavorate

        // Costruttore che inizializza i dati del dipendente
        public Dipendente(string cognome, string nome, double pagaOraria, int oreLavorate)
        {
            Cognome = cognome;
            Nome = nome;
            PagaOraria = pagaOraria;
            OreLavorate = oreLavorate;
        }

        // Metodo virtuale per calcolare lo stipendio base (paga oraria * ore lavorate)
        public virtual double CalcolaStipendio()
        {
            return PagaOraria * OreLavorate;
        }

        // Override del metodo ToString per stampare le info principali del dipendente
        public override string ToString()
        {
            return $"{Cognome} {Nome} - Stipendio: {CalcolaStipendio():F2} €";
        }
    }

    // Classe derivata per i dipendenti amministrativi
    public class Amministrativo : Dipendente
    {
        public string Mansione { get; set; }     // Mansione: contabile, risorse umane, direttore

        // Costruttore che chiama il costruttore base e inizializza la mansione
        public Amministrativo(string cognome, string nome, double pagaOraria, int oreLavorate, string mansione)
            : base(cognome, nome, pagaOraria, oreLavorate)
        {
            Mansione = mansione;
        }

        // Calcola lo stipendio base + bonus in base alla mansione
        public override double CalcolaStipendio()
        {
            double baseStipendio = base.CalcolaStipendio();  // Stipendio base
            double bonus = 0;
            switch (Mansione.ToLower())                      // Confronto ignorando maiuscole/minuscole
            {
                case "contabile": bonus = 150; break;
                case "risorse umane": bonus = 75; break;
                case "direttore": bonus = 250; break;
            }
            return baseStipendio + bonus;                    // Totale stipendio con bonus
        }

        // Aggiunge info sulla mansione alla stringa stampata
        public override string ToString()
        {
            return base.ToString() + $" - Mansione: {Mansione}";
        }
    }

    // Classe derivata per gli operai
    public class Operaio : Dipendente
    {
        public string Tipo { get; set; }    // Tipo: installatore o manutentore

        // Costruttore che chiama il costruttore base e inizializza il tipo
        public Operaio(string cognome, string nome, double pagaOraria, int oreLavorate, string tipo)
            : base(cognome, nome, pagaOraria, oreLavorate)
        {
            Tipo = tipo;
        }

        // Calcola lo stipendio base + bonus in base al tipo di operaio
        public override double CalcolaStipendio()
        {
            double baseStipendio = base.CalcolaStipendio();
            double bonus = 0;
            switch (Tipo.ToLower())
            {
                case "installatore": bonus = 185; break;
                case "manutentore": bonus = 230; break;
            }
            return baseStipendio + bonus;
        }

        // Aggiunge info sul tipo di operaio alla stringa stampata
        public override string ToString()
        {
            return base.ToString() + $" - Tipo: {Tipo}";
        }
    }

    // Classe derivata per gli operai specializzati
    public class OperaioSpecializzato : Operaio
    {
        public int NumeroMissioni { get; set; }           // Quante missioni ha fatto
        public double IndennitaPerMissione { get; set; }  // Quanto prende per ogni missione

        // Costruttore che chiama quello della classe Operaio e inizializza le nuove proprietà
        public OperaioSpecializzato(string cognome, string nome, double pagaOraria, int oreLavorate, string tipo, int numeroMissioni, double indennitaPerMissione)
            : base(cognome, nome, pagaOraria, oreLavorate, tipo)
        {
            NumeroMissioni = numeroMissioni;
            IndennitaPerMissione = indennitaPerMissione;
        }

        // Calcola lo stipendio base + bonus + indennità per missioni
        public override double CalcolaStipendio()
        {
            return base.CalcolaStipendio() + (NumeroMissioni * IndennitaPerMissione);
        }

        // Aggiunge info sulle missioni alla stringa stampata
        public override string ToString()
        {
            return base.ToString() + $" - Missioni: {NumeroMissioni} (Indennità: {IndennitaPerMissione} € ciascuna)";
        }
    }
}
