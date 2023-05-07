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
    public partial class Ucitel : Form
    {
        public Ucitel()
        {
            InitializeComponent();
        }

        private void pictureBox_koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ucitel_Load(object sender, EventArgs e)
        {
            uC_PridatNovuOtazku1.Visible = false;
            uC_AktualizovatOtazku1.Visible =false;
        }

        private void button_pridat_otazku_Click(object sender, EventArgs e)
        {
            uC_PridatNovuOtazku1.Visible = true;
            uC_PridatNovuOtazku1.BringToFront();
        }

        private void button_aktualizovat_otazku_Click(object sender, EventArgs e)
        {
            uC_AktualizovatOtazku1.Visible = true;
            uC_AktualizovatOtazku1.BringToFront();
        }
    }
}
