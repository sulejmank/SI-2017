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
    public partial class RadnikForma : Form
    {
        public LoginClass logRadnik { get; set; }
        public RadnikForma()
        {
           
            InitializeComponent();
            timer1.Start();
            
            // textBoxRadnik.Text = logRadnik.Ime.ToString();
        //     MessageBox.Show(logRadnik.korisnicko_ime);
       
    }

        private void RadnikForma_Load(object sender, EventArgs e)
        {

        }

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            try {
                this.Hide();
                LoginForma forma = new LoginForma();
                forma.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }
    }
}
