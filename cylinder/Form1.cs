using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cylinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double PI = 22 / 7.0;
            int r,h;
            double a, v;
            r = int.Parse(textBox1.Text);
            h = int.Parse(textBox2.Text);
            a = 2 * PI * r * r + 2 * PI * r * h;
            v = PI * r * r * h;
            textBox3.Text = a.ToString();
            textBox4.Text = v.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
