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
    public partial class Frmarea : Form
    {
        public Frmarea()
        {
            InitializeComponent();
        }
        double areatotal;
        private void btnvoltaarea_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmprincipal principal = new Frmprincipal();
            principal.Show();

        }

        private void btncalcarea_Click(object sender, EventArgs e)
        {
            double larg, comp, area;
            string nomecom;

            larg = Convert.ToDouble(txtlarg.Text);
            comp = Convert.ToDouble(txtcomp.Text);
            nomecom = txtnomecom.Text;

            area = larg * comp;
            txtarea.Text = String.Concat (txtarea.Text + "\r\n" + nomecom.ToString() + " mede " + area.ToString() + " m².");
            areatotal += area;

            var result = MessageBox.Show("Deseja continuar calculando?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                txtlarg.Clear();
                txtcomp.Clear();
                txtnomecom.Clear();
            }
            else
            {
                txtlarg.Clear();
                txtcomp.Clear();
                txtnomecom.Clear();
                lblareatotal.Visible = true;
                txtareatotal.Visible = true;
                txtareatotal.Text = "O imóvel mede " + areatotal.ToString() + " m².";
                
            }
        }

        private void btnlimpararea_Click(object sender, EventArgs e)
        {
            txtarea.Clear();
            txtareatotal.Clear();
            lblareatotal.Visible = false;
            txtareatotal.Visible = false;
            areatotal = 0;
        }
    }
}
