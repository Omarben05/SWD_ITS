/*
 * 
 * Dato in input l'imponibile,
 * calcolare il totale da pagare sapendo che l'aliquota iva è al 22%
 * visualizzare i risultati
 * 
 * 
Imponibile: 156,99

Iva (22%): ?? euro

Totale: ?? euro
 */




Console.Write("Imponibile: ");
double imponibile= double.Parse(Console.ReadLine());
Console.Write(" euro");

//Calcoli
int aliquotaIva = 22;
double iva = imponibile * aliquotaIva / 100;
double totale = imponibile * iva;


//usare il format - stampa dettagliata
string msg = $"\n\nImponibile: {imponibile:#.##} euro" +
    $"\nIva({aliquotaIva}%): {iva:#.##} euro" +
    $"\nTotale: {totale:#.##} euro";

Console.WriteLine(msg);




