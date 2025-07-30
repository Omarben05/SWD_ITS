/*
 Dato in  input un numero intero,
stabilire se pari o dispari.

Visualizzare il risultato
 */

Console.Write("Inserisci un numero intero: ");
int n = int.Parse(Console.ReadLine());


// OPERATORI DI CONFRONTO: <, <=, >, >=, ==, != 
// VALORI DI BOOLE: false, true 

if (n%2== 0)
    Console.WriteLine($"{n} è pari");
else
    Console.WriteLine($"{n} è dispari");