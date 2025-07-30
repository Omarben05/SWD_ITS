// Dato in input un carattere rappresentabile
// visualizzare la sua posizione in ASCII standard



Console.WriteLine("Inserisci un carattere da tastiera: ");

Char c = char.Parse(Console.ReadLine());

int posizione = (int)c;
Console.WriteLine("Il carattere {0} e' in posizione ASCII: {1}", c,posizione);
