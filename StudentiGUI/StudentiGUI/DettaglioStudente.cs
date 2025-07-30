using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentiGUI
{
    public partial class DettaglioStudente : Form
    {
        public DettaglioStudente()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            try
            {
                StudentiDAL dal = new StudentiDAL();

                int matricola = Convert.ToInt32(txtRicercaMatricola.Text);

                Studente s = dal.Dettaglio(matricola)!;
                txtRisultato.Text = s.Stampa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
    }
}
