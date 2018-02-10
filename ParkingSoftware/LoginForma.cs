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
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();

            this.AcceptButton = buttonLogin;
            textBoxKorisnickoIme.KeyDown += new KeyEventHandler(tb_keyDown);
            textBoxLozinka.KeyDown += new KeyEventHandler(tb_keyDown);


        }

        private void tb_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                textBoxLozinka.Focus();
            else if (e.KeyCode == Keys.Up)
                textBoxKorisnickoIme.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try {

                var pass = textBoxLozinka.Text;
                var md5 = new MD5CryptoServiceProvider();
                var data = Encoding.ASCII.GetBytes(pass);

                var hash_pass = md5.ComputeHash(data);

                Korisnik log = new Korisnik();
                log.korisnicko_ime = textBoxKorisnickoIme.Text;
                log.lozinka = Convert.ToBase64String(hash_pass);
                log.proveri_korisnika();


                if (log.Uloga == "radnik" || 
                    log.Uloga == "Radnik")
                {
                    RadnikForma forma = new RadnikForma();
                    this.Hide();
                    forma.logRadnik = log;

                    forma.Show();
                    forma.WindowState = FormWindowState.Maximized;
                }
                else if (log.Uloga == "Sef"   ||
                         log.Uloga == "admin" ||
                         log.Uloga == "Admin")
                {
                    SefForma forma = new SefForma();
                    this.Hide();
                    forma.Show();
                    forma.logSef = log;
                    forma.WindowState = FormWindowState.Maximized;

                }
                else
                {
                    textBoxKorisnickoIme.Clear();
                    textBoxLozinka.Clear();
                    MessageBox.Show("Neispravno korisnicko ime ili lozinka!", "Greska");
                }
            }
            catch (Exception ex)
            {
                if (ex is SystemException             ||
                    ex is NotSupportedException       ||
                    ex is UnauthorizedAccessException ||
                    ex is FormatException             ||
                    ex is IndexOutOfRangeException    ||
                    ex is InsufficientMemoryException ||
                    ex is EntryPointNotFoundException ||
                    ex is EntryPointNotFoundException ||
                    ex is EvaluateException           ||
                    ex is InvalidCastException        ||
                    ex is InvalidProgramException)
                    MessageBox.Show(ex.Message, "Greska");
                else
                    MessageBox.Show(ex.Message, "Greska");
            }

        }
       
        private void LoginForma_KeyPress(object sender, KeyPressEventArgs e)
        {
     
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBoxLozinka.UseSystemPasswordChar = false;
            else if (!checkBox1.Checked)
                textBoxLozinka.UseSystemPasswordChar = true;
            else
                textBoxLozinka.UseSystemPasswordChar = true;
        }

        private void textBoxKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxKorisnickoIme.Text, "[^A-Z,a-z,0-9]"))
            {
                MessageBox.Show("Molimo vas unesite samo tekst i brojeve.");
                textBoxKorisnickoIme.Text = textBoxKorisnickoIme.Text.Remove(textBoxKorisnickoIme.Text.Length - 1);
            }
        }
    }
}
