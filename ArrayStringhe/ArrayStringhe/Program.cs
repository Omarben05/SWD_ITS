/*
 Creare un array di nomi di persone
 Visualizzare tutti i nomi 


 */


Console.WriteLine("Array di nomi di persona!");

//definizione dell'array
string[] nomi = new string [] 
    {
        "Mario", "Luca", "Giulia", "Anna", "Francesco", "Elena", "Giovanni", "Sara", "Marco", "Alessia",
        "Paolo", "Martina", "Stefano", "Valentina", "Andrea", "Chiara", "Davide", "Federica", "Alessandro", "Simona",
        "Matteo", "Roberta", "Gabriele", "Laura", "Emanuele", "Veronica", "Daniele", "Beatrice", "Riccardo", "Silvia",
        "Cristian", "Vanessa", "Antonio", "Elisa", "Vincenzo", "Miriam", "Salvatore", "Alice", "Roberto", "Monica",
        "Fabio", "Irene", "Dario", "Francesca", "Massimo", "Debora", "Giuseppe", "Claudia", "Pietro", "Giorgia"
    };
/*
Array riempito con valori determinati dalla seguente interrogazione:
1."ho bisogno di un array di stringhe in C# con nomi di persona"
2."me ne servono almeno 50"
 */



// Stampiamo i nomi

var k = 0;
foreach (var nome in nomi)
{
    Console.WriteLine($"{k++}: {nome.ToUpper()}"); //nome.ToUpper() o .ToLower()  per maiusvolo o minuscolo
}