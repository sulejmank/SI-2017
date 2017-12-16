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
    public partial class SefForma : Form
    {
       public Korisnik logSef { get; set; }
        public SefForma()
        {
            InitializeComponent();

        }

       
        private void naloziToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForma forma = new LoginForma();
            forma.Show();
        }

        private void SefForma_Load(object sender, EventArgs e)
        {
            labelIme.Text = logSef.Ime;
        }

        private void uvidUPoslovanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //todo
            Uvid uv = new Uvid();
            uv.Show();
        }

        private void trenutnoStanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Parking parking = new Parking();
                Vozilo vozilo = new Vozilo();

                parking.TrenutnoStanje();

               int BrojSlobodnih = parking.BrojMesta - vozilo.IzbrojVozila();

                textBoxBrojSlobodnih.Text = BrojSlobodnih.ToString();

                textBoxBrojVozila.Text = vozilo.IzbrojVozila().ToString();

                label2.Visible = true;
                label3.Visible = true;

                textBoxBrojSlobodnih.Visible = true;
                textBoxBrojVozila.Visible = true;

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

        private void dodajNalogToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DodajKorisnika forma = new DodajKorisnika();
            forma.ShowDialog();
        }

        private void izmeniNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzmeniKorisnika forma = new IzmeniKorisnika();
            forma.ShowDialog();
        }

        private void SefForma_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Control && e.KeyCode == Keys.P)
            {
                Uvid uv = new Uvid();
                uv.Show();
            }
            else if (e.KeyCode == Keys.Control && e.KeyCode == Keys.T)
            {
                try
                {
                    Parking parking = new Parking();
                    Vozilo vozilo = new Vozilo();

                    parking.TrenutnoStanje();

                    int BrojSlobodnih = parking.BrojMesta - vozilo.IzbrojVozila();

                    textBoxBrojSlobodnih.Text = BrojSlobodnih.ToString();

                    textBoxBrojVozila.Text = vozilo.IzbrojVozila().ToString();

                    label2.Visible = true;
                    label3.Visible = true;

                    textBoxBrojSlobodnih.Visible = true;
                    textBoxBrojVozila.Visible = true;

                }
                catch (Exception ex)
                {
                    if (ex is SystemException ||
                        ex is NotSupportedException ||
                        ex is UnauthorizedAccessException ||
                        ex is FormatException ||
                        ex is IndexOutOfRangeException ||
                        ex is InsufficientMemoryException ||
                        ex is EntryPointNotFoundException ||
                        ex is EntryPointNotFoundException ||
                        ex is EvaluateException ||
                        ex is InvalidCastException ||
                        ex is InvalidProgramException)
                        MessageBox.Show(ex.Message, "Greska");
                    else
                        MessageBox.Show(ex.Message, "Greska");
                }
            }

        }

        private void obrišiNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzbrisiKorisnika forma = new IzbrisiKorisnika();
            forma.ShowDialog();

        }

        private void izmeniCeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromenaCena prom = new PromenaCena();
            prom.ShowDialog();
        }

        private void izmeniBrojMestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzmenaMesta zime = new IzmenaMesta();
            zime.ShowDialog();
        }
    }
}
