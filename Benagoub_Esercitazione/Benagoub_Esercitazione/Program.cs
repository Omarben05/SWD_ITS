/* Nome e Cognome: Omar Benagoub 
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C#
 * Classe: Program
 */
namespace Benagoub_Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creazione venditore
            Venditore v1 = new Venditore("Omar", "Ben", 1300m, "Auto");

            // Creazione prodotto
            Prodotto p1 = new Prodotto("A001", "Batteria", "Batteria auto 12V", 120m);
            Prodotto p2 = new Prodotto("A002", "Filtro", "Filtro aria", 45m);

            // Creazione ordine
            Ordine ordine = new Ordine(v1);
            ordine.ElencoProdotti.Add(p1, 2);
            ordine.ElencoProdotti.Add(p2, 1);

            ordine.StampaOrdine();

            Console.WriteLine(ordine.ToString());
            Console.WriteLine($"Numero prodotti: {ordine.NumeroProdotti()}");
            Console.WriteLine($"Tredicesima venditore: {v1.Tredicesima()} euro " );
        }
    }
}