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
    public partial class square : Form
    {
        public square()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                double a = double.Parse(textBox1.Text);
                double S = a * a;
                textBox3.Text=S.ToString();
                double P = 4 * a;
                textBox2.Text = P.ToString();
                double d=a*Math.Sqrt(2);
                textBox4.Text=d.ToString();
                double R=a/Math.Sqrt(2);
                textBox6.Text = R.ToString();
                double r = a / 2;
                textBox5.Text = r.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
