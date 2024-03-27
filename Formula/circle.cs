using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula
{
    public partial class circle : Form
    {
        public circle()
        {
            InitializeComponent();
        }

        private void circle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double r= double.Parse(textBox1.Text);
            double P= Math.PI*r;
            textBox5.Text=P.ToString();
            double S = Math.PI * r*r;
            textBox3.Text = S.ToString();
            double d = 2 * r;
            textBox4.Text = d.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
