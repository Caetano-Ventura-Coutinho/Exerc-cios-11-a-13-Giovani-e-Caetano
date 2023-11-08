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
    public partial class Frmtemp : Form
    {
        public Frmtemp()
        {
            InitializeComponent();
        }

        private void lblnum1_Click(object sender, EventArgs e)
        {

        }

        private void Frmtemp_Load(object sender, EventArgs e)
        {

        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmprincipal home = new Frmprincipal();
            home.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtresult.Clear();
            txtnum1.Focus();
        }

        private void btncalcwhile11_Click(object sender, EventArgs e)
        {
            double num1, j, far, I;
            I = 1;
            num1 = Convert.ToDouble(txtnum1.Text);
            far=(num1*1.8)+32;
            j = far;

            while (I <= 11)
            {
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + "Fahreinheit = " + j.ToString());
                j = j + 10;
                I++;
            } 
            
        }

        private void btncalcdo11_Click(object sender, EventArgs e)
        {
            double num1, j, far, I;
            I = 1;
            num1 = Convert.ToDouble(txtnum1.Text);
            far = (num1 * 1.8) + 32;
            j = far;
            do
            {
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + "Fahreinheit = " + j.ToString());
                j = j + 10;
                I++;
            } while (I <= 11);
        }

        private void btncalcfor11_Click(object sender, EventArgs e)
        {
            double num1, j, far, I;
            num1 = Convert.ToDouble(txtnum1.Text);

            far = (num1 * 1.8) + 32;
            j = far;
            for (I = 1; I <= 11; I++)
            {
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + "Fahreinheit = " + j.ToString());
                j = j + 10;
            }
        }
    }
}
