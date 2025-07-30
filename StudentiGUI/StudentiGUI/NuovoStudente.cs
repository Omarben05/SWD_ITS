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
    public partial class NuovoStudente : Form
    {
        public NuovoStudente()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            try
            {
                StudentiDAL dal = new StudentiDAL();

                var matricola = Convert.ToInt32(txtMatricola.Text);

                var studente = dal.Cerca(matricola);

                if (studente != null)
                    throw new Exception($"La matricola {matricola} esiste già");

                studente = new Studente
                {
                    Matricola = matricola,
                    Nome = txtNome.Text,
                    Cognome = txtCognome.Text,
                    Email = txtEmail.Text,
                    Classe = txtClasse.Text
                };
                dal.Nuovo(studente);

                MessageBox.Show("Inserimento avvenuto con successo", "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(MessageBox.Show("Sei sicuro di voler eliminare tutti i dati?","Conferma",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                ResetForm();
        }

    }
}
