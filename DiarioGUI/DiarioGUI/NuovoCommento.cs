using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiarioGUI
{
    public partial class NuovoCommento : Form
    {
        public NuovoCommento()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\File\Diario.csv";

            Commento commento = new Commento();
            commento.Testo=txtCommento.Text;

            var lista = MyLibrary.ElencoCommenti(path);

            int maxId=0;
            if(lista.Count!=0) 
                maxId = lista.Max(x => x.Id);
            commento.Id = maxId+1;

            //scrivi su file csv
            MyLibrary.ScriviCommento(path, commento);
            
            MessageBox.Show("Operazione avvenuta con successo", "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //txtCommento.Text = string.Empty;
            this.Close(); //chiude la finestra attuale
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sicuro di voler cancellare tutto?", "Cancella", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                txtCommento.Text = string.Empty;
        }
    }
}
