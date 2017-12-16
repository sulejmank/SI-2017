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
    public partial class IzmenaMesta : Form
    {
        public IzmenaMesta()
        {
            InitializeComponent();
            ucitaj();
        }

        public void ucitaj()
        {
            Parking park = new Parking();
            park.TrenutnoStanje();

            textBox1.Text = park.BrojMesta.ToString();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Parking p = new Parking();
            p.BrojMesta = Int32.Parse(textBox1.Text);
            p.promeni_mesta();
            MessageBox.Show("Uspesno ste promenili broj mesta!", "Uspesna izmena");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
