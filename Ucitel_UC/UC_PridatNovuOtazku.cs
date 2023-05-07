using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p65_72_Korabsky_Pavol.Ucitel_UC
{
    public partial class UC_PridatNovuOtazku : UserControl
    {
        funkcia fn = new funkcia();
        String dopyt;
        DataSet ds;
        Int64 cisloOtazky = 1;

        public UC_PridatNovuOtazku()
        {
            InitializeComponent();
        }

        private void UC_PridatNovuOtazku_Load(object sender, EventArgs e)
        {
            dopyt = "select max(otazka_vyber) from otazky";
            ds = fn.ziskajData(dopyt);

            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                textBox_vyber.Text = (id + 1).ToString();
            }

            else
            {
                textBox_vyber.Text = "1";
            }
            label_otazka_cislo.Text = cisloOtazky.ToString();
            label_vyber_neexistuje.Visible = false;
        }

        private void button_dalej_Click(object sender, EventArgs e)
        {
            String oVyber = textBox_vyber.Text;
            String oCislo = cisloOtazky.ToString();
            String otazka = textBox_otazka.Text;
            String moznost1 = textBox_moznost_1.Text;
            String moznost2 = textBox_moznost_2.Text;
            String moznost3 = textBox_moznost_3.Text;
            String moznost4 = textBox_moznost_4.Text;
            String spravnaOdpoved = textBox_spravna_odpoved.Text;

            dopyt = "insert into otazky (otazka_vyber, otazka_cislo, otazka, moznost_A, moznost_B, moznost_C, moznost_D, spravna_odpoved) values ('"+oVyber+"','"+oCislo+"','"+otazka+"','"+moznost1+"','"+moznost2+"','"+moznost3+"','"+moznost4+"','"+spravnaOdpoved+"')";
            fn.setData(dopyt, "Otázka bola pridaná");

            //vymazVsetky()
            cisloOtazky++;
            label_otazka_cislo.Text = cisloOtazky.ToString();
        }

        public void vymazVsetky()
        {
            textBox_otazka.Clear();
            textBox_moznost_1.Clear();
            textBox_moznost_2.Clear();
            textBox_moznost_3.Clear();
            textBox_moznost_4.Clear();
            textBox_spravna_odpoved.Clear();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Neuložené údaje budú stratené!","Upozornenie",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                vymazVsetky();
            }
        }

        private void button_dokoncit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Výber bude upravený","Upozornenie",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                textBox_vyber.Text = (Int64.Parse(textBox_vyber.Text.ToString()) + 1).ToString();
                label_otazka_cislo.Text = "1";
            }
        }

        private void textBox_vyber_TextChanged(object sender, EventArgs e)
        {
            if(textBox_vyber.Text != "")
            {
                vymazVsetky();
                dopyt = "select otazka_cislo from otazky where otazka_vyber = '"+textBox_vyber.Text+"'";
                ds = fn.ziskajData(dopyt);

                if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    label_otazka_cislo.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    cisloOtazky = Int64.Parse(label_otazka_cislo.Text.ToString());
                }

                else
                {
                    label_otazka_cislo.Text = "1";
                    cisloOtazky = Int64.Parse(label_otazka_cislo.Text.ToString());
                    label_vyber_neexistuje.Visible = true;
                }
            }
        }
    }
}
