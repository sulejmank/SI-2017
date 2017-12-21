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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Molimo vas unesite samo brojeve.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Molimo vas unesite samo brojeve.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }
    }
}
