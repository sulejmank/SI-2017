using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


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
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/yyyy";
            dateTimePicker2.ShowUpDown = true;
        }

        public void UcitajDnevniGrid()
        {
            try
            {
                labUkupnoDan.Text = "0";
                
                dataGridViewVozila.Rows.Clear();
                decimal suma = 0;
                Racun v = new Racun();
                dnevni_izvestaj = v.DnevniIzvestaj();

                DateTime vreme = dateTimePicker1.Value;

                foreach (Racun x in dnevni_izvestaj)
                {
                    if (x.VremeOdlaska.Day == vreme.Day && 
                        x.VremeOdlaska.Month == vreme.Month &&
                        x.VremeOdlaska.Year == vreme.Year)
                    {
                        TimeSpan span = x.VremeOdlaska.Subtract(x.VremeDolaska);
                        dataGridViewVozila.Rows.Add(x.VremeOdlaska, x.Naplata, x.ime,span.TotalMinutes.ToString("#"));
                        suma += x.Naplata;
                    }
                }
                labUkupnoDan.Text = suma.ToString("#");
                dataGridViewVozila.Sort(dataGridViewVozila.Columns[0], ListSortDirection.Descending);
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
                labelUkuonoMesec.Text = "0";
                dataGridView1.Rows.Clear();

                decimal suma = 0;
                Racun v = new Racun();
                mesecni_izvestaj = v.DnevniIzvestaj();
                
                foreach (Racun x in mesecni_izvestaj)
                {
                    if (x.VremeOdlaska.Month == dateTimePicker2.Value.Month &&
                        x.VremeOdlaska.Year == dateTimePicker2.Value.Year)
                    {
                        TimeSpan span = x.VremeOdlaska.Subtract(x.VremeDolaska);
                        dataGridView1.Rows.Add(x.VremeOdlaska, x.Naplata, x.ime, span.TotalMinutes.ToString("#"));
                        suma += x.Naplata;
                    }
                }
                labelUkuonoMesec.Text = suma.ToString("#");

                dataGridView1.Sort(dataGridView1.Columns[0] , ListSortDirection.Descending );
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UcitajDnevniGrid();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UcitajMesecniGrid();
        }

        private void dataGridViewVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       public void Export_Data_To_Word(DataGridView DGV, string filename, string ukupno, string dat)
    {
        if (DGV.Rows.Count != 0)
        {
            int RowCount = DGV.Rows.Count;
            int ColumnCount = DGV.Columns.Count;
            Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

            //add rows
            int r = 0;
            for (int c = 0; c <= ColumnCount - 1; c++)
            {
                for (r = 0; r <= RowCount - 1; r++)
                {
                    DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                } //end row loop
            } //end column loop

            Word.Document oDoc = new Word.Document();
           // oDoc.Application.Visible = true;

            //page orintation
            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


            dynamic oRange = oDoc.Content.Application.Selection.Range;
            string oTemp = "";
            for (r = 0; r <= RowCount - 1; r++)
            {
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oTemp = oTemp + DataArray[r, c] + "\t";

                }
            }

            //table format
            oRange.Text = oTemp;

             

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
            object ApplyBorders = true;
            object AutoFit = true;
            object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

            oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                  Type.Missing, Type.Missing, ref ApplyBorders,
                                  Type.Missing, Type.Missing, Type.Missing,
                                  Type.Missing, Type.Missing, Type.Missing,
                                  Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

            oRange.Select();

            oDoc.Application.Selection.Tables[1].Select();
            oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
            oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
            oDoc.Application.Selection.Tables[1].Rows[1].Select();
            oDoc.Application.Selection.InsertRowsAbove(1);
            oDoc.Application.Selection.Tables[1].Rows[1].Select();

            oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
            oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
            oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

            
            oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
            oDoc.Application.Selection.Tables[1].Rows[1].Select();
            oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

            foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
            {
                Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                headerRange.Text = "Izvestaj za " + dat;
                
                headerRange.Font.Size = 16;
                headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                
            }

           oDoc.SaveAs(filename);

        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string dat = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "Dnevni_izvestaj_za_"+dat+".docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try {
                    Thread nit = new Thread(() => Export_Data_To_Word(dataGridViewVozila, sfd.FileName, labUkupnoDan.Text, dat));
                    nit.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greska");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string dat = dateTimePicker2.Value.ToString("MM-yyyy");
            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "Mesecni_izvestaj_za_" + dat + ".docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try {
                    Thread nit = new Thread(() => Export_Data_To_Word(dataGridView1, sfd.FileName, labelUkuonoMesec.Text, dat));
                    nit.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greska");

                }
            }
        }
    }
}
