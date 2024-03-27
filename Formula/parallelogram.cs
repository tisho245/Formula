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
    public partial class parallelogram : Form
    {
        public parallelogram()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox4.Text);
                double a_ = double.Parse(textBox6.Text);
                double b_ = double.Parse(textBox5.Text);
                double S = a*b*Math.Sin(a_);
                textBox3.Text = S.ToString();
                double P = 2*a+2*b;
                textBox2.Text = P.ToString();
                double h1 = b * Math.Sin(b_); 
                textBox10.Text= h1.ToString();
                double h2 = a*Math.Sin(b_);
                textBox9.Text = h2.ToString();
                double Da = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(a_));
                textBox7.Text = Da.ToString();
                double Db = Math.Sqrt(a * a + b * b + 2 * a * b * Math.Cos(a_));
                textBox8.Text = Db.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox4.Text);
                double a_ = double.Parse(textBox6.Text);
                double b_ = double.Parse(textBox5.Text);
                double S = a * b * Math.Sin(a_);
                textBox3.Text = S.ToString();
                double P = 2 * a + 2 * b;
                textBox2.Text = P.ToString();
                double h1 = b * Math.Sin(b_);
                textBox10.Text = h1.ToString();
                double h2 = a * Math.Sin(b_);
                textBox9.Text = h2.ToString();
                double Da = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(a_));
                textBox7.Text = Da.ToString();
                double Db = Math.Sqrt(a * a + b * b + 2 * a * b * Math.Cos(a_));
                textBox8.Text = Db.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox4.Text);
                double a_ = double.Parse(textBox6.Text);
                double b_ = double.Parse(textBox5.Text);
                double S = a * b * Math.Sin(a_);
                textBox3.Text = S.ToString();
                double P = 2 * a + 2 * b;
                textBox2.Text = P.ToString();
                double h1 = b * Math.Sin(b_);
                textBox10.Text = h1.ToString();
                double h2 = a * Math.Sin(b_);
                textBox9.Text = h2.ToString();
                double Da = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(a_));
                textBox7.Text = Da.ToString();
                double Db = Math.Sqrt(a * a + b * b + 2 * a * b * Math.Cos(a_));
                textBox8.Text = Db.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox4.Text);
                double a_ = double.Parse(textBox6.Text);
                double b_ = double.Parse(textBox5.Text);
                double S = a * b * Math.Sin(a_);
                textBox3.Text = S.ToString();
                double P = 2 * a + 2 * b;
                textBox2.Text = P.ToString();
                double h1 = b * Math.Sin(b_);
                textBox10.Text = h1.ToString();
                double h2 = a * Math.Sin(b_);
                textBox9.Text = h2.ToString();
                double Da = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(a_));
                textBox7.Text = Da.ToString();
                double Db = Math.Sqrt(a * a + b * b + 2 * a * b * Math.Cos(a_));
                textBox8.Text = Db.ToString();
            }
        }
    }
}
