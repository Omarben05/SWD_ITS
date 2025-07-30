/*
 Lanciare un dado a 6 facce n volte,
calcolare la frequenza delle uscite 
visualizzare i risultati 
 */

Console.Write("Quante volte vuoi lanciare il dado? ");
int n = int.Parse(Console.ReadLine());

Random random = new Random();

//for (int i = 0; i < n; i++)
//{
    //Console.WriteLine(random.Next(6) + 1);
//}


//contare quante volte esce un numero
int conta1 = 0, conta2 = 0, conta3 = 0, conta4 = 0, conta5 = 0, conta6 = 0;
for (int i = 0; i <n; i++)
{
    switch (random.Next(6) + 1)
    {
        case 1: conta1++; break;
            case 2: conta2++; break;
            case 3: conta3++; break;
            case 4: conta4++; break;
            case 5: conta5++; break;
            case 6: conta6++; break;
            default: Console.WriteLine("Errore"); break;
    }
}

Console.WriteLine($"il numero 1 è uscito: {conta1} volte; frequenza: {((double)conta1/n)*100}%");
Console.WriteLine($"il numero 2 è uscito: {conta2} volte; frequenza: {((double)conta2 / n) * 100}%");
Console.WriteLine($"il numero 3 è uscito: {conta3} volte; frequenza: {((double)conta3 / n) * 100}%");
Console.WriteLine($"il numero 4 è uscito: {conta4} volte; frequenza: {((double)conta4 / n) * 100}%");
Console.WriteLine($"il numero 5 è uscito: {conta5} volte; frequenza: {((double)conta5 / n) * 100}%");
Console.WriteLine($"il numero 6 è uscito: {conta6} volte; frequenza: {((double)conta6 / n) * 100}%");