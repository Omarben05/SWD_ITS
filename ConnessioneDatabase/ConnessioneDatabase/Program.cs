using System.Data;
using System.Data.SqlClient;

namespace ConnessioneDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connessione al Database con AdO.NET!");



            //preparare una stringa di connessione

            //mi serve:
            //1. il nome del server    => "localhost\SQLEXPRESS" 
            //2. il nome del database  => "Istat"
            //3. User id => 
            //4. password =>

            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();

            connectionString.DataSource = @"localhost\SQLEXPRESS01";
            connectionString.InitialCatalog = "Istat";
            connectionString.UserID = "sa";
            connectionString.Password = "Its-2025";

            try
            {
                //connessione al database sql server
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString.ConnectionString;
                connection.Open();
                Console.WriteLine("Connessione al database riuscita!");

                //estrazione dati
                //visualizzare ripartizione geografica, regione, provincia e comune di tutti i comuni appartenenti ad una certa 
                //zona altimetrica (presa da input dell'utente) 

                Console.Write("Inserisci la zona altimetrica: ");
                string zonaAltimetra = Console.ReadLine();

            

                string sql = "SELECT rg.Denominazione as RipartizioneGeografica, r.Denominazione as Regione, p.Denominazione as Provincia, c.Denominazione as Comune" +
                    " FROM RipartizioneGeografica rg " +
                    " INNER JOIN Regione r ON rg.Id = r.IdRipartizione " +
                    " INNER JOIN Provincia p ON r.Id = p.IdRegione " +
                    " INNER JOIN Comune c ON p.Id = c.IdProvincia " +
                    "INNER JOIN ZonaAltimetrica za ON c.IdZonaAltimetrica = za.Id " +
                    " WHERE za.Denominazione = @ZonaAltimetrica";

                Console.WriteLine(sql);
                SqlCommand command = new SqlCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Connection = connection;


                //uso dei parametri
                command.Parameters.Add("@ZonaAltimetrica",SqlDbType.VarChar, 50).Value = zonaAltimetra;
                command.CreateParameter(); 

                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("\n Elenco ripartizioni geografiche");
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"Ripartizione geografica: {reader.GetString("RipartizioneGeografica")}"+
                        $", Regione: {reader.GetString("Regione")}" +
                        $", Provincia: {reader.GetString("Provincia")}" +
                        $", Comune: {reader.GetString("Comune")}"

                        );
                }

                // elimino gli oggetti e la connessione al database
                reader.Close();
                command.Dispose();
                connection.Close();

            }
            //gestione delle eccezioni
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
