using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioGUI
{
    internal class MyLibrary
    {
        public static List<Commento> ElencoCommenti(string path)
        {
            var elenco = new List<Commento>();

            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                //id;data;testo
                string riga = sr.ReadLine();
                string[] dati = riga.Split(";");

                elenco.Add(new Commento
                {
                    Id = Convert.ToInt32(dati[0]),
                    Data = Convert.ToDateTime(dati[1]),
                    Testo = dati[2]
                });
            }
            sr.Close();

            return elenco;
        }
        public static void ScriviCommento(string path, Commento commento)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(commento.StampaCSV());
            sw.Close();
        }   

    }
}
