// Generare un array di numeri interi casuali a dimensione casuale con le seguenti ipotesi
// a. dimensione dell'array: [inf,sup], inf e sup presi in input
// b. riempimento dell'array: [inf1,sup1], con inf1 e sup1 presi in input

// creare un menu testuale per scegliere una delle seguenti operazioni
// 1. posizione e valore dei numeri multipli di m, con m dato in input
// 2. posizione e valore dei numeri primi generati
// 3. media aritmetica dei soli numeri strettamente positivi
// 4. posizione e valore dei numeri generati
// 0. esci 

//input dei dati
int inf, sup, inf1,sup1;
do
{
    Console.WriteLine("Inserisci gli estremi dell'intervallo [inf, sup] " +
        "per determinare la dimensione dell'array in modo casuale");
    Console.Write("Inf: ");
    inf = int.Parse(Console.ReadLine());

    Console.Write("Sup: ");
    sup = int.Parse(Console.ReadLine());

    if (inf >= sup || inf <= 0)
        Console.WriteLine("Dati inseriti non coerenti");
    else
        break;
} while (true);

Random random = new Random();

int[] numeri = new int[random.Next(inf,sup+1)];

do
{
    Console.WriteLine("Inserisci gli estremi dell'intervallo [inf1, sup1]" +
        " per determinare la generazione casuale del valore da caricare nell'array");
    Console.Write("Inf1: ");
    inf1 = int.Parse(Console.ReadLine());

    Console.Write("Sup: ");
    sup1 = int.Parse(Console.ReadLine());

    if (inf1 >= sup1)
        Console.WriteLine("Dati inseriti non coerenti");
    else
        break;
} while (true);

//riempimento dell'array
for (int i = 0; i < numeri.Length; i++)
    numeri[i]=random.Next(inf1,sup1+1);

//definizione del menu testuale
string msg = "\n\nScegliere una delle seguenti operazioni: " +
    "\n1. posizione e valore dei numeri multipli di m, con m dato in input" +
    "\n2. posizione e valore dei numeri primi generati" +
    "\n3. media aritmetica dei soli numeri strettamente positivi" +
    "\n4. posizione e valore dei numeri generati" +
    "\n0. esci" +
    "\n\nla tua scelta: ";

int scelta;
do { 

Console.Write(msg);
    scelta = int.Parse(Console.ReadLine());

    switch (scelta)
    {
        case 1: {
                //1. multipli di m, con m dato in input
                Console.Write("Inserisci il valore di cui cercare i multipli nell'array");
                int m = int.Parse(Console.ReadLine());

                for (int i = 0; i < numeri.Length; i++)
                    if (numeri[i] % m == 0)
                        Console.WriteLine($"{i}: {numeri[i]}");
            }; break;
        case 2: {
                // 2. posizione e valore dei numeri primi generati
                Console.WriteLine("Ricerca di numeri primi");
                for (int i = 0; i < numeri.Length; i++)
                    if (IsPrimo(numeri[i]))
                        Console.WriteLine($"{i}: {numeri[i]}");
            }; break;
        case 3: {
                // 3. media aritmetica dei soli numeri strettamente positivi
                Console.WriteLine("media aritmetica dei soli numeri strettamente positivi");
                int somma = 0; //sommatore
                int contaPositivi = 0;
                for (int i = 0; i < numeri.Length; i++)
                    if (numeri[i] > 0)
                    {
                        somma += numeri[i];
                        contaPositivi++;
                    }

                if (contaPositivi > 0)
                    Console.WriteLine($"media aritmetica: {(double)somma / contaPositivi}");
                else
                    Console.WriteLine($"Non sono stati generati numeri strettamente positivi");
            };break;
        case 4: {
                //stampa dell'array - format: posizione: valore
                Console.WriteLine("Stampa elenco array");
                for (int i = 0; i < numeri.Length; i++)
                    Console.WriteLine($"{i}: {numeri[i]}");
            };break;
        case 0: Console.WriteLine("Programma terminato");break;
        default:Console.WriteLine("Dato inserito non coerente");break;
    }

} while (scelta!=0);

//funzione di verifica se un numero è un numero primo
static bool IsPrimo(int numero) { 
    //filtro
    if(numero<2)
        return false;

    for(int i = 2;i<numero-1;i++)
        if(numero%i==0)
            return false; //numero non primo
    return true; //numero primo
}