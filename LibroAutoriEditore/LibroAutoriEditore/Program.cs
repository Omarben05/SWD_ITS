using System;
    
    namespace LibroAutoriEditori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro oggetto = new Libro("AAA1111", "Ciao", "Andu e Omar", "Mondadori", "2025", "2", "1")
            Console.WriteLine(oggetto.StampaLineare());
        }
    }
}