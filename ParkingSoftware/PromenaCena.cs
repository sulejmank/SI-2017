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
    public partial class PromenaCena : Form
    {
        public PromenaCena()
        {
            InitializeComponent();
            ucitaj();
        }

        public void ucitaj()
        {
            Parking park = new Parking();
            park.TrenutnoStanje();

            textBox1.Text = park.CenaPoSatu.ToString();
            textBox2.Text = park.CenaPoDanu.ToString();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Parking p = new Parking();
            p.CenaPoSatu = Decimal.Parse(textBox1.Text);
            p.CenaPoDanu = Decimal.Parse(textBox2.Text);
            p.promeni_cene();

            MessageBox.Show("Uspesno ste promenili cene!", "Uspesna izmena");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
