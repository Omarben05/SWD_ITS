namespace Quadrilateri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ereditarietà");

            var q1 = new Quadrilatero(1.25, 1.5, 4, 2.75);  //var definisce il type di cio che gli dai , oggetto di tipo quadrilatero
            //Quadrilatero q1 = new Quadrilatero(1.25, 1.5, 4, 2.75);   stessa cosa
            Console.WriteLine(q1);

            var r1 = new Rettangolo(1.75, 2.25);
            Console.WriteLine(r1);

            var q2 = new Quadrato(1.5);
            Console.WriteLine(q2);

        }
    }
}
