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
    public partial class UC_AktualizovatOtazku : UserControl
    {
        funkcia fn = new funkcia();
        String dopyt;

        public UC_AktualizovatOtazku()
        {
            InitializeComponent();
        }

        private void UC_AktualizovatOtazku_Load(object sender, EventArgs e)
        {
            // vycistenie ComboBoxu pred nacitanim otazky
            comboBox_vyber.Items.Clear();
            dopyt = "select distinct otazka_vyber from otazky";

            // metoda na ziskanie dat
            DataSet ds = fn.ziskajData(dopyt);

            // cyklus for na vypisanie dat do ComboBoxu
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox_vyber.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboBox_vyber_SelectedIndexChanged(object sender, EventArgs e)
        {
            // vycistenie ComboBoxu pred nacitanim otazky, bez vycistenia sposobuje problem - cisla otazok sa kazdy vyberom navysuju
            comboBox_cislo_otazky.Items.Clear();
            dopyt = "select otazka_cislo from otazky where otazka_vyber = '"+comboBox_vyber.Text+"'";
            DataSet ds = fn.ziskajData(dopyt);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox_cislo_otazky.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboBox_cislo_otazky_SelectedIndexChanged(object sender, EventArgs e)
        {
            // po vybere otazky sa vypise otazka, ktoru chceme aktualizovat
            dopyt = "select otazka, moznost_A, moznost_B, moznost_C, moznost_D, spravna_odpoved from otazky where otazka_vyber = '"+comboBox_vyber.Text+"' and otazka_cislo = '"+comboBox_cislo_otazky.Text+"'";
            DataSet ds = fn.ziskajData(dopyt);

            textBox_otazka.Text = ds.Tables[0].Rows[0][0].ToString();
            textBox_moznost_1.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox_moznost_2.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox_moznost_3.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox_moznost_4.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox_spravna_odpoved.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            vymazVsetky();
        }

        public void vymazVsetky()
        {
            textBox_otazka.Clear();
            textBox_moznost_1.Clear();
            textBox_moznost_2.Clear();
            textBox_moznost_3.Clear();
            textBox_moznost_4.Clear();
            textBox_spravna_odpoved.Clear();
            comboBox_vyber.SelectedIndex = -1;
            comboBox_cislo_otazky.SelectedIndex = -1;
        }

        private void button_aktualizovat_Click(object sender, EventArgs e)
        {
            // nacitanie hodnot z kazdeho textoveho pola a aktualizovanie otazky
            if(comboBox_cislo_otazky.SelectedIndex != -1)
            {
                String otazka_vyber = comboBox_vyber.Text;
                String otazka_cislo = comboBox_cislo_otazky.Text;
                String otazka = textBox_otazka.Text;
                String moznost1 = textBox_moznost_1.Text;
                String moznost2 = textBox_moznost_2.Text;
                String moznost3 = textBox_moznost_3.Text;
                String moznost4 = textBox_moznost_4.Text;
                String spravna_odpoved = textBox_spravna_odpoved.Text;

                dopyt = "update otazky set otazka = '"+otazka+"', moznost_A = '"+moznost1+"', moznost_B = '"+moznost2+"', moznost_C = '"+moznost3+"', moznost_D = '"+moznost4+"', spravna_odpoved = '"+spravna_odpoved+"' where otazka_vyber = '"+otazka_vyber+"' and otazka_cislo = '"+otazka_cislo+"'";
                fn.setData(dopyt, "Číslo otázky: "+otazka_cislo+" \n Výber otázky: "+otazka_vyber+"\n bola aktualizovaná");
            }

            else
            {
                MessageBox.Show("Pred aktualizáciou otázky si najprv zvoľte otázku, ktorú chcete aktualizovať!", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_sync_Click(object sender, EventArgs e)
        {
            UC_AktualizovatOtazku_Load(this, null);
        }
    }
}
