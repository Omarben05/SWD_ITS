namespace DiarioGUI
{
    public partial class frmGestioneDiario : Form
    {
        public frmGestioneDiario()
        {
            InitializeComponent();
        }

        private void btnNuovoCommento_Click(object sender, EventArgs e) { 
        
            NuovoCommento nuovoCommento = new NuovoCommento();
            nuovoCommento.Show();

        }

        private void btnLeggiCommenti_Click(object sender, EventArgs e)
        {
            LeggiCommenti leggiCommenti = new LeggiCommenti();
            leggiCommenti.Show();
        }
    }
}
