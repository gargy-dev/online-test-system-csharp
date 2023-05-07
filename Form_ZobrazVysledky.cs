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
    public partial class Form_ZobrazVysledky : Form
    {
        public Form_ZobrazVysledky()
        {
            InitializeComponent();
            ziskajPredmety();
            ziskajStudentov();
            ZobrazVysledkyStudentov();
        }

        MySqlConnection pripojenie = new MySqlConnection("server=127.0.0.1;uid=root;" + "pwd=;database=online-testovanie");

        // metoda, na zaklade ktorej sa v ComboBoxe vypisu nazvy predmetov pomocou dopytu z DB
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

        // metoda, na zaklade ktorej sa v ComboBoxe vypisu mena studentov pomocou dopytu z DB
        private void ziskajStudentov()
        {
            pripojenie.Open();
            MySqlCommand prikaz = new MySqlCommand("select student_meno from studenti", pripojenie);
            MySqlDataReader msdr;
            msdr = prikaz.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("student_meno", typeof(string));
            dt.Load(msdr);
            comboBox_student.ValueMember = "student_meno";
            comboBox_student.DataSource = dt;
            pripojenie.Close();
        }

        // metoda, na zaklade ktorej sa v DGV vypisu jednotlive vysledky studentov pomocou dopytu z DB
        private void ZobrazVysledkyStudentov()
        {
            pripojenie.Open();

            string dopyt = "select * from vysledky";
            MySqlDataAdapter msda = new MySqlDataAdapter(dopyt, pripojenie);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(msda);
            var ds = new DataSet();
            msda.Fill(ds);
            VysledkyStudentovDGV.DataSource = ds.Tables[0];

            pripojenie.Close();
        }

        // metoda, pomocou ktorej si dokazeme vyfiltrovat jednotlive vysledky studentov na zaklade konkretneho predmetu 
        private void FilterPodlaPredmetu()
        {
            pripojenie.Open();

            string dopyt = "select * from vysledky where vysledok_predmet = '"+comboBox_predmety.SelectedValue.ToString()+"'";
            MySqlDataAdapter msda = new MySqlDataAdapter(dopyt, pripojenie);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(msda);
            var ds = new DataSet();
            msda.Fill(ds);
            VysledkyStudentovDGV.DataSource = ds.Tables[0];

            pripojenie.Close();
        }

        // metoda, pomocou ktorej si dokazeme vyfiltrovat jednotlive vysledky studentov na zaklade konkretneho studenta 
        private void FilterPodlaStudenta()
        {
            pripojenie.Open();

            string dopyt = "select * from vysledky where vysledok_student = '" + comboBox_student.SelectedValue.ToString() + "'";
            MySqlDataAdapter msda = new MySqlDataAdapter(dopyt, pripojenie);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(msda);
            var ds = new DataSet();
            msda.Fill(ds);
            VysledkyStudentovDGV.DataSource = ds.Tables[0];

            pripojenie.Close();
        }

        // ak bola vykonana zmena, resp. vybrali sme nejaky konkretny predmet z ComboBoxu predmetov tak sa vyfiltruju jednotlive vysledky studentov podla konkretneho predmetu
        private void comboBox_predmety_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterPodlaPredmetu();
        }

        // ak bola vykonana zmena, resp. vybrali sme nejakeho konkretneho studenta z ComboBoxu studentov tak sa vyfiltruju jednotlive vysledky studentov podla konkretneho studenta
        private void comboBox_student_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterPodlaStudenta();
        }

        // prepojenia s inymi Formami
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

        private void label_predmety1_Click(object sender, EventArgs e)
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
    }
}
