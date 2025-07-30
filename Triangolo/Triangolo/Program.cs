//Dati i lati di un triangolo
//calcolare perimetro, area e il tipo (equilatero, isoscele, scaleno)
//Visualizzare i risultati


Console.WriteLine("lato1: ");
double lato1= double.Parse(Console.ReadLine());

Console.WriteLine("lato2: ");
double lato2 = double.Parse(Console.ReadLine());

Console.WriteLine("lato3: ");
double lato3 = double.Parse(Console.ReadLine());



if (lato1 + lato2 > lato3 && lato2 + lato3 > lato1 && lato3 + lato1 > lato2)
{
    double perimetro = lato1 + lato2 + lato3;
    //formula di erone
    double sp = perimetro / 2; //semiperimetro
    double area = Math.Sqrt(sp * (sp - lato1) * (sp - lato2) * (sp - lato3));



    string tipo = "scaleno";
    if (lato1 == lato2 && lato1 == lato3)   //&&  = and
        tipo = "Equilatero";
    else if (lato1 == lato2 || lato1 == lato3 || lato2 == lato3)   // || = or
        tipo = "Isoscele";

    //     ! = not

    //output
    //format lineare
    string msg = $"Perimetro: {perimetro}, Area: {area}, tipo: {tipo}";

    Console.WriteLine(msg);
}
else
    Console.WriteLine("Con i lati inseriti non è possibile costruire un triangolo ");

