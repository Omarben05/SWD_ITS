using System;

namespace LibroAutoreEditore
{
    internal class Libro
    {
        public string ISBN { get; set; } = string.Empty;
        public string titolo { get; set; } = string.Empty;
        public string autori { get; set; } = string.Empty;
        public string editore { get; set; } = string.Empty;
        public DateOnly annoPubblicazione { get; set; };
        public int numeroPagine { get; set; };
        public float prezzo { get; set; }


        public Libro(string ISBN, string titolo, string autori, string editore, DateOnly annoPubblicazione, int numeroPagine, float prezzo)
        {
            this.ISBN = ISBN
        ; this.titolo = titolo
            this.autori = autori
            this.editore = editore
            this.annoPubblicazione = annoPubblicazione
            this.numeroPagine = numeroPagine
            this.prezzo = prezzo
        }


        //metodo "consumer" - usa e getta
        private string Stampa(string separatore)
        {
            return $"{nameof(ISBN)}={ISBN}" +
                $"{separatore}{nameof(titolo)}={titolo}" +
                $"{separatore}{nameof(autori)}={autori}" +
                $"{separatore}{nameof(editore)}={editore}" +
                $"{separatore}{nameof(annoPubblicazione)}={annoPubblicazione}" +
                $"{separatore}{nameof(numeroPagine)}={numeroPagine}" +
                $"{separatore}{nameof(prezzo)}={prezzo}"
        }
        public string StampaLineare()
        {
            return Stampa(", ");
        }

        public string StampaDettaglio()
        {
            return Stampa("\n");
        }

        public override string ToString()
        {
            return $"{{{StampaLineare()}}}";
        }
    }
}
