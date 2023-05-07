using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p65_72_Korabsky_Pavol
{
    public partial class Form_Informacie : Form
    {
        public Form_Informacie()
        {
            InitializeComponent();
        }

        private void label_domov_Click(object sender, EventArgs e)
        {
            // po kliknuti tlacidla Zatvorit sa toto okno skryje
            this.Hide();
        }
    }
}
