using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal class Libro
    {
        public string? Isbn { get; set; }
        public string? Titolo { get; set; }
        public Autori Autore { get; set; } = new Autori();
        public Editore Editore { get; set; } = new Editore();
        public int Npagine { get; set; }
        public string Anno { get; set; }
        public double Prezzo
        {
            get
            {
                return 5.05 + (Npagine * 0.15);
            }
        }
        public override string ToString()
        {
            return $"ISBN: {Isbn}" +
                   $"\n Titolo: {Titolo}" +
                   $"\n Autore: {Autore.NCognome}" +
                   $"\n editore: {Editore.ragionesociale}" +
                   $"\n Numero di pagine: {Npagine}" +
                   $"\n Anno:{Anno}" +
                   $"\n Prezzo:{Prezzo}";


        }
    }
}
