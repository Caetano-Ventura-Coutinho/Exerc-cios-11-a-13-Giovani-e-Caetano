using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios11a13
{
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progamasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmtabuada tab = new Frmtabuada();
            tab.Show();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmtemp temp = new Frmtemp();
            temp.Show();
        }

        private void áreaDaCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmarea area = new Frmarea();
            area.Show();
        }
    }
}
