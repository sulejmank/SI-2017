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
    public partial class Smena : Form
    {
        public decimal saldo { get; set; }
        public string rad { get; set; }
        public Smena()
        {
            InitializeComponent();
         
        }

        private void Smena_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";

            label3.Text = saldo.ToString();
            label4.Text = rad;
        }

        private void buttonZavrsi_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
