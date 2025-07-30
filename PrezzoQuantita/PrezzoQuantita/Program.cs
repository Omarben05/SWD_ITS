/*
chiedere Prezzo: (10.25) es
chiedere Quantità: (3) es

restituisce Totale: (30.75 euro) es

 */

Console.Write("Prezzo: ");
double prezzo= double.Parse(Console.ReadLine());

Console.Write("Quantità: ");
int quantita= int.Parse(Console.ReadLine());

double totale = (double) prezzo * quantita;

Console.WriteLine("Totale: {0} euro " + totale);
