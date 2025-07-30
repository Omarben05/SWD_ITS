/*
 * Dato in input il lato del cerchio,
 * calcolare diametro circonferenza e area
 * visualizzare i risultati
 */


Console.Write("Raggio: ");
double raggio = double.Parse(Console.ReadLine());


//Calcoli
double diametro = raggio * 2;
double area = raggio * raggio * Math.PI;
double circonferenza = 2*Math.PI*raggio;


//output nuova tecnica, stampa dettaglio
string msg = $"Diametro: {diametro}" +
    $"\nCirconferenza: {circonferenza}" +
    $"\nArea: {area}";

Console.WriteLine(msg);


//output nuova tecnica, stampa lineare
string msg2 = $"Diametro: {diametro}" +
    $", Circonferenza: {circonferenza}" +
    $", Area: {area}";

Console.WriteLine(msg2);