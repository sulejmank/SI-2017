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
    public partial class Uvid : Form
    {
        List<Racun> dnevni_izvestaj = new List<Racun>();

        List<Racun> mesecni_izvestaj = new List<Racun>();

        public Uvid()
        {
            InitializeComponent();
            UcitajDnevniGrid();
            UcitajMesecniGrid();
        }

        public void UcitajDnevniGrid()
        {
            try
            {
                decimal suma = 0;
                Racun v = new Racun();
                dnevni_izvestaj = v.DnevniIzvestaj();

                foreach (Racun x in dnevni_izvestaj)
                {
                    dataGridViewVozila.Rows.Add(x.VremeOdlaska, x.Naplata, x.ime);
                    suma += x.Naplata;
                }
                labUkupnoDan.Text = suma.ToString("#");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }

        }

        public void UcitajMesecniGrid()
        {
            try
            {
                decimal suma = 0;
                Racun v = new Racun();
                mesecni_izvestaj = v.MesecniIzvestaj();

                foreach (Racun x in mesecni_izvestaj)
                {
                    dataGridView1.Rows.Add(x.VremeOdlaska, x.Naplata, x.ime);
                    suma += x.Naplata;
                }
                labelUkuonoMesec.Text = suma.ToString("#");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }

        }

        private void buttonZavrsi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Uvid_Load(object sender, EventArgs e)
        {

        }
    }
}
