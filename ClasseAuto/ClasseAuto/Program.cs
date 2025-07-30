/*

Si consideri un nuovo tipo di dato: Auto.Di un'auto si conoscono le seguenti caratteristiche: marca, modello, cilindrata, alimentazione, colore. 
Si consideri il calcolo della velocità max raggiunta dall'auto, da implementare seguendo il seguente algoritmo: si consideri la cilindrata e la si divida per 10.
Si aggiunga a questo risultato un bonus dato all'alimentazione: benzina => +30, diesel => +20, gpl => -10, metano => -30;

Si consideri un metodo "usa e getta" Stampa, per riassumere tutte le caratteristiche delle istanze e il metodo appena descritto.

Si istanzino tre oggetti. */

//istanzio la classe Auto
    class Auto
    {
        // Proprietà dell'auto
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public string Alimentazione { get; set; }
        public string Colore { get; set; }

        // Costruttore per inizializzare un oggetto Auto
        public Auto(string marca, string modello, int cilindrata, string alimentazione, string colore)
        {
            Marca = marca;
            Modello = modello;
            Cilindrata = cilindrata;
            Alimentazione = alimentazione.ToLower(); // Per evitare problemi di maiuscole/minuscole
            Colore = colore;
        }

        // Metodo per calcolare la velocità massima stimata
        public int CalcolaVelocitaMax()
        {
            // Calcolo base: cilindrata divisa per 10
            int velocitaBase = Cilindrata / 10;

            // Bonus/malus in base al tipo di alimentazione
            int bonus = 0;

            switch (Alimentazione)
            {
                case "benzina":
                    bonus = 30;
                    break;
                case "diesel":
                    bonus = 20;
                    break;
                case "gpl":
                    bonus = -10;
                    break;
                case "metano":
                    bonus = -30;
                    break;
                default:
                    Console.WriteLine("Alimentazione non riconosciuta, bonus 0 applicato.");
                    break;
            }

            // Ritorna la somma della velocità base e il bonus
            return velocitaBase + bonus;
        }

        // Metodo usa e getta per stampare le caratteristiche e la velocità
        public void Stampa()
        {
            Console.WriteLine("--------- AUTO ---------");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modello: {Modello}");
            Console.WriteLine($"Cilindrata: {Cilindrata} cc");
            Console.WriteLine($"Alimentazione: {Alimentazione}");
            Console.WriteLine($"Colore: {Colore}");
            Console.WriteLine($"Velocità Massima Stimata: {CalcolaVelocitaMax()} km/h");
            Console.WriteLine("------------------------\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Istanza di tre oggetti Auto
            Auto auto1 = new Auto("Fiat", "Punto", 1200, "benzina", "rosso");
            Auto auto2 = new Auto("Volkswagen", "Golf", 2000, "diesel", "blu");
            Auto auto3 = new Auto("Opel", "Corsa", 1400, "gpl", "grigio");

            // Uso del metodo Stampa per ogni oggetto
            auto1.Stampa();
            auto2.Stampa();
            auto3.Stampa();
        }
    }



