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
    public partial class Form_Prihlasenie : Form
    {
        public Form_Prihlasenie()
        {
            InitializeComponent();
            ziskajPredmety();
        }

        MySqlConnection pripojenie = new MySqlConnection("server=127.0.0.1;uid=root;" + "pwd=;database=online-testovanie");

        public static string StudentMeno = "", PredmetNazov = "";

        // metoda, na zaklade ktorej sa nam zobrazia predmety pomocou dopytu v ComboBoxe
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

        // metoda ukoncenia aplikacie
        private void pictureBox_ukoncit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // prepojenie s Admin prihlasenim
        private void label_admin_prihlasenie_Click(object sender, EventArgs e)
        {
            Form_AdminPrihlasenie Obj = new Form_AdminPrihlasenie();
            Obj.Show();
            this.Hide();
        }

        // metoda, ktora sluzi na prihlasenie uzivatela ako Student
        // na zaciatku sa na vstupe overi ci bolo zadane heslo a meno
        // ak heslo a meno nebolo zadane vobec tak sa vypise v okne vyzva na zadanie hesla a mena
        // ak heslo alebo meno nebolo zadane spravne tak sa vypise v okne sprava o nespravnosti hesla alebo mena
        // po nezadani hesla alebo mena a zadani nespravneho hesla alebo mena sa vstup hesla a mena vycisti - zresetuje
        private void button_prihlasenie_Click(object sender, EventArgs e)
        {
            // funkcia na overenie vstupu uzivatela - studenta
            if(textBox_meno.Text == "" || textBox_heslo.Text == "")
            {
                MessageBox.Show("Zadajte prosím užívateľské meno a heslo ak chcete pokračovať", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                pripojenie.Open();

                MySqlDataAdapter msda = new MySqlDataAdapter("select count(*) from studenti where student_heslo = '"+textBox_heslo.Text+"' and student_meno = '"+textBox_meno.Text+"'", pripojenie);
                DataTable dt = new DataTable();
                msda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    StudentMeno = textBox_meno.Text;
                    PredmetNazov = comboBox_predmety.SelectedValue.ToString();
                    Form_Test Obj = new Form_Test();
                    Obj.Show();
                    this.Hide();
                    pripojenie.Close();
                }

                else
                {
                    MessageBox.Show("Zadali ste nesprávne užívateľské meno alebo heslo!", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_meno.Text = "";
                    textBox_heslo.Text = "";
                }

                pripojenie.Close();
            }
        }
    }
}
