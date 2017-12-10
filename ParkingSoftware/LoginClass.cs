using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSoftware
{
    public class LoginClass
    {
        public string korisnicko_ime { get; set; }
        public string lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Uloga { get; set; }


        private OleDbConnection connection = new OleDbConnection();
          
     
        public LoginClass()
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
            catch(OleDbException e){

                MessageBox.Show(e.ToString());

                if (connection != null)
                    connection.Close();
             
            }

        }

    }
}
