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
    public partial class IzbrisiKorisnika : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        public IzbrisiKorisnika()
        {
            InitializeComponent();
            ucitaj_list();
        }

        public void ucitaj_list()
        {
            try
            {
                Korisnik korisnik = new Korisnik();

                korisnici = korisnik.izlistaj_korisnike();

                foreach (Korisnik x in korisnici)
                    listBox1.Items.Add(x.Ime);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = listBox1.SelectedItem.ToString();

            DialogResult dialog = MessageBox.Show("Jeste li sigurni?", "Brisanje Korisnika", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                foreach (Korisnik x in korisnici)
                    if (x.Ime == ime)
                        x.izbrisi_korisnika();

             else
                 this.Close();
        }
    }
}
