/* Nome e Cognome: Omar Benagoub 
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C#
 * Classe: Ordine
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione
{
    public sealed class Ordine
    {
        public string CodiceOrdine { get; private set; }
        public DateTime Data { get; set; }
        public Dictionary<Prodotto, int> ElencoProdotti { get; set; }
        public Venditore Venditore { get; set; }

        public Ordine(Venditore venditore)
        {
            CodiceOrdine = GeneraCodice();
            Data = DateTime.Now;
            ElencoProdotti = new Dictionary<Prodotto, int>();
            Venditore = venditore;
        }
        // Metodo che genera un codice univoco di 8 caratteri
        private string GeneraCodice()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        }

        // Calcola la quantità totale dei prodotti ordinati
        public int NumeroProdotti()
        {
            int totale = 0;
            foreach (var p in ElencoProdotti.Values)
                totale += p;
            return totale;
        }

        // Calcola il prezzo totale dell'ordine
        public decimal Totale()
        {
            decimal totale = 0;
            foreach (var item in ElencoProdotti)
            {
                totale += item.Key.Prezzo * item.Value;
            }
            return totale;
        }

        // Metodo per stampare l'ordine in un file .txt
        public void StampaOrdine()
        {
            string path = Path.Combine("file", $"{CodiceOrdine}.txt");
            Directory.CreateDirectory("file");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ordine: {CodiceOrdine} - Data: {Data}");
            sb.AppendLine($"Venditore: {Venditore.Nome} {Venditore.Cognome}");
            sb.AppendLine("\nProdotti:");
            sb.AppendLine("Codice\tNome\tQuantità\tPrezzo\tSubtotale");

            foreach (var kvp in ElencoProdotti)
            {
                var p = kvp.Key;
                int quantita = kvp.Value;
                decimal subtotale = p.Prezzo * quantita;

                sb.AppendLine($"{p.Codice}\t{p.Nome}\t{quantita}\t{p.Prezzo:C}\t{subtotale:C}");
            }

            sb.AppendLine($"\nTotale ordine: {Totale():C}");

            File.WriteAllText(path, sb.ToString());
        }

        public override string ToString()
        {
            return $"Ordine: {CodiceOrdine}, Data: {Data}, Venditore: {Venditore.Nome} {Venditore.Cognome}, Totale: {Totale()} euro";
        }
    }
}
