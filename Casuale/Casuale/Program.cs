// Genera un numero intero casuale appartenente ad un intervallo [1, 100]
// visualizzare il numero trovato

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(random.Next(100) + 1);
}
