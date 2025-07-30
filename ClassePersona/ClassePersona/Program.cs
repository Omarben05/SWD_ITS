namespace ClassePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Persone!");

            Persona pino = new Persona();
            Console.WriteLine(pino.StampaLineare());

            Persona dino = new Persona("Delillo","Dino");
            Console.WriteLine(dino.StampaDettaglio());

            Persona mino = new Persona("De Pisco", "Mino", new DateTime(2000, 5, 31), "Torino");
            Console.WriteLine(mino);

            Persona rino = new Persona("De Niro", "Rino", new DateTime(1984, 3, 31), "Genova", Sesso.M);
            Console.WriteLine(rino);
        }
    }
}
