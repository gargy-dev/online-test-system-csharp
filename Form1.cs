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
    public partial class Form_HO_PK : Form
    {
        public Form_HO_PK()
        {
            InitializeComponent();
        }

        private void Form_HO_PK_Load(object sender, EventArgs e)
        {
            panel_prihlasenie_student.Visible = false;
            panel_prihlasenie_ucitel.Visible = false;
            label_nespravne_prihlasenie_ucitel.Visible = false;
        }

        private void comboBox_typy_uzivatelov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_typy_uzivatelov.SelectedIndex == 0)
            {
                
                panel_prihlasenie_ucitel.Visible = true;
                panel_prihlasenie_student.Visible = false;
            }

            else if(comboBox_typy_uzivatelov.SelectedIndex == 1)
            {
                panel_prihlasenie_student.Visible = true;
                panel_prihlasenie_ucitel.Visible = false;
            }
        }

        private void checkBox_zobrazit_heslo_ucitel_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_zobrazit_heslo_ucitel.Checked == true)
            {
                textBox_heslo_ucitel.PasswordChar = '\0';
                checkBox_zobrazit_heslo_ucitel.Text = "Skryť Heslo";
            }

            else
            {
                textBox_heslo_ucitel.PasswordChar = '*';
                checkBox_zobrazit_heslo_ucitel.Text = "Zobraziť Heslo";
            }
        }

        private void pictureBox_koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
