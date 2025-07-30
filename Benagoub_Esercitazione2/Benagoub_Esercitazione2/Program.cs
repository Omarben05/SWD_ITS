/* Nome e Cognome: Omar Benagoub
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C# 
 * Classe: Program 
 */
namespace Benagoub_Esercitazione2
{
    class Program
    {
        static void Main(string[] args)
        {
            var studenti = Caricamenti.CaricaStudenti("studenti.csv");
            var libri = Caricamenti.CaricaLibri("libri.csv");
            var prestiti = Caricamenti.CaricaPrestiti("prestiti.csv");

            bool continua = true;
            while (continua)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Libri non ancora restituiti");
                Console.WriteLine("2. Prestiti archiviati (restituiti)");
                Console.WriteLine("3. Prestiti scaduti e non restituiti");
                Console.WriteLine("0. Esci");
                Console.Write("Scelta: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        int nonRestituiti = prestiti.Count(p => !p.Restituito);
                        Console.WriteLine($"Libri non restituiti: {nonRestituiti}");
                        break;

                    case "2":
                        foreach (var p in prestiti.Where(p => p.Restituito))
                            Caricamenti.StampaPrestito(p, studenti, libri);
                        break;

                    case "3":
                        foreach (var p in prestiti.Where(p => !p.Restituito && p.ÈScaduto))
                            Caricamenti.StampaPrestito(p, studenti, libri);
                        break;

                    case "0":
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
        }
    }
}
