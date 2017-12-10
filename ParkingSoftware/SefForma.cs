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
    public partial class SefForma : Form
    {
        public SefForma()
        {
            InitializeComponent();
        }

        private void naloziToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajNalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForma forma = new LoginForma();
            forma.Show();
        }
    }
}
