// Data in input una data di nascita,
// verificare se è corretta
// restituire come output 
// format data lineare gg/mm/aaaa
// oppure errore

//While (true)
//{
Console.Write("Giorno: ");
int giorno= int.Parse(Console.ReadLine());

Console.Write("Mese: ");
int mese = int.Parse(Console.ReadLine());

Console.Write("Anno: ");
int anno = int.Parse(Console.ReadLine());

bool flag = false; // true -----> errore trovato, false ----> errore non trovato

//verifica dei dati coerenti con una data

if (anno < 1582 || giorno < 1 || giorno > 31 || mese < 1 || mese > 12)
{
    flag = true;
    //continue;
    Console.WriteLine("1");
}
else if ((mese == 4 || mese == 6 || mese == 9 || mese == 11) && giorno == 31)
{
    flag = true;
    //continue;
    Console.WriteLine("2");
}
else if (mese == 2 && giorno > 29)
{
    flag = true;
    //continue;
    Console.WriteLine("3");
}
else if (mese == 2 && giorno == 29 && anno % 4 != 0)
{
    flag = true;
    //continue;
    Console.WriteLine("4");
}
else if (mese == 2 && giorno == 29 && anno % 100 == 0 && anno % 400 != 0)
{
    flag = true;
    //continue;
    Console.WriteLine("5");
}
else
flag= false;    //non serve tanto è default l'abbiamo dichiarato in precedenza
//  break;
//}
string msg = string.Empty;

if (giorno < 10)   //se aggiungi 01 anche se non è maggiore di 10 è int quindi toglie lo 0 e lo aggiungiamo manualmente
    msg += "0"; //msg = msg+"0"
msg += $"{giorno}/";
if (mese<10)
    msg += "0";
msg += $"{mese}/{anno}";


if (!flag)
    Console.WriteLine(msg);
else
    Console.WriteLine("Errore");

