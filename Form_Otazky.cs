using MySql.Data.MySqlClient;
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
    public partial class Form_Otazky : Form
    {
        public Form_Otazky()
        {
            InitializeComponent();
            ziskajPredmety();
            ZobrazVsetkyOtazky();
        }

        // string, ktory sluzi na prepojenie nasej C# aplikacie s MySql databazou (server, uid, pwd a database si mozeme vhodne zmenit podla potreby)
        MySqlConnection pripojenie = new MySqlConnection("server=127.0.0.1;uid=root;" + "pwd=;database=online-testovanie");

        // metoda, ktora sluzi na nacitanie (ziskanie) predmetov z databazy na zaklade dopytu
        private void ziskajPredmety()
        {
            pripojenie.Open();

            MySqlCommand prikaz = new MySqlCommand("select predmet_nazov from predmety", pripojenie);
            MySqlDataReader msdr;
            msdr = prikaz.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("predmet_nazov", typeof(string));
            dt.Load(msdr);
            comboBox_predmety.ValueMember = "predmet_nazov";
            comboBox_predmety.DataSource = dt;

            pripojenie.Close();
        }

        // metoda reset, pomocou ktorej si "vycistime" vstupy textboxov ak chceme pridat nejaku otazku
        private void Reset()
        {
            textBox_otazka_popis.Text = "";
            textBox_moznost1.Text = "";
            textBox_moznost2.Text = "";
            textBox_moznost3.Text = "";
            textBox_moznost4.Text = "";
            textBox_spravna_odpoved.Text = "";
            comboBox_predmety.SelectedIndex = 0;
        }

        // metoda, ktora sluzi na nacitanie vsetkych otazok z databazy
        private void ZobrazVsetkyOtazky()
        {
            pripojenie.Open();

            string dopyt = "select * from otazky";
            MySqlDataAdapter msda = new MySqlDataAdapter(dopyt, pripojenie);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(msda);
            var ds = new DataSet();
            msda.Fill(ds);
            OtazkyDGV.DataSource = ds.Tables[0];

            pripojenie.Close();
        }

        // metoda, ktora sluzi na pridanie, resp. ulozenie konkretneho predmetu, ktory vytvorime
        private void button_ulozit_Click(object sender, EventArgs e)
        {
            if (textBox_otazka_popis.Text == "" || textBox_moznost1.Text == "" || textBox_moznost2.Text == "" || textBox_moznost3.Text == "" || textBox_moznost4.Text == "" || textBox_spravna_odpoved.Text == "")
            {
                MessageBox.Show("Neboli vyplnené všetky údaje", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    pripojenie.Open();

                    MySqlCommand prikaz = new MySqlCommand("insert into otazky (otazka_popis, moznost_1, moznost_2, moznost_3, moznost_4, spravna_odpoved, otazka_predmet) values(@Opopis, @Omoznost1, @Omoznost2, @Omoznost3, @Omoznost4, @Ospravna_odpoved, @Opredmet)", pripojenie);

                    // @Opopis, @Omoznost1, @Omoznost2, @Omoznost3, @Omoznost4, @Ospravna_odpoved, @Opredmet
                    prikaz.Parameters.AddWithValue("@Opopis", textBox_otazka_popis.Text);
                    prikaz.Parameters.AddWithValue("@Omoznost1", textBox_moznost1.Text);
                    prikaz.Parameters.AddWithValue("@Omoznost2", textBox_moznost2.Text);
                    prikaz.Parameters.AddWithValue("@Omoznost3", textBox_moznost3.Text);
                    prikaz.Parameters.AddWithValue("@Omoznost4", textBox_moznost4.Text);
                    prikaz.Parameters.AddWithValue("@Ospravna_odpoved", textBox_spravna_odpoved.Text);
                    prikaz.Parameters.AddWithValue("@Opredmet", comboBox_predmety.SelectedValue.ToString());
                    prikaz.ExecuteNonQuery();

                    MessageBox.Show("Otázka bola uložená", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pripojenie.Close();

                    Reset();
                    ZobrazVsetkyOtazky();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        int kluc = 0;

        // pomocou tejto metody mozeme dany predmet upravovat, resp. aktualizovat
        private void button_upravit_Click(object sender, EventArgs e)
        {
            if (textBox_otazka_popis.Text == "" || textBox_moznost1.Text == "" || textBox_moznost2.Text == "" || textBox_moznost3.Text == "" || textBox_moznost4.Text == "" || textBox_spravna_odpoved.Text == "")
            {
                MessageBox.Show("Neboli vyplnené všetky údaje", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    pripojenie.Open();
                    MySqlCommand prikaz = new MySqlCommand("update otazky set otazka_popis = @Opopis, moznost_1 = @Omoznost1, moznost_2 = @Omoznost2, moznost_3 = @Omoznost3, moznost_4 = @Omoznost4, spravna_odpoved = @Ospravna_odpoved, otazka_predmet = @Opredmet where otazka_id = @Okluc", pripojenie);

                    // @Opopis, @Omoznost1, @Omoznost2, @Omoznost3, @Omoznost4, @Ospravna_odpoved, @Opredmet
                    prikaz.Parameters.AddWithValue("@Opopis", textBox_otazka_popis.Text);
                    prikaz.Parameters.AddWithValue("@Omoznost1", textBox_moznost1.Text);
                    prikaz.Parameters.AddWithValue("@Omoznost2", textBox_moznost2.Text);
                    prikaz.Parameters.AddWithValue("@Omoznost3", textBox_moznost3.Text);
                    prikaz.Parameters.AddWithValue("@Omoznost4", textBox_moznost4.Text);
                    prikaz.Parameters.AddWithValue("@Ospravna_odpoved", textBox_spravna_odpoved.Text);
                    prikaz.Parameters.AddWithValue("@Opredmet", comboBox_predmety.SelectedValue.ToString());
                    prikaz.Parameters.AddWithValue("@Okluc", kluc);
                    prikaz.ExecuteNonQuery();

                    MessageBox.Show("Otázka bola aktualizovaná", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pripojenie.Close();
                    Reset();
                    ZobrazVsetkyOtazky();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // metoda, ktora nam nacitane otazky z databazy prehladne vypise do DataGridViewu 
        private void OtazkyDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_otazka_popis.Text = OtazkyDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox_moznost1.Text = OtazkyDGV.SelectedRows[0].Cells[2].Value.ToString();
            textBox_moznost2.Text = OtazkyDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBox_moznost3.Text = OtazkyDGV.SelectedRows[0].Cells[4].Value.ToString();
            textBox_moznost4.Text = OtazkyDGV.SelectedRows[0].Cells[5].Value.ToString();
            textBox_spravna_odpoved.Text = OtazkyDGV.SelectedRows[0].Cells[6].Value.ToString();
            comboBox_predmety.SelectedValue = OtazkyDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (textBox_otazka_popis.Text == "")
            {
                kluc = 0;
            }

            else
            {
                kluc = Convert.ToInt32(OtazkyDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        // nasledujuce metody sluzia ako tzv. odkazy na ine Formy - okna aplikacie

        private void label_o_programe_Click(object sender, EventArgs e)
        {
            Form_Informacie Obj = new Form_Informacie();
            Obj.Show();
        }

        private void label_odhlasenie_Click(object sender, EventArgs e)
        {
            Form_Prihlasenie Obj = new Form_Prihlasenie();
            Obj.Show();
            this.Hide();
        }

        private void label_predmety1_Click(object sender, EventArgs e)
        {
            Form_Predmety Obj = new Form_Predmety();
            Obj.Show();
            this.Hide();
        }

        private void label_student_Click(object sender, EventArgs e)
        {
            Form_Studenti Obj = new Form_Studenti();
            Obj.Show();
            this.Hide();
        }

        private void label_predmety_Click(object sender, EventArgs e)
        {
            Form_Predmety Obj = new Form_Predmety();
            Obj.Show();
            this.Hide();
        }

        private void label_studenti_Click(object sender, EventArgs e)
        {
            Form_Studenti Obj = new Form_Studenti();
            Obj.Show();
            this.Hide();
        }
    }
}
