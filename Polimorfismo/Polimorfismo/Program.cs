using System;                          // Libreria base per operazioni console
using System.Collections.Generic;      // Per usare le liste
using Polimorfismo;                    // Importa le classi definite nel namespace Polimorfismo (Dipendente, Amministrativo, ecc.)

class Program
{
    static void Main(string[] args)
    {
        // Crea una lista di dipendenti con diversi tipi (amministrativi, operai, specializzati)
        List<Dipendente> dipendenti = new List<Dipendente>
        {
            new Amministrativo("Rossi", "Mario", 20, 80, "contabile"),
            new Amministrativo("Bianchi", "Luca", 25, 90, "risorse umane"),
            new Amministrativo("Verdi", "Anna", 30, 100, "direttore"),
            new Operaio("Neri", "Paolo", 18, 100, "installatore"),
            new Operaio("Gialli", "Sara", 19, 110, "manutentore"),
            new OperaioSpecializzato("Blu", "Elena", 22, 120, "installatore", 3, 100),
            new OperaioSpecializzato("Viola", "Marco", 23, 115, "manutentore", 2, 120)
        };

        bool esci = false;    // Variabile per controllare se uscire dal programma

        // Ciclo del menu testuale
        while (!esci)
        {
            // Stampa il menu
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Elenco dipendenti");
            Console.WriteLine("2. Elenco amministrativi");
            Console.WriteLine("3. Elenco operai");
            Console.WriteLine("4. Elenco operai specializzati");
            Console.WriteLine("5. Operai con stipendio > 2000€");
            Console.WriteLine("6. Operai manutentori");
            Console.WriteLine("7. Scheda direttore amministrativo");
            Console.WriteLine("8. Esci");
            Console.Write("Scelta: ");

            string scelta = Console.ReadLine();  // Legge la scelta dell'utente
            Console.WriteLine();

            // Switch per eseguire l'azione scelta
            switch (scelta)
            {
                case "1":  // Tutti i dipendenti
                    foreach (var d in dipendenti)
                        Console.WriteLine(d);
                    break;

                case "2":  // Solo amministrativi
                    foreach (var d in dipendenti)
                        if (d is Amministrativo)
                            Console.WriteLine(d);
                    break;

                case "3":  // Solo operai (esclude gli specializzati)
                    foreach (var d in dipendenti)
                        if (d is Operaio && !(d is OperaioSpecializzato))
                            Console.WriteLine(d);
                    break;

                case "4":  // Solo operai specializzati
                    foreach (var d in dipendenti)
                        if (d is OperaioSpecializzato)
                            Console.WriteLine(d);
                    break;

                case "5":  // Operai con stipendio > 2000€
                    foreach (var d in dipendenti)
                        if (d is Operaio o && o.CalcolaStipendio() > 2000)
                            Console.WriteLine(d);
                    break;

                case "6":  // Operai manutentori
                    foreach (var d in dipendenti)
                        if (d is Operaio o && o.Tipo.ToLower() == "manutentore")
                            Console.WriteLine(d);
                    break;

                case "7":  // Scheda dettagliata del direttore
                    foreach (var d in dipendenti)
                        if (d is Amministrativo a && a.Mansione.ToLower() == "direttore")
                            Console.WriteLine($"Direttore: {a.Cognome} {a.Nome}\nPaga oraria: {a.PagaOraria}€\nOre lavorate: {a.OreLavorate}\nStipendio: {a.CalcolaStipendio():F2}€");
                    break;

                case "8":  // Uscita
                    esci = true;
                    break;

                default:    // Gestione scelta non valida
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}
