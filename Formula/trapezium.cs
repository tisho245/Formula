using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formula
{
    public partial class trapezium : Form
    {
        public trapezium()
        {
            InitializeComponent();
        }

        private void trapezium_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != ""&&textBox6.Text!=""&&textBox5.Text!="")
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox4.Text);
                double c = double.Parse(textBox6.Text);
                double d = double.Parse(textBox5.Text);
                double S = ((a+c)/4*(a-c)*Math.Sqrt((a+b-c+d)*(a-b-c+d)*(a+b-c-d)*(-a+b+c+d)));
                textBox3.Text = S.ToString();
                double P = a+b+c+d;
                textBox2.Text = P.ToString();
                double h = ((a + b) / 2) * S;
                textBox7.Text = h.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox4.Text);
                double c = double.Parse(textBox6.Text);
                double d = double.Parse(textBox5.Text);
                double S = ((a + c) / 4 * (a - c) * Math.Sqrt((a + b - c + d) * (a - b - c + d) * (a + b - c - d) * (-a + b + c + d)));
                textBox3.Text = S.ToString();
                double P = a + b + c + d;
                textBox2.Text = P.ToString();
                double h = ((a + b) / 2) * S;
                textBox7.Text = h.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox4.Text);
                double c = double.Parse(textBox6.Text);
                double d = double.Parse(textBox5.Text);
                double S = ((a + c) / 4 * (a - c) * Math.Sqrt((a + b - c + d) * (a - b - c + d) * (a + b - c - d) * (-a + b + c + d)));
                textBox3.Text = S.ToString();
                double P = a + b + c + d;
                textBox2.Text = P.ToString();
                double h = ((a + b) / 2) * S;
                textBox7.Text = h.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox4.Text);
                double c = double.Parse(textBox6.Text);
                double d = double.Parse(textBox5.Text);
                double S = ((a + c) / 4 * (a - c) * Math.Sqrt((a + b - c + d) * (a - b - c + d) * (a + b - c - d) * (-a + b + c + d)));
                textBox3.Text = S.ToString();
                double P = a + b + c + d;
                textBox2.Text = P.ToString();
                double h = ((a + b) / 2) * S;
                textBox7.Text = h.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
