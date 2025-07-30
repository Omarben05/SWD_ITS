/*
 * Prezzo: 10,00
 * quantità: 3
 * Percentuale di sconto: 30
 * 
 * Totale: 30,00 euro
 * 
 * Scontoeffettuato: 9,00 euro
 * Totale scontato 21,00 euro
 */


Console.Write("Prezzo: ");
double prezzo= double.Parse(Console.ReadLine());

Console.Write("Quantità: ");
int quantita= int.Parse(Console.ReadLine());

Console.Write("Percentuale di sconto: ");
int percentualeSconto= int.Parse(Console.ReadLine());


double totale = (double)prezzo * quantita;


double scontoEffettuato = (double)totale * percentualeSconto / 100;


double totaleScontato = (double)totale - scontoEffettuato;


Console.WriteLine("\nTotale: {0} euro", totale);
Console.WriteLine("Sconto effettuato: {0} euro", scontoEffettuato);
Console.WriteLine("Totale scontato: {0} euro", totaleScontato);



