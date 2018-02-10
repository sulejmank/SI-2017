using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSoftware
{
    public partial class Detalji : Form
    {
        public static string adresa;
        public static string naziv;

        public Detalji()
        {
            InitializeComponent();
            ucitaj_podatke();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Detalji_Load(object sender, EventArgs e)
        {

        }
        private void ucitaj_podatke()
        {
            try
            {
                Parking par = new Parking();
                par.TrenutnoStanje();
                adresa = par.adresa;
                naziv = par.naziv;

                textBox1.Text = naziv;
                textBox2.Text = adresa;

            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Greska");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^A-Z_a-z0-9,. ]"))
            {
                MessageBox.Show("Molimo vas unesite samo tekst i broj.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^A-Z_a-z0-9,. ]"))
            {
                MessageBox.Show("Molimo vas unesite samo tekst i broj.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try {

                Parking par = new Parking();
                par.naziv = textBox1.Text;
                par.adresa = textBox2.Text;

                par.promeni_detalje();
                MessageBox.Show("Uspesno ste izmenili detalje parkinga.");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
