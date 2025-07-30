using System.Data;
using System.Data.SqlClient;

namespace DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connesione al database CRUD con ADO.NET!");

            StudentiDAL dal = new StudentiDAL();

            string menu = "Scegli una delle seguenti operazioni:" +
                "\n1 - Elenco studenti" +
                "\n2 - Visualizza scheda dettaglio di uno studente" +
                "\n3 - Inserisci un nuovo studente" +
                "\n4 - Modifica dati di uno studente" +
                "\n5 - Elimina uno studente" +
                "\n0 - Esci dal programma" +
                "\n\n" +
                "Scelta: ";
            int scelta = 0;
            do
            {
                Console.Write(menu);
                scelta = Convert.ToInt32(Console.ReadLine());
                try
                {


                    switch (scelta)
                    {
                        case 1:
                            Console.WriteLine("Elenco studenti:");
                            Console.WriteLine(string.Join("\n", dal.Elenco()));
                            break;
                        case 2:
                            Console.Write("Inserisci la matricola dello studente: ");
                            int matricola = Convert.ToInt32(Console.ReadLine());
                            var studente = dal.Dettaglio(matricola);
                            if (studente != null)
                            {
                                Console.WriteLine(studente);
                            }
                            else
                            {
                                Console.WriteLine("Studente non trovato.");
                            }
                            break;
                        case 3:
                            Studente studente1 = new Studente();
                            Console.WriteLine("Inserisci i dati necessari dello studente: ");
                            Console.Write("Matricola: ");
                            studente1.Matricola = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nome: ");
                            studente1.Nome = Console.ReadLine();
                            Console.Write("Cognome: ");
                            studente1.Cognome = Console.ReadLine();
                            Console.Write("Email: ");
                            studente1.Email = Console.ReadLine();
                            Console.Write("Classe: ");
                            studente1.Classe = Console.ReadLine();

                            dal.Nuovo(studente1);
                            Console.WriteLine("Operazione eseguita con successo.");
                            break;
                        case 4:/*
                            Studente studente1 = new Studente();
                            Console.WriteLine("Inserisci i dati necessari dello studente: ");
                            Console.Write("Matricola: ");
                            studente1.Matricola = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nome: ");
                            studente1.Nome = Console.ReadLine();
                            Console.Write("Cognome: ");
                            studente1.Cognome = Console.ReadLine();
                            Console.Write("Email: ");
                            studente1.Email = Console.ReadLine();
                            Console.Write("Classe: ");
                            studente1.Classe = Console.ReadLine();

                            dal.Nuovo(studente1);
                            Console.WriteLine("Operazione eseguita con successo.");
                            break;*/
                        case 5:
                            Console.Write("Inserisci la matricola dello studente da eliminare: ");
                            var s = dal.Dettaglio(Convert.ToInt32(Console.ReadLine()));
                            dal.Elimina(s);
                            Console.WriteLine("Operazione eseguita con successo.");
                            break;
                        case 0:
                            Console.WriteLine("Uscita dal programma...");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Errore: " + e.Message);
                }
            } while (scelta != 0);

        }
    }
}