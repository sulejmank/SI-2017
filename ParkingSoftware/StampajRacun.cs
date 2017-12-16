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
    public partial class StampajRacun : Form
    {
        public string Tablice { get; set; }
        public DateTime Dolazak { get; set; }
        public Korisnik Radnik { get; set; }
        public decimal cena { get; set; }
        public List<Racun> Smena { get; set; }
        public StampajRacun()
        {
            InitializeComponent();
        }

        private void StampajRacun_Load(object sender, EventArgs e)
        {
            try {
                PostaviRacun();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
            
        }

        public void PostaviRacun()
        {
            try
            {
             
                textBoxTablice.Text = Tablice;
                textBoxVremeDolaska.Text = Dolazak.ToString();
                textBoxVremeOdlaska.Text = DateTime.Now.ToString();

                TimeSpan span = DateTime.Now.Subtract(Dolazak);

                Parking parking = new Parking();

                parking.TrenutnoStanje();


                cena = parking.CenaPoSatu / 60;

                cena *= Decimal.Parse(span.TotalMinutes.ToString());

                textBoxUkupno.Text = cena.ToString("#");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
        }

        private void buttonStampaj_Click(object sender, EventArgs e)
        {
            try {
                Vozilo vozilo = new Vozilo();
                Racun racun = new Racun();

                racun.VremeDolaska = Dolazak;

                racun.Radnik = Radnik;
                racun.Naplata = cena;

                racun.SacuvajRacun();

                vozilo.Tablice = Tablice;
                vozilo.MakniVozilo();



                Naplata forma = new Naplata();

                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }

        }
    }
}
