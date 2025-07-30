// Dato in input un numero intero [32,127]
// visualizzare il carattere corrispondente in ASCII standard



Console.WriteLine("Inserisci un numero intero [es: 32,127] da tastiera: ");

int posizione = int.Parse(Console.ReadLine());

char c = (char)posizione;
Console.WriteLine("La posizione ASCII: {0} corrisponde al carattere: {1}", posizione, c);


