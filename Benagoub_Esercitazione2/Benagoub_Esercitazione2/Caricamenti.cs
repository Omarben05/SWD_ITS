/* Nome e Cognome: Omar Benagoub
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C# 
 * Classe: Caricamenti 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Benagoub_Esercitazione2
{

    public static class Caricamenti
    {
       
        public static List<Studente> CaricaStudenti(string path)
        {
            var lista = new List<Studente>();
            foreach (var riga in File.ReadAllLines(path).Skip(1))
            {
                var campi = riga.Split(';');
                lista.Add(new Studente
                {
                    Matricola = campi[0],
                    Nome = campi[1],
                    Cognome = campi[2],
                    Email = campi[3],
                    Classe = campi[4]
                });
            }
            return lista;
        }

        public static List<Libro> CaricaLibri(string path)
        {
            var lista = new List<Libro>();
            foreach (var riga in File.ReadAllLines(path).Skip(1))
            {
                var campi = riga.Split(';');
                lista.Add(new Libro
                {
                    Codice = int.Parse(campi[0]),
                    Autore = campi[1],
                    Titolo = campi[2],
                    Editore = campi[3],
                    Anno = int.TryParse(campi[4], out var anno) ? anno : 0, // Default to 0 or another fallback value
                    Luogo = campi[5],
                    Pagine = int.Parse(campi[6]),
                    Classificazione = campi[7],
                    Collocazione = campi[8],
                    Copie = int.Parse(campi[9])
                });
            }
            return lista;
        }

        public static List<Prestito> CaricaPrestiti(string path)
        {
            var lista = new List<Prestito>();
            foreach (var riga in File.ReadAllLines(path).Skip(1))
            {
                var campi = riga.Split(';');
                DateTime? dataRestituzione = string.IsNullOrWhiteSpace(campi[3]) || campi[3].ToUpper() == "NULL"
                    ? (DateTime?)null
                    : DateTime.Parse(campi[3]);

                lista.Add(new Prestito
                {
                    IdLibro = int.Parse(campi[0]),
                    Matricola = campi[1],
                    DataPrestito = DateTime.Parse(campi[2]),
                    DataRestituzione = dataRestituzione
                });
            }
            return lista;
        }


        public static void StampaPrestito(Prestito p, List<Studente> studenti, List<Libro> libri)
        {
            var studente = studenti.FirstOrDefault(s => s.Matricola == p.Matricola);
            var libro = libri.FirstOrDefault(l => l.Codice == p.IdLibro);

            Console.WriteLine($"\n{studente?.ToString()} ha preso in prestito {libro?.ToString()} il {p.DataPrestito:dd/MM/yyyy} - Restituito: {p.Restituito}");
        }
    }
}
