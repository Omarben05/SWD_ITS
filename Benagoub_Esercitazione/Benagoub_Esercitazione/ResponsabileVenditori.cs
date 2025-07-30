/* Nome e Cognome: Omar Benagoub 
 * Data: 30-06-2025
 * Corso: SWD
 * Materia: Programmazione - C#
 * Classe: ResponsabileVenditori
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benagoub_Esercitazione
{
    public class ResponsabileVenditori : Venditore
    {
        public List<Venditore> VenditoriGestiti { get; set; }

        public ResponsabileVenditori(string nome, string cognome, decimal stipendio, string settore)
            : base(nome, cognome, stipendio, settore)
        {
            VenditoriGestiti = new List<Venditore>();
        }

        // Metodi: Tredicesima
        public override decimal Tredicesima()
        {
            decimal bonus = 0.15m * 100; // es. 100 = tariffa giornaliera ipotetica per venditore
            return (Stipendio * 2) + (VenditoriGestiti.Count * bonus);
        }

        public override string ToString()
        {
            return base.ToString() + $", Venditori gestiti: {VenditoriGestiti.Count}";
        }
    }

}