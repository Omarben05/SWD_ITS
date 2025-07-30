// Dati in input due numeri interi,
// calcolare la somma
// visualizzare il risultato

//Fase di input

Console.Write("Inserisci un numero intero: ");
string tmp = Console.ReadLine();  //"4" esempio input, readline legge l'input
int a = int.Parse(tmp);  // "4" diventa 4, converte in intero il relativo numero

Console.Write("Inserisci un altro numero intero: ");
int b = int.Parse(Console.ReadLine());

//Fase di calcolo
int somma = a + b; 

//Fase di output
Console.WriteLine(somma);
