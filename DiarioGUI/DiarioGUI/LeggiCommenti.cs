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
    public partial class LeggiCommenti : Form
    {
        private string path = @"..\..\..\File\Diario.csv";
        public LeggiCommenti()
        {
            InitializeComponent();

            var lista = MyLibrary.ElencoCommenti(path);

            lblNumeroCommenti.Text = lblNumeroCommenti.Text + lista.Count;

            var txt = lista.Select(x => x.Stampa()).ToList();

            txtElencoCommenti.Text = string.Join(Environment.NewLine, txt);


        }
    }
}
