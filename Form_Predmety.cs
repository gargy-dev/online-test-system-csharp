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
    public partial class Form_Predmety : Form
    {
        public Form_Predmety()
        {
            InitializeComponent();
            ZobrazVsetkyPredmety();
        }

        int kluc = 0;

        // funkcia na reset vstupu nazvu predmetu a pridelenie 0 premennej kluc
        private void Reset()
        {
            textBox_nazov_predmetu.Text = "";
            kluc = 0;
        }

        // string na pripojenie k DB
        MySqlConnection pripojenie = new MySqlConnection("server=127.0.0.1;uid=root;" +
                "pwd=;database=online-testovanie");

        // metoda, pomocou ktorej sa nam zobrazia vsetky predmety do DGV na zaklade dopytu
        private void ZobrazVsetkyPredmety()
        {
            pripojenie.Open();

            string dopyt = "select * from predmety";
            MySqlDataAdapter msda = new MySqlDataAdapter(dopyt, pripojenie);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(msda);
            var ds = new DataSet();
            msda.Fill(ds);
            PredmetyDGV.DataSource = ds.Tables[0];

            pripojenie.Close();
        }

        // nasledujuce metody zahrnaju CRUD operacie s datami v databaze - vytvaranie, citanie, uprava, mazanie
        private void button_ulozit_Click(object sender, EventArgs e)
        {
            if (textBox_nazov_predmetu.Text == "")
            {
                MessageBox.Show("Neboli vyplnené všetky údaje", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    pripojenie.Open();
                    MySqlCommand prikaz = new MySqlCommand("insert into predmety (predmet_nazov) values(@Pnazov)", pripojenie);

                    // @Pnazov
                    prikaz.Parameters.AddWithValue("@Pnazov", textBox_nazov_predmetu.Text);
                    prikaz.ExecuteNonQuery();

                    MessageBox.Show("Predmet bol uložený", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pripojenie.Close();
                    Reset();
                    ZobrazVsetkyPredmety();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button_upravit_Click(object sender, EventArgs e)
        {
            if (textBox_nazov_predmetu.Text == "")
            {
                MessageBox.Show("Neboli vyplnené všetky údaje", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    pripojenie.Open();
                    MySqlCommand prikaz = new MySqlCommand("update predmety set predmet_nazov = @Pnazov where predmet_id = @Pkluc", pripojenie);

                    // @Pnazov
                    prikaz.Parameters.AddWithValue("@Pnazov", textBox_nazov_predmetu.Text);
                    prikaz.Parameters.AddWithValue("@Pkluc", kluc);
                    prikaz.ExecuteNonQuery();

                    MessageBox.Show("Predmet bol aktualizovaný", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pripojenie.Close();
                    Reset();
                    ZobrazVsetkyPredmety();
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

        // metoda, pomocou ktorej dokazeme upravovat dany predmet kliknutim do DGV do daneho riadku predmetu
        private void PredmetyDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_nazov_predmetu.Text = PredmetyDGV.SelectedRows[0].Cells[1].Value.ToString();

            if (textBox_nazov_predmetu.Text == "")
            {
                kluc = 0;
            }

            else
            {
                kluc = Convert.ToInt32(PredmetyDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        // odkazy medzi oknami - Formami
        private void label_studenti_Click(object sender, EventArgs e)
        {
            Form_Studenti Obj = new Form_Studenti();
            Obj.Show();
            this.Hide();
        }

        private void label_student_Click(object sender, EventArgs e)
        {
            Form_Studenti Obj = new Form_Studenti();
            Obj.Show();
            this.Hide();
        }

        private void label_otazky_Click(object sender, EventArgs e)
        {
            Form_Otazky Obj = new Form_Otazky();
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
    }
}
