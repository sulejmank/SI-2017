using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSoftware
{
    public class Parking
    {
        public int BrojMesta { get; set; }
        public decimal CenaPoSatu { get; set; }
        public decimal CenaPoDanu { get; set; }
        //public int BrojZauzetihMesta { get; set; }

        public string naziv { get; set; }
        public string adresa { get; set; }


        private OleDbConnection connection = new OleDbConnection();



        public Parking()
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=ParkingSoftDB.accdb; Persist Security Info=False;";
                connection.Open();
                connection.Close();

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




        public void TrenutnoStanje()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "select * from Parking Where ID=1;";

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    BrojMesta = Int32.Parse(reader["BrojMesta"].ToString());
                    CenaPoSatu = Decimal.Parse(reader["CenaPoSatu"].ToString());
                    CenaPoDanu = Decimal.Parse(reader["CenaPoDanu"].ToString());
                    naziv = (string)reader["Naziv"].ToString();
                    adresa = (string)reader["Adresa"].ToString();
                    //  BrojZauzetihMesta = Int32.Parse(reader["BrojZauzetih"].ToString());
                }

                connection.Close();

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
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }



        public void promeni_cene()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "update Parking set CenaPoSatu=" + CenaPoSatu + ", CenaPoDanu=" + CenaPoDanu + " Where ID=1;";

                comm.ExecuteNonQuery();

                connection.Close();

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
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void promeni_detalje()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "update Parking set Naziv='" + naziv + "', Adresa='" + adresa + "' Where ID=1;";

                comm.ExecuteNonQuery();

                connection.Close();

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
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        public void promeni_mesta()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "update Parking set BrojMesta=" + BrojMesta + " Where ID=1;";

                comm.ExecuteNonQuery();

                connection.Close();

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
                if (connection != null)
                {
                    connection.Close();
                }
            }


        }




    }



}
