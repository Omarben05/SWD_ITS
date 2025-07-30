namespace Libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var L1 = new Libro
            {
                Isbn = "1234ABC",
                Titolo="la borra",
                Autore=new Autori
                {
                    Nome="Thomas",
                    Cognome="Turbato"
                    
                },
                Editore=new Editore
                {
                    ragionesociale="SRL"
                },
                Anno="2016",
                Npagine=230
            };
            Console.WriteLine(L1);
        }
    }
}
