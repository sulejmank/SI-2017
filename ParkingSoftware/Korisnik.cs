using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSoftware
{
    public class Korisnik
    {
        public string korisnicko_ime { get; set; }
        public string lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Uloga { get; set; }
        public int id { get; set; }


        private OleDbConnection connection = new OleDbConnection();


        public Korisnik()
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=ParkingSoftDB.accdb; Persist Security Info=False;";
                connection.Open();
                connection.Close();

            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.ToString());

                if (connection != null)
                    connection.Close();

            }

        }

        public void proveri_korisnika()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "select * from Nalog where korisnicko_ime='" + korisnicko_ime + "' and sifra='" + lozinka + "';";

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Ime = reader["ime"].ToString();
                    Prezime = reader["prezime"].ToString();
                    Uloga = reader["uloga"].ToString();
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
            }

        }

        public void dodaj_korisnika()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();

                comm.Connection = connection;
                comm.CommandText = "insert into Nalog(korisnicko_ime,sifra,ime,prezime,uloga) values('" + korisnicko_ime
                                                                                                       + "','" + lozinka + "','" + Ime +
                                                                                                       "','" + Prezime + "','" + Uloga + "');";
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
                    MessageBox.Show(ex.Message, "Greska");
                else
                    MessageBox.Show(ex.Message, "Greska");
            }

        }


        public List<Korisnik> izlistaj_korisnike()
        {
            List<Korisnik> lista = new List<Korisnik>();
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;

                comm.CommandText = "select * from Nalog;";

                OleDbDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    Korisnik kor = new Korisnik();

                    kor.korisnicko_ime = reader["korisnicko_ime"].ToString();
                    kor.Ime = reader["ime"].ToString();
                    kor.Prezime = reader["prezime"].ToString();
                    kor.Uloga = reader["uloga"].ToString();
                    kor.id = (int)reader["ID"];

                    lista.Add(kor);

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
            }

            return lista;

        }

        public void izmeni_korisnika()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;

                comm.CommandText = "update Nalog set korisnicko_ime='" + korisnicko_ime + "',sifra='" + lozinka + "',ime='" + Ime + "',prezime='" + Prezime + "',uloga='" + Uloga + "' where id=" + id + ";";
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
                    MessageBox.Show(ex.Message, "Greska");
                else
                    MessageBox.Show(ex.Message, "Greska");
            }

        }

        public void izbrisi_korisnika()
        {
            try
            {
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;

                comm.CommandText = "delete from Nalog where ID="+ id+";";
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
                    MessageBox.Show(ex.Message, "Greska");
                else
                    MessageBox.Show(ex.Message, "Greska");
            }

        }


    }
}
