namespace StudentiGUI
{
    public partial class ElencoStudenti : Form
    {
        public ElencoStudenti()
        {
            InitializeComponent();

            StudentiDAL dal = new StudentiDAL();

            lblNumeroStudentiTrovati.Text = lblNumeroStudentiTrovati.Text + dal.Elenco().Count;

            var txt = dal.Elenco().Select(x=>x.Stampa()).ToList();
            txtElencoStudenti.Text = string.Join(Environment.NewLine, txt);
        }
    }
}
