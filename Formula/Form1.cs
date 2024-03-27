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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Триъгълник");
            comboBox1.Items.Add("Правоъгълник");
            comboBox1.Items.Add("Успоредник");
            comboBox1.Items.Add("Квадрат");
            comboBox1.Items.Add("Ромб");
            comboBox1.Items.Add("Трапец");
            comboBox1.Items.Add("Кръг");

        }


            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (comboBox1.SelectedItem.ToString() == "Триъгълник")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Tihomir Petkov\source\repos\Formula\Formula\Properties\images\triangle.png");
                pictureBox1.Size = pictureBox1.Image.Size;
            }

            if (comboBox1.SelectedItem.ToString() == "Квадрат")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Tihomir Petkov\source\repos\Formula\Formula\Properties\images\square.png");
                pictureBox1.Size = pictureBox1.Image.Size;
            }
            if (comboBox1.SelectedItem.ToString() == "Кръг")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Tihomir Petkov\source\repos\Formula\Formula\Properties\images\circle.png");
            }
            if (comboBox1.SelectedItem.ToString() == "Успоредник")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Tihomir Petkov\source\repos\Formula\Formula\Properties\images\parallelogram.png");
            }
            if (comboBox1.SelectedItem.ToString() == "Правоъгълник")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Tihomir Petkov\source\repos\Formula\Formula\Properties\images\rectangle.png");
            }
            if (comboBox1.SelectedItem.ToString() == "Трапец")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Tihomir Petkov\source\repos\Formula\Formula\Properties\images\trapezium.png");
            }
            if (comboBox1.SelectedItem.ToString() == "Ромб")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\Tihomir Petkov\source\repos\Formula\Formula\Properties\images\romb.png");
            }
        }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
            
            }

        private void button1_Click(object sender, EventArgs e)
        {

            triangle form2 = new triangle();
            square form3 = new square();
            rectangle form4 = new rectangle();
            circle form5 = new circle();
            romb form6 = new romb();
            trapezium form7 = new trapezium();
            parallelogram form8 = new parallelogram();
            if (comboBox1.SelectedItem.ToString() == "Триъгълник")
            {
                form2.Show();
            }

            if (comboBox1.SelectedItem.ToString() == "Квадрат")
            {
                form3.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Кръг")
            {
                form5.Show();

            }
            if (comboBox1.SelectedItem.ToString() == "Успоредник")
            {
                form8.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Правоъгълник")
            {
                form4.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Трапец")
            {
                form7.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Ромб")
            {
                form6.Show();
            }

        }
    }
}

