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
    public partial class triangle : Form
    {
        public triangle()
        {
            InitializeComponent();
            
            
               
            
        }

        private void triangle_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double p = (a + b + c) / 2;
                string S = Convert.ToString(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                textBox4.Text = S;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double p = (a + b + c) / 2;
                string S = Convert.ToString(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
                textBox4.Text = S;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double p = (a + b + c) / 2;
                double S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
                textBox8.Text = p.ToString();
                textBox4.Text = S.ToString();
                double P = (a + b + c);
                textBox5.Text=P.ToString();
                double r=S/p; 
                textBox6.Text=r.ToString();
                double R = a * b * c / S/ 4; 
                textBox7.Text=R.ToString();
                double ha = S/a*2;
                textBox11.Text=ha.ToString();
                double hb = S / b * 2;
                textBox10.Text = hb.ToString();
                double hc = S / c * 2;
                textBox9.Text = hc.ToString();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
