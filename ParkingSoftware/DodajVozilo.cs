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

        private void textBoxTablice_TextChanged(object sender, EventArgs e)
        {
            textBoxTablice.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxTablice.AutoCompleteSource = AutoCompleteSource.CustomSource;


            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            data.Add("NP-");
            data.Add("BG-");
            data.Add("RA-");
            data.Add("TT-");
            data.Add("KG-");
            data.Add("KR-");
            data.Add("NS-");
            data.Add("KM-");


            textBoxTablice.AutoCompleteCustomSource = data;
        }
    }
}
