using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentiGUI
{
    public partial class ModificaStudente : Form
    {
        private Studente studente;
        public ModificaStudente()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            try
            {
                StudentiDAL dal = new StudentiDAL();

                int matricola = Convert.ToInt32(txtRicercaMatricola.Text);

                studente = dal.Dettaglio(matricola)!;

                txtMatricola.Text = studente.Matricola.ToString();
                txtNome.Text = studente.Nome;
                txtCognome.Text = studente.Cognome;
                txtEmail.Text = studente.Email;
                txtClasse.Text = studente.Classe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            try
            {
                StudentiDAL dal = new StudentiDAL();
                                
                Studente s = new Studente { 
                Matricola=Convert.ToInt32(txtMatricola.Text),
                Nome= txtNome.Text,
                Cognome= txtCognome.Text,
                Email= txtEmail.Text,
                Classe= txtClasse.Text
                };

                dal.Modifica(s);

                MessageBox.Show("Modifica avvenuta con successo", "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ResetForm()
        {
            txtMatricola.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCognome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtClasse.Text = string.Empty;
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler eliminare tutti i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ResetForm();
        }
    }
}
