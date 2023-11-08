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
    public partial class Frmtabuada : Form
    {
        public Frmtabuada()
        {
            InitializeComponent();
        }

        private void btncalcular1_Click(object sender, EventArgs e)
        {
            double num1, I, R;
            num1 = Convert.ToDouble(txtnum1.Text);

            I = 1;
            while (I <= 10)
            {
                R = num1 * I;
                txtresult.Text = String.Concat(txtresult.Text+ "\r\n" + num1.ToString() + " X " + I.ToString() + " = " + R.ToString());
                I++;
                
            }
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

        private void btncalcdo11_Click(object sender, EventArgs e)
        {
            double num1, R, I;
            num1 = Convert.ToDouble(txtnum1.Text);

            I = 1;
            do
            {
                R = num1 * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + num1.ToString() + " X " + I.ToString() + " = " + R.ToString());
                I++;
            } while (I <= 10);
        }

        private void btncalcfor11_Click(object sender, EventArgs e)
        {
            double num1, R, I;
            num1 = Convert.ToDouble(txtnum1.Text);

            for (I = 1; I<=10; I++)
            {
                R = num1 * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + num1.ToString() + " X " + I.ToString() + " = " + R.ToString());
            }
        }

        private void Frmtabuada_Load(object sender, EventArgs e)
        {

        }
    }
}
