using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace p65_72_Korabsky_Pavol
{
    public partial class Form_Studenti : Form
    {
        public Form_Studenti()
        {
            InitializeComponent();
            ZobrazVsetkychStudentov();
        }

        // funkcia na reset vstupov
        private void Reset()
        {
            textBox_meno_priezvisko.Text = "";
            textBox_vek.Text = "";
            textBox_mobil.Text = "";
            textBox_adresa.Text = "";
            textBox_heslo.Text = "";
        }

        MySqlConnection pripojenie = new MySqlConnection("server=127.0.0.1;uid=root;" + "pwd=;database=online-testovanie");

        // metoda pomocou ktorej sa nam v DGV zobrazi prehladny zoznam studentov na zaklade dopytu z DB
        private void ZobrazVsetkychStudentov()
        {
            pripojenie.Open();

            string dopyt = "select * from studenti";
            MySqlDataAdapter msda = new MySqlDataAdapter(dopyt, pripojenie);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(msda);
            var ds = new DataSet();
            msda.Fill(ds);
            StudentiDGV.DataSource = ds.Tables[0];

            pripojenie.Close();
        }

        // metoda, ktora sluzi na ulozenie, resp. pridanie studenta
        private void button_ulozit_Click(object sender, EventArgs e)
        {
            if(textBox_meno_priezvisko.Text == "" || textBox_vek.Text == "" || textBox_heslo.Text == "" || textBox_mobil.Text == "" || textBox_adresa.Text == "")
            {
                MessageBox.Show("Neboli vyplnené všetky údaje", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    int skore = 0;
                    pripojenie.Open();
                    MySqlCommand prikaz = new MySqlCommand("insert into studenti (student_meno, student_vek, student_heslo, student_skore, student_adresa, student_mobil) values(@Smeno, @Svek, @Sheslo, @Sskore, @Sadresa, @Smobil)", pripojenie);

                    // @Smeno, @Svek, @Sheslo, @Sskore, @Sadresa, @Smobil
                    prikaz.Parameters.AddWithValue("@Smeno", textBox_meno_priezvisko.Text);
                    prikaz.Parameters.AddWithValue("@Svek", textBox_vek.Text);
                    prikaz.Parameters.AddWithValue("@Sheslo", textBox_heslo.Text);
                    prikaz.Parameters.AddWithValue("@Sskore", skore);
                    prikaz.Parameters.AddWithValue("@Sadresa", textBox_adresa.Text);
                    prikaz.Parameters.AddWithValue("@Smobil", textBox_mobil.Text);
                    prikaz.ExecuteNonQuery();

                    MessageBox.Show("Študent bol uložený", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pripojenie.Close();
                    Reset();
                    ZobrazVsetkychStudentov();
                }

                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // metoda, ktora sluzi na upravu studenta, resp. aktualizaciu studenta v DB
        private void button_upravit_Click(object sender, EventArgs e)
        {
            if (textBox_meno_priezvisko.Text == "" || textBox_vek.Text == "" || textBox_vek.Text == "vek" || textBox_heslo.Text == "" || textBox_mobil.Text == "" || textBox_adresa.Text == "")
            {
                MessageBox.Show("Neboli vyplnené všetky údaje", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    pripojenie.Open();
                    MySqlCommand prikaz = new MySqlCommand("update studenti set student_meno = @Smeno, student_vek = @Svek, student_heslo = @Sheslo, student_adresa = @Sadresa, student_mobil = @Smobil where student_id = @Skluc", pripojenie);

                    // @Smeno, @Svek, @Sheslo, @Sskore, @Sadresa, @Smobil, @Skluc
                    prikaz.Parameters.AddWithValue("@Smeno", textBox_meno_priezvisko.Text);
                    prikaz.Parameters.AddWithValue("@Svek", textBox_vek.Text);
                    prikaz.Parameters.AddWithValue("@Sheslo", textBox_heslo.Text);
                    prikaz.Parameters.AddWithValue("@Sadresa", textBox_adresa.Text);
                    prikaz.Parameters.AddWithValue("@Smobil", textBox_mobil.Text);
                    prikaz.Parameters.AddWithValue("@Skluc", kluc);
                    prikaz.ExecuteNonQuery();

                    MessageBox.Show("Študent bol aktualizovaný", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pripojenie.Close();
                    Reset();
                    ZobrazVsetkychStudentov();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int kluc = 0;

        // metoda, ktora umozni upravovanie udajov studenta pomocou kliknutia do DGV
        private void StudentiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_meno_priezvisko.Text = StudentiDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox_vek.Text = StudentiDGV.SelectedRows[0].Cells[2].Value.ToString();
            textBox_heslo.Text = StudentiDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBox_adresa.Text = StudentiDGV.SelectedRows[0].Cells[5].Value.ToString();
            textBox_mobil.Text = StudentiDGV.SelectedRows[0].Cells[6].Value.ToString();

            if(textBox_meno_priezvisko.Text == "")
            {
                kluc = 0;
            }

            else
            {
                kluc = Convert.ToInt32(StudentiDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        // prepojenia pomocou Labelov na ine Formy
        private void label_predmety_Click(object sender, EventArgs e)
        {
            Form_Predmety Obj = new Form_Predmety();
            Obj.Show();
            this.Hide();
        }

        private void label_otazky_Click(object sender, EventArgs e)
        {
            Form_Otazky Obj = new Form_Otazky();
            Obj.Show();
            this.Hide();
        }

        private void label_predmet1_Click(object sender, EventArgs e)
        {
            Form_Predmety Obj = new Form_Predmety();
            Obj.Show();
            this.Hide();
        }

        private void label_odhlasenie_Click(object sender, EventArgs e)
        {
            Form_Prihlasenie Obj = new Form_Prihlasenie();
            Obj.Show();
            this.Hide();
        }

        private void label_o_programe_Click(object sender, EventArgs e)
        {
            Form_Informacie Obj = new Form_Informacie();
            Obj.Show();
        }

        private void label_vysledky_Click(object sender, EventArgs e)
        {
            Form_ZobrazVysledky Obj = new Form_ZobrazVysledky();
            Obj.Show();
            this.Hide();
        }
    }
}
