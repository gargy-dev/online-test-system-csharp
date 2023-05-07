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
    public partial class Form_Test : Form
    {
        public Form_Test()
        {
            InitializeComponent();
            //multiNahoda();
            label_student_meno.Text = Form_Prihlasenie.StudentMeno;
            label_predmet.Text = Form_Prihlasenie.PredmetNazov;
            pocet_otazok = pocitajOtazky();
            nacitajOtazky();
            //ulozNajvyssieSkore();
        }

        int pocet_otazok;

        MySqlConnection pripojenie = new MySqlConnection("server=127.0.0.1;uid=root;" + "pwd=;database=online-testovanie");
        string spravna_odpoved1, spravna_odpoved2, spravna_odpoved3, spravna_odpoved4, spravna_odpoved5, spravna_odpoved6, spravna_odpoved7, spravna_odpoved8, spravna_odpoved9, spravna_odpoved10;

        private void Form_Testy_Load(object sender, EventArgs e)
        {
            casovac.Start();
        }

        string[] zvolenaMoznost = new string[10];

        // mozme si nastavit lubovolny cas v sekundach
        int celkovyCas = 180;

        // na zaciatku zacina casovac pocitat sekundy od 0 aby fungoval spravne
        int pocetSekund = 0;

        // metoda casovaca, pomocou ktorej ma student len vymedzeny cas na absolvovanie testu
        // po uplynuti casu a neodoslani vysledkov sa zobrazi vyskakovacie okno, test sa ukonci, vysledky sa neodoslu do databazy a student bude presmerovany na uvodne okno prihlasenia
        private void casovac_Tick(object sender, EventArgs e)
        {
            celkovyCas -= 1;
            pocetSekund += 1;
            okruhlyProgressBar.Value = pocetSekund;
            label_cas.Text = "Ostáva ti ešte " + "" + celkovyCas + " sekúnd do skončenia testu";

            if(okruhlyProgressBar.Value == 180)
            {
                okruhlyProgressBar.Value = 0;
                casovac.Stop();
                MessageBox.Show("Čas vypršal!", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form_Prihlasenie prihlasenie = new Form_Prihlasenie();
                prihlasenie.Show();
                this.Hide();
            }
        }

        // zistenie poctu otazok, na zaklade ktoreho sa budu generovat nahodne otazky
        private int pocitajOtazky()
        {
            int cislo_otazky;
            pripojenie.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter("select count(*) from otazky where otazka_predmet = '"+label_predmet.Text+"'", pripojenie);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            cislo_otazky = Convert.ToInt32(dt.Rows[0][0]);
            pripojenie.Close();
            //MessageBox.Show("Celkový počet otázok: " + cislo_otazky);
            return cislo_otazky;
        }

        // metoda, pomocou ktorej sa ulozi najvyssie skore studenta do databazy
        private void ulozNajvyssieSkore()
        {
            pripojenie.Open();

            MySqlDataAdapter msda2 = new MySqlDataAdapter("select max(vysledok_skore) from vysledky where vysledok_student = '"+label_student_meno.Text+"'", pripojenie);
            DataTable dt2 = new DataTable();
            msda2.Fill(dt2);
            int najvyssie_skore = Convert.ToInt32(dt2.Rows[0][0].ToString());

            try
            {
                //pripojenie.Open();
                MySqlCommand prikaz = new MySqlCommand("update studenti set student_skore = @Sskore where student_meno = @Smeno", pripojenie);

                // @Smeno, @Svek, @Sheslo, @Sskore, @Sadresa, @Smobil, @Skluc
                prikaz.Parameters.AddWithValue("@Smeno", label_student_meno.Text);
                prikaz.Parameters.AddWithValue("@Sskore", najvyssie_skore);
                prikaz.ExecuteNonQuery();

                MessageBox.Show("Študent bol aktualizovaný", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pripojenie.Close();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            pripojenie.Close();
        }

        int[] kluce = new int[10];

        // metoda, ktora sluzi na generovanie 10 nahodnych cisel a teda aj poradia otazok
        private void multiNahoda()
        {
            HashSet<int> cisla = new HashSet<int>();
            var nahoda = new Random();

            while(cisla.Count < 10)
            {
                cisla.Add(nahoda.Next(1, pocet_otazok));
            }

            for(int i=0; i < 10; i++)
            {
                kluce[i] = cisla.ElementAt(i);
            }
        }
      
        // metoda, ktora zabezpeci nielen nacitanie otazok z databazy ale aj ich nasledne vykreslenie do groupBoxov
        private void nacitajOtazky()
        {
            try
            {
                multiNahoda();

                pripojenie.Open();

                string dopyt = "select * from otazky where otazka_id = " + kluce[0] +"";
                MySqlCommand prikaz = new MySqlCommand(dopyt, pripojenie);
                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach(DataRow dr in dt.Rows)
                {
                    groupBox_otazka1.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o1.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o1.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o1.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o1.Text = dr["moznost_4"].ToString();
                    spravna_odpoved1 = dr["spravna_odpoved"].ToString();
                }

                string dopyt1 = "select * from otazky where otazka_id = " + kluce[1] + "";
                prikaz = new MySqlCommand(dopyt1, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka2.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o2.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o2.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o2.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o2.Text = dr["moznost_4"].ToString();
                    spravna_odpoved2 = dr["spravna_odpoved"].ToString();
                }

                string dopyt2 = "select * from otazky where otazka_id = " + kluce[2] + "";
                prikaz = new MySqlCommand(dopyt2, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka3.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o3.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o3.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o3.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o3.Text = dr["moznost_4"].ToString();
                    spravna_odpoved3 = dr["spravna_odpoved"].ToString();
                }

                string dopyt3 = "select * from otazky where otazka_id = " + kluce[3] + "";
                prikaz = new MySqlCommand(dopyt3, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka4.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o4.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o4.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o4.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o4.Text = dr["moznost_4"].ToString();
                    spravna_odpoved4 = dr["spravna_odpoved"].ToString();
                }

                string dopyt4 = "select * from otazky where otazka_id = " + kluce[4] + "";
                prikaz = new MySqlCommand(dopyt4, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka5.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o5.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o5.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o5.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o5.Text = dr["moznost_4"].ToString();
                    spravna_odpoved5 = dr["spravna_odpoved"].ToString();
                }

                string dopyt5 = "select * from otazky where otazka_id = " + kluce[5] + "";
                prikaz = new MySqlCommand(dopyt5, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka6.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o6.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o6.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o6.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o6.Text = dr["moznost_4"].ToString();
                    spravna_odpoved6 = dr["spravna_odpoved"].ToString();
                }

                string dopyt6 = "select * from otazky where otazka_id = " + kluce[6] + "";
                prikaz = new MySqlCommand(dopyt6, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka7.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o7.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o7.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o7.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o7.Text = dr["moznost_4"].ToString();
                    spravna_odpoved7 = dr["spravna_odpoved"].ToString();
                }

                string dopyt7 = "select * from otazky where otazka_id = " + kluce[7] + "";
                prikaz = new MySqlCommand(dopyt7, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka8.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o8.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o8.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o8.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o8.Text = dr["moznost_4"].ToString();
                    spravna_odpoved8 = dr["spravna_odpoved"].ToString();
                }

                string dopyt8 = "select * from otazky where otazka_id = " + kluce[8] + "";
                prikaz = new MySqlCommand(dopyt8, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka9.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o9.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o9.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o9.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o9.Text = dr["moznost_4"].ToString();
                    spravna_odpoved9 = dr["spravna_odpoved"].ToString();
                }

                string dopyt9 = "select * from otazky where otazka_id = " + kluce[9] + "";
                prikaz = new MySqlCommand(dopyt9, pripojenie);
                dt = new DataTable();
                msda = new MySqlDataAdapter(prikaz);
                msda.Fill(dt);

                // cyklus foreach, ktory nam vypise jednotlive nazvy otazok (do groupBoxov) a moznosti k otazkam (do radioButtonov) 
                foreach (DataRow dr in dt.Rows)
                {
                    groupBox_otazka10.Text = dr["otazka_popis"].ToString();
                    radioButton_moznost1o10.Text = dr["moznost_1"].ToString();
                    radioButton_moznost2o10.Text = dr["moznost_2"].ToString();
                    radioButton_moznost3o10.Text = dr["moznost_3"].ToString();
                    radioButton_moznost4o10.Text = dr["moznost_4"].ToString();
                    spravna_odpoved10 = dr["spravna_odpoved"].ToString();
                }

                pripojenie.Close();
            }

            catch
            {
                return;
            }
        }

        // pociatocne skore studenta sa pocita spociatku od 0 - dovod je prosty
        int skore = 0;

        // metody, ktore sluzia na spracovanie vyberu moznosti otazok 1 az 10 a pripocitavanie skore po vybere spravnej odpovede
        private void vyberOtazka1()
        {
            if(radioButton_moznost1o1.Checked)
            {
                zvolenaMoznost[0] = "";
                zvolenaMoznost[0] = radioButton_moznost1o1.Text;
            }

            else if(radioButton_moznost2o1.Checked)
            {
                zvolenaMoznost[0] = "";
                zvolenaMoznost[0] = radioButton_moznost2o1.Text;
            }

            else if (radioButton_moznost3o1.Checked)
            {
                zvolenaMoznost[0] = "";
                zvolenaMoznost[0] = radioButton_moznost3o1.Text;
            }

            else if (radioButton_moznost4o1.Checked)
            {
                zvolenaMoznost[0] = "";
                zvolenaMoznost[0] = radioButton_moznost4o1.Text;
            }

            if (zvolenaMoznost[0] == spravna_odpoved1)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        private void vyberOtazka2()
        {
            if (radioButton_moznost1o2.Checked)
            {
                zvolenaMoznost[1] = "";
                zvolenaMoznost[1] = radioButton_moznost1o2.Text;
            }

            else if (radioButton_moznost2o2.Checked)
            {
                zvolenaMoznost[1] = "";
                zvolenaMoznost[1] = radioButton_moznost2o2.Text;
            }

            else if (radioButton_moznost3o2.Checked)
            {
                zvolenaMoznost[1] = "";
                zvolenaMoznost[1] = radioButton_moznost3o2.Text;
            }

            else if (radioButton_moznost4o2.Checked)
            {
                zvolenaMoznost[1] = "";
                zvolenaMoznost[1] = radioButton_moznost4o2.Text;
            }

            if (zvolenaMoznost[1] == spravna_odpoved2)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        private void vyberOtazka3()
        {
            if (radioButton_moznost1o3.Checked)
            {
                zvolenaMoznost[2] = "";
                zvolenaMoznost[2] = radioButton_moznost1o3.Text;
            }

            else if (radioButton_moznost2o3.Checked)
            {
                zvolenaMoznost[2] = "";
                zvolenaMoznost[2] = radioButton_moznost2o3.Text;
            }

            else if (radioButton_moznost3o3.Checked)
            {
                zvolenaMoznost[2] = "";
                zvolenaMoznost[2] = radioButton_moznost3o3.Text;
            }

            else if (radioButton_moznost4o3.Checked)
            {
                zvolenaMoznost[2] = "";
                zvolenaMoznost[2] = radioButton_moznost4o3.Text;
            }

            if (zvolenaMoznost[2] == spravna_odpoved3)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        private void vyberOtazka4()
        {
            if (radioButton_moznost1o4.Checked)
            {
                zvolenaMoznost[3] = "";
                zvolenaMoznost[3] = radioButton_moznost1o4.Text;
            }

            else if (radioButton_moznost2o4.Checked)
            {
                zvolenaMoznost[3] = "";
                zvolenaMoznost[3] = radioButton_moznost2o4.Text;
            }

            else if (radioButton_moznost3o4.Checked)
            {
                zvolenaMoznost[3] = "";
                zvolenaMoznost[3] = radioButton_moznost3o4.Text;
            }

            else if (radioButton_moznost4o4.Checked)
            {
                zvolenaMoznost[3] = "";
                zvolenaMoznost[3] = radioButton_moznost4o4.Text;
            }

            if (zvolenaMoznost[3] == spravna_odpoved4)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
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

        private void vyberOtazka5()
        {
            if (radioButton_moznost1o5.Checked)
            {
                zvolenaMoznost[4] = "";
                zvolenaMoznost[4] = radioButton_moznost1o5.Text;
            }

            else if (radioButton_moznost2o5.Checked)
            {
                zvolenaMoznost[4] = "";
                zvolenaMoznost[4] = radioButton_moznost2o5.Text;
            }

            else if (radioButton_moznost3o5.Checked)
            {
                zvolenaMoznost[4] = "";
                zvolenaMoznost[4] = radioButton_moznost3o5.Text;
            }

            else if (radioButton_moznost4o5.Checked)
            {
                zvolenaMoznost[4] = "";
                zvolenaMoznost[4] = radioButton_moznost4o5.Text;
            }

            if (zvolenaMoznost[4] == spravna_odpoved5)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        private void vyberOtazka6()
        {
            if (radioButton_moznost1o6.Checked)
            {
                zvolenaMoznost[5] = "";
                zvolenaMoznost[5] = radioButton_moznost1o6.Text;
            }

            else if (radioButton_moznost2o6.Checked)
            {
                zvolenaMoznost[5] = "";
                zvolenaMoznost[5] = radioButton_moznost2o6.Text;
            }

            else if (radioButton_moznost3o6.Checked)
            {
                zvolenaMoznost[5] = "";
                zvolenaMoznost[5] = radioButton_moznost3o6.Text;
            }

            else if (radioButton_moznost4o6.Checked)
            {
                zvolenaMoznost[5] = "";
                zvolenaMoznost[5] = radioButton_moznost4o6.Text;
            }

            if (zvolenaMoznost[5] == spravna_odpoved6)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        private void vyberOtazka7()
        {
            if (radioButton_moznost1o7.Checked)
            {
                zvolenaMoznost[6] = "";
                zvolenaMoznost[6] = radioButton_moznost1o7.Text;
            }

            else if (radioButton_moznost2o7.Checked)
            {
                zvolenaMoznost[6] = "";
                zvolenaMoznost[6] = radioButton_moznost2o7.Text;
            }

            else if (radioButton_moznost3o7.Checked)
            {
                zvolenaMoznost[6] = "";
                zvolenaMoznost[6] = radioButton_moznost3o7.Text;
            }

            else if (radioButton_moznost4o7.Checked)
            {
                zvolenaMoznost[6] = "";
                zvolenaMoznost[6] = radioButton_moznost4o7.Text;
            }

            if (zvolenaMoznost[6] == spravna_odpoved7)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        private void vyberOtazka8()
        {
            if (radioButton_moznost1o8.Checked)
            {
                zvolenaMoznost[7] = "";
                zvolenaMoznost[7] = radioButton_moznost1o8.Text;
            }

            else if (radioButton_moznost2o8.Checked)
            {
                zvolenaMoznost[7] = "";
                zvolenaMoznost[7] = radioButton_moznost2o8.Text;
            }

            else if (radioButton_moznost3o8.Checked)
            {
                zvolenaMoznost[7] = "";
                zvolenaMoznost[7] = radioButton_moznost3o8.Text;
            }

            else if (radioButton_moznost4o8.Checked)
            {
                zvolenaMoznost[7] = "";
                zvolenaMoznost[7] = radioButton_moznost4o8.Text;
            }

            if (zvolenaMoznost[7] == spravna_odpoved8)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        private void vyberOtazka9()
        {
            if (radioButton_moznost1o9.Checked)
            {
                zvolenaMoznost[8] = "";
                zvolenaMoznost[8] = radioButton_moznost1o9.Text;
            }

            else if (radioButton_moznost2o9.Checked)
            {
                zvolenaMoznost[8] = "";
                zvolenaMoznost[8] = radioButton_moznost2o9.Text;
            }

            else if (radioButton_moznost3o9.Checked)
            {
                zvolenaMoznost[8] = "";
                zvolenaMoznost[8] = radioButton_moznost3o9.Text;
            }

            else if (radioButton_moznost4o9.Checked)
            {
                zvolenaMoznost[8] = "";
                zvolenaMoznost[8] = radioButton_moznost4o9.Text;
            }

            if (zvolenaMoznost[8] == spravna_odpoved9)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        private void vyberOtazka10()
        {
            if (radioButton_moznost1o10.Checked)
            {
                zvolenaMoznost[9] = "";
                zvolenaMoznost[9] = radioButton_moznost1o10.Text;
            }

            else if (radioButton_moznost2o10.Checked)
            {
                zvolenaMoznost[9] = "";
                zvolenaMoznost[9] = radioButton_moznost2o10.Text;
            }

            else if (radioButton_moznost3o10.Checked)
            {
                zvolenaMoznost[9] = "";
                zvolenaMoznost[9] = radioButton_moznost3o10.Text;
            }

            else if (radioButton_moznost4o10.Checked)
            {
                zvolenaMoznost[9] = "";
                zvolenaMoznost[9] = radioButton_moznost4o10.Text;
            }

            if (zvolenaMoznost[9] == spravna_odpoved10)
            {
                skore++;
            }

            else
            {
                //skore = skore;
            }
        }

        // metoda, ktora sluzi na odoslanie vysledkov studenta do databazy po skonceni testu a odoslani vysledkov studentom
        private void odoslatVysledky()
        {
            try
            {
                pripojenie.Open();
                MySqlCommand prikaz = new MySqlCommand("insert into vysledky (vysledok_predmet, vysledok_student, vysledok_datum, vysledok_cas, vysledok_skore) values(@Vpredmet, @Vstudent, @Vdatum, @Vcas, @Vskore)", pripojenie);

                // @Vpredmet, @Vstudent, @Vdatum, @Vcas, @Vskore
                prikaz.Parameters.AddWithValue("@Vpredmet", label_predmet.Text);
                prikaz.Parameters.AddWithValue("@Vstudent", label_student_meno.Text);
                prikaz.Parameters.AddWithValue("@Vdatum", dateTimePicker_datum_otazka.Value.Date);
                prikaz.Parameters.AddWithValue("@Vcas", dateTimePicker_cas_otazka.Value.Date);
                prikaz.Parameters.AddWithValue("@Vskore", skore);
                prikaz.ExecuteNonQuery();

                MessageBox.Show("Výsledky boli úspešne odoslané", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pripojenie.Close();
                //Reset();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // metoda, pomocou ktorej sa po stlaceni tlacidla odoslu vysledky a zaroven aj hned vyhodnotenie - uspesnost studenta
        private void button_odoslat_Click(object sender, EventArgs e)
        {
            // pred zaciatkom absolvovania testu je nase skore 0 - pocet spravnych odpovedi
            skore = 0;

            vyberOtazka1();
            vyberOtazka2();
            vyberOtazka3();
            vyberOtazka4();
            vyberOtazka5();
            vyberOtazka6();
            vyberOtazka7();
            vyberOtazka8();
            vyberOtazka9();
            vyberOtazka10();

            // vypise nam nase dosiahnute skore - pocet spravnych odpovedi
            MessageBox.Show("Počet správnych odpovedí: "+skore+" ", "Koniec testu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            odoslatVysledky();
            ulozNajvyssieSkore();

            // po skonceni testu sa vrati student naspat na uvodne prihlasenie
            Form_Prihlasenie prihlasenie = new Form_Prihlasenie();
            prihlasenie.Show();
            this.Hide();
        }
    }
}
