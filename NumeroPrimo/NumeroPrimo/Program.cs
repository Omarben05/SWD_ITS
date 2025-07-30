/*
 Dato in input un numero intero positivo e maggiore di 1
verificare se è un numero primo

Visualizzare il risultato

es. 5 => primo
6 => non è primo

-9 => errore

1 => errore
 */

//sanitizzazione dell'input
int n;
do
{
    Console.Write("Insersci un numero intero positivo: ");
    n = int.Parse(Console.ReadLine());

    if (n < 2)
        Console.WriteLine("Errore! Dato non coerente");

} while (n<2);

bool flag = false;

for(int i = 2; i < n; i++)
    if (n % i == 0) { 
        flag=true;
        break;
    }

if (!flag)
    Console.WriteLine($"{n} è primo");
else
    Console.WriteLine($"{n} non è primo");