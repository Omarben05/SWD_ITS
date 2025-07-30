using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DatabaseCRUD
{
    internal class StudentiDAL
    {
        SqlConnectionStringBuilder connectionString;
        public StudentiDAL()
        {
            // Inizializzazione del database o della connessione
            connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = @"localhost\SqlExpress01";
            connectionString.InitialCatalog = "CRUD";
            connectionString.UserID = "sa";
            connectionString.Password = "Its-2025";
        }

        //Elenco di tutti gli studenti

        public List<Studente> Elenco()
        {
            var elenco = new List<Studente>();


            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = connectionString.ConnectionString;
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        string sql = "SELECT * FROM Studenti";
                        sqlCommand.CommandText = sql;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = sqlConnection;

                        using (SqlDataReader sdr = sqlCommand.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                elenco.Add(
                                    new Studente
                                    {
                                        Matricola = sdr.GetInt32(0),
                                        Nome = sdr.GetString(1),
                                        Cognome = sdr.GetString(2),
                                        Email = sdr.GetString(3),
                                        Classe = sdr.GetString(4)

                                    }
                                );
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw;
            }
            return elenco;
        }

        //Scheda di dettaglio Studente

        public Studente Dettaglio(int Matricola)
        {
            Studente studente = null;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection())
                {
                    sqlConnection.ConnectionString = connectionString.ConnectionString;
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        string sql = "SELECT * FROM Studenti where Matricola = @Matricola";
                        sqlCommand.CommandText = sql;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = Matricola;
                        sqlCommand.CreateParameter();

                        using (SqlDataReader sdr = sqlCommand.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                studente = new Studente

                                {
                                    Matricola = sdr.GetInt32(0),
                                    Nome = sdr.GetString(1),
                                    Cognome = sdr.GetString(2),
                                    Email = sdr.GetString(3),
                                    Classe = sdr.GetString(4)

                                };

                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw;
            }
            return studente;
        }

        // Inserimento nuovo studente

        public void Nuovo(Studente studente)
        {


            if (studente == null)
                throw new Exception("Studente non presente");


            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString.ConnectionString;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    string sql = "INSERT INTO Studenti VALUES(@Matricola,@Nome,@Cognome,@Email,@Classe)";
                    sqlCommand.CommandText = sql;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = studente.Matricola;
                    sqlCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = studente.Nome;
                    sqlCommand.Parameters.Add("@Cognome", SqlDbType.VarChar, 50).Value = studente.Cognome;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studente.Email;
                    sqlCommand.Parameters.Add("@Classe", SqlDbType.VarChar, 50).Value = studente.Classe;

                    //sqlCommand.CreateParameter();

                    if (sqlCommand.ExecuteNonQuery() != 1)
                    {
                        throw new Exception("Inserimento non riuscito");
                    }
                }

            }

        }

        //Modifica dati di studente 
        public void Modifica(Studente studente)
        {


            if (studente == null)
                throw new Exception("Studente non presente");


            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString.ConnectionString;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    string sql = "Update Studenti SET Nome=@Nome, Cognome=@Cognome, Email=@Email, Classe= @Classe Where Matricola=@Matricola";
                    sqlCommand.CommandText = sql;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = studente.Matricola;
                    sqlCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = studente.Nome;
                    sqlCommand.Parameters.Add("@Cognome", SqlDbType.VarChar, 50).Value = studente.Cognome;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studente.Email;
                    sqlCommand.Parameters.Add("@Classe", SqlDbType.VarChar, 50).Value = studente.Classe;

                    //sqlCommand.CreateParameter();

                    if (sqlCommand.ExecuteNonQuery() != 1)
                    {
                        throw new Exception("Inserimento non riuscito");
                    }
                }

            }

        }
        //Elimina dati di studente 
        public void Elimina(Studente studente)
        {


            if (studente == null)
                throw new Exception("Studente non presente");


            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString.ConnectionString;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    string sql = "DELETE FROM Studenti WHERE Matricola=@Matricola";
                    sqlCommand.CommandText = sql;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = studente.Matricola;
                    sqlCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = studente.Nome;
                    sqlCommand.Parameters.Add("@Cognome", SqlDbType.VarChar, 50).Value = studente.Cognome;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studente.Email;
                    sqlCommand.Parameters.Add("@Classe", SqlDbType.VarChar, 50).Value = studente.Classe;

                    //sqlCommand.CreateParameter();

                    if (sqlCommand.ExecuteNonQuery() != 1)
                    {
                        throw new Exception("Inserimento non riuscito");
                    }
                }

            }

        }

    }
}