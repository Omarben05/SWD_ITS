namespace Veicoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veicoli!");

            Veicolo v = new Veicolo()
            {
                Marca = "Marca 1",
                Modello = "Modello 1",
                Cilindrata = 1000,
                Carburante = Carburante.GPL,
                Colore = Colore.BLU
            };
            Console.WriteLine(v);

            Auto a = new Auto()
            {
                Marca = "Mercedes",
                Modello = "A",
                Cilindrata = 1600,
                Carburante = Carburante.BENZINA,
                Colore = Colore.BIANCO,
                NumeroPorte = 5,
                Cambio=TipoCambio.AUTOMATICO
            };
            Console.WriteLine(a);

            Scooter s1 = new Scooter()
            {
                Marca = "Piaggio",
                Modello = "Beverly 300S",
                Cilindrata = 300,
                Carburante = Carburante.BENZINA,
                Colore = Colore.BIANCO,
                NumeroRuote = 3
            };
            Console.WriteLine(s1);
            Scooter s2 = new Scooter()
            {
                Marca = "Yamaha",
                Modello = "T-MAX",
                Cilindrata = 600,
                Carburante = Carburante.BENZINA,
                Colore = Colore.NERO,
                NumeroRuote = 2
            };
            Console.WriteLine(s2);            
        }
    }
}
