using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Guia2_MM200149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valora, valorb, valorc, x1, x2, formula;

            valora = Convert.ToDouble(txtA.Text);
            valorb = Convert.ToDouble(txtB.Text);
            valorc = Convert.ToDouble(txtC.Text);
            formula = valorb * valorb - 4.0 * valora * valorc;

            if(formula < 0)
            {
                MessageBox.Show("El resultado es Imaginario");
            }
            
            else
            {
                x1 = (-valorb + Math.Sqrt(formula)) / (2 * valora);
                txtrespuesta1.Text = x1.ToString();
                x2 = (-valorb - Math.Sqrt(formula)) / (2 * valora);
                txtrespuesta2.Text = x2.ToString();
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtrespuesta1.Enabled = false;
            txtrespuesta2.Enabled = false;
        }
    }
}
