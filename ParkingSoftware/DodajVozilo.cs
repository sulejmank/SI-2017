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
    public partial class DodajVozilo : Form
    {
        public DodajVozilo()
        {
            InitializeComponent();
            this.AcceptButton = buttonDodajVozilo;
        }

        private void buttonDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                Vozilo vozilo = new Vozilo();

                vozilo.Tablice = textBoxTablice.Text;
                vozilo.DodajVozilo();

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
