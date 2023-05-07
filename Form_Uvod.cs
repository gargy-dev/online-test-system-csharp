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
    public partial class Form_Uvod : Form
    {
        public Form_Uvod()
        {
            InitializeComponent();
        }

        int pocetSekund = 0;

        // metoda casovaca, ktora vytvara jednoduchu animaciu ProgressBaru na zaklade pripocitavania casu a hodnoty ProgressBaru
        // ak dosiahne ProgressBar hodnotu 100, okno Uvod zmizne a zobrazi sa namiesto neho okno Prihlasenie
        private void casovac_Tick(object sender, EventArgs e)
        {
            pocetSekund += 1;
            progressBar_uvod.Value = pocetSekund;
            label_nacitavanie_percenta.Text = pocetSekund + "%";

            if (progressBar_uvod.Value == 100)
            {
                progressBar_uvod.Value = 0;
                casovac.Stop();
                Form_Prihlasenie prihlasenie = new Form_Prihlasenie();
                prihlasenie.Show();
                this.Hide();
            }
        }
    }
}
