/*
output: BUON GIORNO | BUON POMERIGGIO | BUONA SERA | BUONA NOTTE

DALLE 6 ALLE 14 BG
DALLE 14 ALLE 19 BP
DALLE 18 ALLE 22 BS
22 BN
 */

// data e ora si recupera dal type DateTime


DateTime oggi= DateTime.Now; 


Console.WriteLine(oggi.ToString()); // in string
Console.WriteLine(oggi); // lo da come string di default 

string msg= string.Empty;
if (oggi.Hour >= 6 && oggi.Hour < 14)
    msg = "BUON GIORNO";
else if (oggi.Hour >= 14 && oggi.Hour < 18)
    msg = "BUON POMERIGGIO";
else if (oggi.Hour >= 18 && oggi.Hour < 22)
    msg = "BUONA SERA";
else
    msg = "BUONA NOTTE";

Console.WriteLine(msg);
Console.WriteLine($"Data (long): {oggi.ToLongDateString()}");
Console.WriteLine($"Data (short): {oggi.ToShortDateString()}");
Console.WriteLine($"Sono le ore: {oggi.ToShortTimeString()}");
    