//Dato il costo di una prestazione
//calcolare la rivalsa pari al 4% del costo
//calcolare l'imponibile dato dal costo più la rivalsa,
//calcolare il totale lordo da pagare sapendo che l'aliquota iva è al 22%
//la ritenuta d'acconto (20% dell'imponibile)
//totale netto dato dal totale lordo meno la ritenuta d'acconto
//Visualizzare i risultati

/*
Costo 1000,00 euro

Rivalsa (4% del costo): 40,00 euro

Imponibile: 1040,00 euro

Iva (22%): 220,00 euro

Totale lordo: 1220,00 euro

Ritenuta d'acconto (20%): 200,00 euro

Totale netto: 1020,00 euro

 */

Console.Write("Costo: ");
double costo = double.Parse(Console.ReadLine());

//calcoli
const int rivalsaPercentuale = 4;
const int aliquotaIva = 22;
const int ritenutaAcconto = 20;

double rivalsa = costo * rivalsaPercentuale / 100;
double imponibile = costo + rivalsa;
double iva = imponibile * aliquotaIva / 100;
double totaleLordo = imponibile + iva;
double ritenuta = totaleLordo * ritenutaAcconto / 100;
double totaleNetto = totaleLordo - ritenuta;

//usare il format - stampa dettaglio
string msg = $"\n\nCosto: {costo:#.##} euro" +
    $"\nRivalsa ({rivalsaPercentuale}% del costo): {rivalsa:#.##} euro" +
    $"\nImponibile: {imponibile:#.##} euro" +
    $"\nIva ({aliquotaIva}%): {iva:#.##} euro" +
    $"\nTotale Lordo: {totaleLordo:#.##} euro" +
    $"\nRitenuta d'acconto ({ritenutaAcconto}% dell'imponibile): {ritenuta:#.##} euro" +
    $"\nTotale Netto: {totaleNetto:#.##} euro"
    ;

Console.WriteLine(msg);
