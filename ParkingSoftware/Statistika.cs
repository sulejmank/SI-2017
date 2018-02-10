using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace ParkingSoftware
{
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
            ucitaj_graf();
            ucitaj_pie();
        }

        private void solidGauge1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Statistika_Load(object sender, EventArgs e)
        {

        }
        private void ucitaj_graf()
        {
            Racun rac = new Racun();
            List<Racun> ls = new List<Racun>();

            ls = rac.DnevniIzvestaj();
            int Jan = 0;
            int Feb = 0;
            int Mar = 0;
            int Apr = 0;
            int Jun = 0;
            int May = 0;
            int Avg = 0;
            int Jul = 0;
            int Sept = 0;
            int Okt = 0;
            int Nov = 0;
            int Dec = 0;

            Korisnik koris = new Korisnik();

            List<Korisnik> kor = new List<Korisnik>();
            kor = koris.izlistaj_korisnike();

            foreach (Racun r in ls)
            {
                if (r.VremeDolaska.Month == 1)
                {
                    Jan++;
                }
                if (r.VremeDolaska.Month == 2)
                {
                    Feb++;
                }
                if (r.VremeDolaska.Month == 3)
                {
                    Mar++;
                }
                if (r.VremeDolaska.Month == 4)
                {
                    Apr++;
                }
                if (r.VremeDolaska.Month == 5)
                {
                    May++;
                }
                if (r.VremeDolaska.Month == 6)
                {
                    Jun++;
                }
                if (r.VremeDolaska.Month == 7)
                {
                    Jul++;
                }
                if (r.VremeDolaska.Month == 8)
                {
                    Avg++;
                }
                if (r.VremeDolaska.Month == 9)
                {
                    Sept++;
                }
                if (r.VremeDolaska.Month == 10)
                {
                    Okt++;
                }
                if (r.VremeDolaska.Month == 11)
                {
                    Nov++;
                }
                if (r.VremeDolaska.Month == 12)
                {
                    Dec++;
                }

            }
            cartesianChart1.Series = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "Broj racuna",
                    Values = new ChartValues<int> {Jan,Feb,Mar,Apr,May,Jun,Jul,Avg,Sept,Okt,Nov,Dec},
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Mesec",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "Maj", "Jun", "Jul", "Avgust", "Septembar", "Oktobar", "Novembar", "Decembar" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Prodaja",
                LabelFormatter = value => value.ToString()
            });

            cartesianChart1.LegendLocation = LegendLocation.Bottom;

        }

        private void ucitaj_pie()
        {



            List<Korisnik> korisnici = new List<Korisnik>();
            Korisnik kor = new Korisnik();

            korisnici = kor.izlistaj_korisnike();

            Racun rac = new Racun();
            List<Racun> racuni = new List<Racun>();
            racuni = rac.DnevniIzvestaj();


            int br = 0;


            Func<ChartPoint, string> labelPoint = chartPoint =>
                 string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);


            pieChart1.Series = new SeriesCollection
            { };




            foreach (Korisnik k in korisnici)
            {

                foreach (Racun r in racuni)
                    if (r.ime == k.Ime)
                        br++;


                pieChart1.Series.Add(
                new PieSeries
                {
                    Title = k.Ime,
                    Values = new ChartValues<int> { br },
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint

                }
                );
                br = 0;


            }
        
        

            


            pieChart1.LegendLocation = LegendLocation.Right;
        }

        private void buttonZavrsi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    
    

