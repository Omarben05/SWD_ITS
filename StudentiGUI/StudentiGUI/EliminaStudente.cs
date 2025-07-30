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
    public partial class EliminaStudente : Form
    {
        public EliminaStudente()
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

                txtMatricola.Text = s.Matricola.ToString();
                txtNome.Text = s.Nome;
                txtCognome.Text = s.Cognome;
                txtEmail.Text = s.Email;
                txtClasse.Text = s.Classe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler eliminare tutti i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                var matricola = Convert.ToInt32(txtMatricola.Text);

                StudentiDAL dal = new StudentiDAL();

                Studente s = dal.Cerca(matricola)!;
                dal.Elimina(s);

                MessageBox.Show("Eliminazione avvenuta con successo", "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
