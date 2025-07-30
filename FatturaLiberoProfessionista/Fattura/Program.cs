/*
 * 
 * Dato in input l'imponibile,
 * calcolare il totale lordo da pagare sapendo che l'aliquota iva è al 22%
 * la ritenuta d'acconto (20% dell'imponibile)
 * totale netto dato dal totale lordo meno la ritenuta d'acconto
 * visualizzare i risultati
 
Imponibile: 1000,00 euro

Iva (22%): 220,00 euro

Totale lordo: 1220,00 euro

Ritenuta d'acconto (20%): 200,00 euro

Totale netto: 1020,00 euro

 */




Console.Write("Imponibile: ");
double imponibile = double.Parse(Console.ReadLine());


//Calcoli
const int aliquotaIva = 22;
const int ritenuaAcconto= 20;
double iva = imponibile * aliquotaIva / 100;
double totaleLordo = imponibile * iva;
double ritenuta = totaleLordo * ritenuaAcconto / 100;
double totaleNetto = totaleLordo - ritenuta;


//usare il format - stampa dettagliata
string msg = $"\n\nImponibile: {imponibile:#.##} euro" +
    $"\nIva({aliquotaIva}%): {iva:#.##} euro" +
    $"\nTotale: {totaleLordo:#.##} euro" +
    $"\nRitenuta d'acconto ({ritenuaAcconto}% dell'imponibile): {ritenuta:#.##" +
    $"\nTotale Netto:{totaleNetto:#.##}";

Console.WriteLine(msg);

