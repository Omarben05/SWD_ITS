/*
 * Dato in input il lato del quadrato,
 * calcolare perimetro area e diagonale
 * visualizzare i risultati
 */


Console.Write("Lato: ");
double lato= double.Parse(Console.ReadLine());


//Calcoli
double perimetro = lato * 4;
double area = lato * lato;
double diagonale = lato * Math.Sqrt(2);


//output

Console.WriteLine("Perimetro: " + perimetro); // stile Java
Console.WriteLine("Perimetro: {0}", area);  // stile segnaposto
Console.WriteLine($"Diagonale: { diagonale}"); //stile interpolazione