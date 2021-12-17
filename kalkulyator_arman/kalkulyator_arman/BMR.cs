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
    public partial class BMR : Form
    {
        public BMR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rost = Convert.ToInt32(textBox1.Text);
            int ves = Convert.ToInt32(textBox2.Text);
            int vozrast = Convert.ToInt32(textBox3.Text);
            double BMR = 66 + (13.7 x ves) +(5 x rost) -(6.8 x vozrast)
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int rost = Convert.ToInt32(textBox1.Text);
            int ves = Convert.ToInt32(textBox2.Text);
            int BMI = ves / (rost * rost / 100 / 100);
            label8.Text = BMI.ToString();
            trackBar1.Value = Convert.ToInt32(BMI);
        }
    }
}
