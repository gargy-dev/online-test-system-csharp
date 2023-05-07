using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p65_72_Korabsky_Pavol
{
    class funkcia
    {
        protected MySqlConnection ziskajPripojenie()
        {
            string server_meno = "127.0.0.1";
            string databaza = "online-testovanie-db";
            string uzivatelske_meno = "root";
            string heslo = "";

            MySqlConnection pripojenie = new MySqlConnection();
            pripojenie.ConnectionString = "SERVER=" + server_meno + ";" + "DATABASE=" + databaza + ";" + "UID=" + uzivatelske_meno + ";" + "PASSWORD=" + heslo + ";";
            return pripojenie;
        }

        public DataSet ziskajData(String dopyt)
        {
            MySqlConnection pripojenie = ziskajPripojenie();
            MySqlCommand prikaz = new MySqlCommand();
            prikaz.Connection = pripojenie;
            prikaz.CommandText = dopyt;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(prikaz);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public void setData(String dopyt, String sprava)
        {
            MySqlConnection pripojenie = ziskajPripojenie();
            MySqlCommand prikaz = new MySqlCommand();
            prikaz.Connection = pripojenie;
            pripojenie.Open();
            prikaz.CommandText = dopyt;
            prikaz.ExecuteNonQuery();
            pripojenie.Close();
            MessageBox.Show(sprava, "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MySqlDataReader getForCombo(String dopyt)
        {
            MySqlConnection pripojenie = ziskajPripojenie();
            MySqlCommand prikaz = new MySqlCommand();
            prikaz.Connection = pripojenie;
            pripojenie.Open();
            prikaz = new MySqlCommand(dopyt, pripojenie);
            MySqlDataReader sdr = prikaz.ExecuteReader();
            return sdr;
        }
    }
}
