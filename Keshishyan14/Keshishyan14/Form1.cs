using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keshishyan14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked) 
            { int oplata = t * 500; textBox2.Text = Convert.ToString(oplata); }
            else if (radioButton2.Checked)
            { int oplata = t * 200; textBox2.Text = Convert.ToString(oplata); }
           


        }
    }
}
