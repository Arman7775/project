using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulyator_arman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float rost = Convert.ToInt32(textBox1.Text);
            float ves = Convert.ToInt32(textBox2.Text);
            float BMI = ves / (rost * rost / 100 / 100);
            label8.Text = BMI.ToString();
            trackBar1.Value = Convert.ToInt32(BMI);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox2.Image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox1.Image;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
