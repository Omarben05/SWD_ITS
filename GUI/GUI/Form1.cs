namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            string txt = "Hai inserito il seguente testo: " + txtTesto.Text;

            MessageBox.Show(txt, "Risultato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
