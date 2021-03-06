﻿using System;
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
    public partial class DodajKorisnika : Form
    {
        public DodajKorisnika()
        {
            InitializeComponent();
        }

        private void DodajKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try {
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
                    korisnik.korisnicko_ime = textBox3.Text;
                    korisnik.lozinka = Convert.ToBase64String(hash_pass);
                    korisnik.Uloga = comboBox1.SelectedItem.ToString();

                    korisnik.dodaj_korisnika();
                    MessageBox.Show("Korisnik uspesno dodat!", "Uspesno Dodavanje");
                    this.Close();
                }
                
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska!");
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
                textBox4.UseSystemPasswordChar = false;
            else if(!checkBox1.Checked)
                textBox4.UseSystemPasswordChar = true;
            else
                textBox4.UseSystemPasswordChar = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^A-Z_a-z]"))
            {
                MessageBox.Show("Molimo vas unesite samo text.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^A-Z_a-z]"))
            {
                MessageBox.Show("Molimo vas unesite samo tekst.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^A-Z_a-z]"))
            {
                MessageBox.Show("Molimo vas unesite samo tekst.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }
    }
}
