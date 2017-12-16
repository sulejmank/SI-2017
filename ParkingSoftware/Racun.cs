using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSoftware
{
   public class Racun
    {
        public DateTime VremeDolaska { get; set; }
        public DateTime VremeOdlaska { get; set; }
        public decimal Naplata { get; set; }
        public Korisnik Radnik { get; set; }
        public string ime { get; set; }

        private OleDbConnection connection = new OleDbConnection();
        public Racun()
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

        public void SacuvajRacun()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "insert into Racun(Dolazak,Odlazak,Naplata,Radnik) values('" + VremeDolaska + "','" + DateTime.Now + "'," + Naplata + ",'" + Radnik.Ime + "');";
                comm.ExecuteNonQuery();

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
                    MessageBox.Show(ex.Message, "aGreska");
                else
                    MessageBox.Show(ex.Message, "sGreska");

                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
              public List<Racun> ZavrsiSmenu(string r)
            {

                     List<Racun> smena = new List<Racun>();
                     List<Racun> s = new List<Racun>();
                     DateTime vreme = DateTime.Now.AddHours(-8);
            try
                {
                        
                     connection.Open();
                     OleDbCommand comm = new OleDbCommand();

                    comm.Connection = connection;
                    comm.CommandText = "select * from Racun where Radnik='" + r + "';";
                    OleDbDataReader reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        Racun racun = new Racun();

                        racun.VremeDolaska =(DateTime) reader["Dolazak"];
                        racun.VremeOdlaska = (DateTime)reader["Odlazak"];
                        racun.Naplata = Decimal.Parse(reader["Naplata"].ToString());
                      //  racun.Radnik.Ime = reader["Radnik"].ToString();

                        s.Add(racun);
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

            foreach (Racun x in s) {
                if (x.VremeOdlaska > vreme)
                    smena.Add(x);
                    }
            return smena;
        }


        public List<Racun> DnevniIzvestaj()
        {
            List<Racun> dnevni = new List<Racun>();

            try
            {

                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "select * from Racun;";

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Racun racun = new Racun();
                  

                    racun.ime = reader["Radnik"].ToString();
                    racun.Naplata = Decimal.Parse(reader["Naplata"].ToString());
                    racun.VremeOdlaska =(DateTime) reader["Odlazak"];

                    if(racun.VremeOdlaska >= DateTime.Now.AddDays(-1))
                         dnevni.Add(racun);
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

            return dnevni;

        }

        public List<Racun> MesecniIzvestaj()
        {
            List<Racun> mesecni = new List<Racun>();

            try
            {

                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "select * from Racun;";

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Racun racun = new Racun();


                    racun.ime = reader["Radnik"].ToString();
                    racun.Naplata = Decimal.Parse(reader["Naplata"].ToString());
                    racun.VremeOdlaska = (DateTime)reader["Odlazak"];

                    if (racun.VremeOdlaska >= DateTime.Now.AddDays(-30))
                        mesecni.Add(racun);
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

            return mesecni;

        }
    }
}
