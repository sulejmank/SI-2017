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
    public partial class Naplata : Form
    {
        List<Vozilo> SvaVozila = new List<Vozilo>();
        public Korisnik Radnik { get; set; }
      
          

        public Naplata()
        {
            InitializeComponent();
            UcitajGrid();
            
        }

        private void Naplata_Load(object sender, EventArgs e)
        {
            

        }

        public void UcitajGrid()
        {
            try
            {
                Vozilo v = new Vozilo();
                SvaVozila = v.SvaVozila();

                foreach (Vozilo x in SvaVozila)
                    dataGridViewVozila.Rows.Add(x.Tablice, x.Dolazak);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska");
            }
            
        }

        private void dataGridViewVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tablice = dataGridViewVozila.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                DateTime dolazak = (DateTime)dataGridViewVozila.Rows[e.RowIndex].Cells[1].Value;

                StampajRacun racun = new StampajRacun();
                racun.Tablice = tablice;
                racun.Dolazak = dolazak;
                racun.Radnik = Radnik;

                racun.ShowDialog();
                dataGridViewVozila.Rows.RemoveAt(e.RowIndex);
                // UcitajGrid();
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message, "Greska");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;


            AutoCompleteStringCollection data = new AutoCompleteStringCollection();


            foreach (Vozilo v in SvaVozila)
                data.Add(v.Tablice);

            textBox1.AutoCompleteCustomSource = data;
        }

        private void buttonPronadji_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                try
                {
                    int br = 0;
                    foreach (Vozilo v in SvaVozila) 
                        if (v.Tablice == textBox1.Text)
                            br++;
         
                    
                       if(br == 1) {

                            Vozilo trazi = new Vozilo();
                            trazi.Tablice = textBox1.Text;


                        if (trazi.PoTablicama())

                        {
                            StampajRacun racun = new StampajRacun();
                            racun.Tablice = trazi.Tablice;
                            racun.Dolazak = trazi.Dolazak;
                            racun.Radnik = Radnik;


                            for (int i = 0; i < dataGridViewVozila.RowCount; i++)
                            {
                                string tablice = dataGridViewVozila.Rows[i].Cells[0].FormattedValue.ToString();
                                if (textBox1.Text == tablice)
                                    dataGridViewVozila.Rows.RemoveAt(i);
                            }
                            

                            racun.ShowDialog();
                            textBox1.Clear();
                            this.Invalidate();
                        }
                        
                        }
                        else
                            MessageBox.Show("Unesite tacne tablice!", "Greska");

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
                        MessageBox.Show(ex.Message, "2reska");
                    else
                        MessageBox.Show(ex.Message, "3reska");
                }
            else
                MessageBox.Show("Unesite tablice!", "4reska");

           
        }

        private void buttonZavrsi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
