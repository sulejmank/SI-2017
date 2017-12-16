using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSoftware
{
    public partial class IzmeniKorisnika : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        public IzmeniKorisnika()
        {
            InitializeComponent();
            ucitaj_list();
        }

        public void ucitaj_list()
        {
            try {
                Korisnik korisnik = new Korisnik();

                korisnici = korisnik.izlistaj_korisnike();

                foreach (Korisnik x in korisnici)
                    listBox1.Items.Add(x.Ime);
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Greska!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ime = listBox1.SelectedItem.ToString();

            foreach(Korisnik x in korisnici)
                if(x.Ime == ime)
                {
                    textBox1.Text = x.Ime;
                    textBox2.Text = x.Prezime;
                    textBox3.Text = x.korisnicko_ime;
                    comboBox1.SelectedItem = x.Uloga;
                    textBox5.Text = x.id.ToString();
                }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) ||
                    string.IsNullOrEmpty(textBox2.Text) ||
                    string.IsNullOrEmpty(textBox3.Text) ||
                    string.IsNullOrEmpty(textBox4.Text) ||
                    comboBox1.SelectedItem == null)
                    MessageBox.Show("Molimo vas ispunite sva polja.", "Greska");
                else if (textBox3.Text.Length > 8)
                    MessageBox.Show("Korisnicko ime mora imati do 8 karaktera", "Greska");
                else
                {
                    var pass = textBox4.Text;
                    var md5 = new MD5CryptoServiceProvider();
                    var data = Encoding.ASCII.GetBytes(pass);
                    var hash_pass = md5.ComputeHash(data);

                    Korisnik korisnik = new Korisnik();

                    korisnik.Ime = textBox1.Text;
                    korisnik.Prezime = textBox2.Text;
                    korisnik.id = Int32.Parse(textBox5.Text);
                    korisnik.korisnicko_ime = textBox3.Text;
                    korisnik.lozinka = Convert.ToBase64String(hash_pass);
                    korisnik.Uloga = comboBox1.SelectedItem.ToString();

                    korisnik.izmeni_korisnika();
                    MessageBox.Show("Korisnik uspesno izmenjen!", "Uspesna Izmena");
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox4.UseSystemPasswordChar = false;
            else if (!checkBox1.Checked)
                textBox4.UseSystemPasswordChar = true;
            else
                textBox4.UseSystemPasswordChar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
