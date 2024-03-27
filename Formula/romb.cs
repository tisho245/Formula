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
    public partial class romb : Form
    {
        public romb()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox8.Text!=""&&textBox6.Text!="")
            {
                double a = double.Parse(textBox1.Text);
                double a_ = double.Parse(textBox8.Text);
                double b_ = double.Parse(textBox6.Text);
                double S = a*a*Math.Sin(a_);
                textBox3.Text = S.ToString();
                double P = 4 * a;
                textBox2.Text = P.ToString();
                double e1 = 2*a*Math.Cos(a_/2)*Math.Sin(b_/2);
                textBox4.Text = e1.ToString();
                double f1 = 2 * a * Math.Sin(a_ / 2) * Math.Cos(b_ / 2);
                textBox9.Text = f1.ToString();
                double r = 0.5*a*Math.Sin(a_);
                textBox5.Text = r.ToString();
                double h = S / a;
                textBox7.Text = h.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox8.Text != "" && textBox6.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double a_ = double.Parse(textBox8.Text);
                double b_ = double.Parse(textBox6.Text);
                double S = a * a * Math.Sin(a_);
                textBox3.Text = S.ToString();
                double P = 4 * a;
                textBox2.Text = P.ToString();
                double e1 = 2 * a * Math.Cos(a_ / 2) * Math.Sin(b_ / 2);
                textBox4.Text = e1.ToString();
                double f1 = 2 * a * Math.Sin(a_ / 2) * Math.Cos(b_ / 2);
                textBox9.Text = f1.ToString();
                double r = 0.5 * a * Math.Sin(a_);
                textBox5.Text = r.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox8.Text != "" && textBox6.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double a_ = double.Parse(textBox8.Text);
                double b_ = double.Parse(textBox6.Text);
                double S = a * a * Math.Sin(a_);
                textBox3.Text = S.ToString();
                double P = 4 * a;
                textBox2.Text = P.ToString();
                double e1 = 2 * a * Math.Cos(a_ / 2) * Math.Sin(b_ / 2);
                textBox4.Text = e1.ToString();
                double f1 = 2 * a * Math.Sin(a_ / 2) * Math.Cos(b_ / 2);
                textBox9.Text = f1.ToString();
                double r = 0.5 * a * Math.Sin(a_);
                textBox5.Text = r.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void romb_Load(object sender, EventArgs e)
        {

        }
    }
}
