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
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();

            this.AcceptButton = buttonLogin;
            textBoxKorisnickoIme.KeyDown += new KeyEventHandler(tb_keyDown);
        }

        private void tb_keyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Down)
            textBoxLozinka.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try {

                LoginClass log = new LoginClass();
                log.korisnicko_ime = textBoxKorisnickoIme.Text;
                log.lozinka = textBoxLozinka.Text;
                log.proveri_korisnika();

                
                if (log.Uloga == "radnik")
                {
                    RadnikForma forma = new RadnikForma();
                    this.Hide();
                    forma.logRadnik = log;

                    forma.Show();
                    forma.WindowState = FormWindowState.Maximized;
                }
                else if (log.Uloga == "sef" || 
                         log.Uloga == "admin")
                {
                    SefForma forma = new SefForma();
                    this.Hide();

                    forma.Show();
                    forma.WindowState = FormWindowState.Maximized;

                }
                else
                    MessageBox.Show("Neispravno korisnicko ime ili lozinka!","Greska");
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message,"Greska");

            }

        }

        private void LoginForma_KeyPress(object sender, KeyPressEventArgs e)
        {
     
        }
    }
}
