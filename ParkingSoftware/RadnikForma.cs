using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSoftware
{
    public partial class RadnikForma : Form
    {
        public Korisnik logRadnik { get; set; }
        public int BrojSlobodnih { get; set; }
        public List<Racun> Smena { get; set; }

        
        public RadnikForma()
        {
           
            InitializeComponent();
            timer1.Start();
    }

        private void RadnikForma_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxRadnik.Text = logRadnik.Ime;
                Parking parking = new Parking();
                Vozilo vozilo = new Vozilo();

                parking.TrenutnoStanje();

                BrojSlobodnih = parking.BrojMesta - vozilo.IzbrojVozila();

                textBoxBrojSlobodnih.Text = BrojSlobodnih.ToString();

                textBoxBrojVozila.Text = vozilo.IzbrojVozila().ToString();
                
            }
            catch (Exception ex)
            {
                if (ex is SystemException             ||
                    ex is OleDbException              ||
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

        private void buttonOdjava_Click(object sender, EventArgs e)
        {
            try {
                this.Close();
                LoginForma forma = new LoginForma();
                forma.Show();
            }
            catch (Exception ex)
            {
                if (ex is SystemException ||
                    ex is OleDbException ||
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("MM-dd-yyyy, HH:mm");
          
        }

        private void buttonDodajVozilo_Click(object sender, EventArgs e)
        {
            DodajVozilo forma = new DodajVozilo();
            forma.ShowDialog();

            try
            {
                textBoxRadnik.Text = logRadnik.Ime;
                Parking parking = new Parking();
                Vozilo vozilo = new Vozilo();

                parking.TrenutnoStanje();

                BrojSlobodnih = parking.BrojMesta - vozilo.IzbrojVozila();

                textBoxBrojSlobodnih.Text = BrojSlobodnih.ToString();

                textBoxBrojVozila.Text = vozilo.IzbrojVozila().ToString();


            }
            catch (Exception ex)
            {
                if (ex is SystemException             ||
                    ex is OleDbException              ||
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

        private void buttonOsvezi_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Naplata naplata = new Naplata();
            naplata.Radnik = logRadnik;


            try
            {
                naplata.ShowDialog();

                textBoxRadnik.Text = logRadnik.Ime;
                Parking parking = new Parking();
                Vozilo vozilo = new Vozilo();

                parking.TrenutnoStanje();

                BrojSlobodnih = parking.BrojMesta - vozilo.IzbrojVozila();

                textBoxBrojSlobodnih.Text = BrojSlobodnih.ToString();

                textBoxBrojVozila.Text = vozilo.IzbrojVozila().ToString();


            }
            catch (Exception ex)
            {
                if (ex is SystemException             ||
                    ex is OleDbException              ||
                    ex is NotSupportedException       ||
                    ex is UnauthorizedAccessException ||
                    ex is FormatException             ||
                    ex is IndexOutOfRangeException    ||
                    ex is InsufficientMemoryException ||
                    ex is EntryPointNotFoundException ||
                    ex is EntryPointNotFoundException ||
                    ex is EvaluateException           ||
                    ex is InvalidCastException        ||
                    ex is AccessViolationException    ||
                    ex is InvalidProgramException)
                    MessageBox.Show(ex.Message, "GRESKA");
                else
                    MessageBox.Show(ex.Message, "GRESKA");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRadnik_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZavrsi_Click(object sender, EventArgs e)
        {
            try
            {
                decimal ukupanSaldo = 0;
                Racun racuni = new Racun();

                Smena = racuni.ZavrsiSmenu(logRadnik.Ime);

                foreach (Racun r in Smena)
                    ukupanSaldo += (decimal)r.Naplata;

                MessageBox.Show("Ukupan Saldo Smene: " + ukupanSaldo.ToString() +
                                "\n" + "Radnik: " + logRadnik.Ime , "Kraj Smene");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
        }
    }
}
