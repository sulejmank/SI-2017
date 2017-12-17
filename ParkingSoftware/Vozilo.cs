using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSoftware
{
   public class Vozilo
    {
        public string Tablice { get; set; }
        public DateTime Dolazak { get; set; }
        public int BrojVozila { get; set; }
     

        private OleDbConnection connection = new OleDbConnection();
        public Vozilo()
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=ParkingSoftDB.accdb; Persist Security Info=False;";
                connection.Open();
                connection.Close();

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
                    ex is InvalidCastException        ||
                    ex is InvalidProgramException)
                    MessageBox.Show(ex.Message, "Greska");
                else
                    MessageBox.Show(ex.Message, "Greska");
            }

        }

        public void DodajVozilo()
        {

            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "insert into Vozilo(Tablice,Dolazak) values('" + Tablice + "','" + DateTime.Now + "');";

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

        public List<Vozilo> SvaVozila()
        {
            List<Vozilo> Sva_Vozila = new List<Vozilo>();
            
            try
            {
                
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "select * from Vozilo;";

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Vozilo vozilo = new Vozilo();

                    vozilo.Tablice = reader["Tablice"].ToString();
                    vozilo.Dolazak = (DateTime)reader["Dolazak"];

                    Sva_Vozila.Add(vozilo);
                }

                connection.Close();

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
                    ex is InvalidCastException        ||
                    ex is InvalidProgramException)
                    MessageBox.Show(ex.Message, "Greska");
                else
                    MessageBox.Show(ex.Message, "Greska");
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return Sva_Vozila;

        }

        public int IzbrojVozila()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "select count (*) from Vozilo";

                BrojVozila = (Int32)comm.ExecuteScalar();


                connection.Close();

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
                    ex is InvalidCastException        ||
                    ex is InvalidProgramException)
                    MessageBox.Show(ex.Message, "Greska");
                else
                    MessageBox.Show(ex.Message, "Greska");

                if (connection != null)
                {
                    connection.Close();
                }
            }

            return BrojVozila;

        }

        public void MakniVozilo()
        {

            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "delete from Vozilo where Tablice='" + Tablice + "';";

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

        public bool PoTablicama()
        {
            bool a = true;

            try
            {

                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "select * from Vozilo where Tablice='" + Tablice + "';";
                

                OleDbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                        Dolazak = (DateTime)reader["Dolazak"];

                    else
                        a = false;


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
            return a;
        }
    }
}
