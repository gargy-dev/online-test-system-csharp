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
    public partial class Form_AdminPrihlasenie : Form
    {
        public Form_AdminPrihlasenie()
        {
            InitializeComponent();
        }

        // metoda, ktora sluzi na prihlasenie uzivatela ako Admina
        // na zaciatku sa na vstupe overi ci bolo zadane heslo
        // ak heslo nebolo zadane vobec tak sa vypise v okne vyzva na zadanie hesla
        // ak heslo nebolo zadane spravne tak sa vypise v okne sprava o nespravnosti hesla
        // po nezadani hesla a zadani nespravneho hesla sa vstup hesla vycisti - zresetuje
        private void button_prihlasenie_Click(object sender, EventArgs e)
        {
            if(textBox_heslo.Text == "")
            {
                MessageBox.Show("Zadajte prosím vaše heslo", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if(textBox_heslo.Text == "admin") // heslo si mozme zvolit lubovolne
            {
                Form_Otazky Obj = new Form_Otazky();
                Obj.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Zadali ste nesprávne Admin heslo", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_heslo.Text = "";
            }
        }

        // metody, ktore sluzia a prepojenia na jednotlive Formy - teda okna
        private void label_naspat_Click(object sender, EventArgs e)
        {
            Form_Prihlasenie Obj = new Form_Prihlasenie();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox_ukoncit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
