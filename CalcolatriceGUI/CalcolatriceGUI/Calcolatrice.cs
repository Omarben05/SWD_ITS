namespace CalcolatriceGUI
{
    public partial class frmCalcolatrice : Form
    {
        private double n1;
        private double n2;
        public frmCalcolatrice()
        {
            InitializeComponent();
        }

        private void load()
        {
            try
            {                
                    n1 = txtN1.Text.Length != 0 ? Convert.ToDouble(txtN1.Text) : 0;

                    n2 = txtN2.Text.Length != 0 ? Convert.ToDouble(txtN2.Text) : 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Errore", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            load();
            txtRisultato.Text = (n1 + n2).ToString();
        }

        private void btnSottrazione_Click(object sender, EventArgs e)
        {
            load();
            txtRisultato.Text = (n1 - n2).ToString();
        }

        private void btnMoltiplicazione_Click(object sender, EventArgs e)
        {
            load();
            txtRisultato.Text = (n1 * n2).ToString();
        }

        private void btnDivisione_Click(object sender, EventArgs e)
        {
            load();
            txtRisultato.Text = (n1 / n2).ToString();
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            load();
            txtRisultato.Text = (n1 % n2).ToString();
        }
    }
}
