using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painty
{
    public partial class Form1 : Form
    {
        bool Draw;
        Pen one_pen = new Pen(Brushes.Black, 6);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Draw == true) 
            {
                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.DrawEllipse(one_pen, e.X, e.Y, 0, one_pen.Width);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Draw = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Draw = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            one_pen = new Pen(Brushes.Red);
            one_pen.Width = 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            one_pen = new Pen(Brushes.Blue);
            one_pen.Width = 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            one_pen = new Pen(Brushes.Green);
            one_pen.Width = 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            one_pen = new Pen(Brushes.Black);
            one_pen.Width = 6;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(SystemColors.Window);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(SystemColors.Window);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            float i = one_pen.Width;
            one_pen.Width = i + 2;
            textBox1.Text = Convert.ToString(one_pen.Width);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            float i = one_pen.Width;
            one_pen.Width = i - 2;
            textBox1.Text = Convert.ToString(one_pen.Width);
        }

    }
}
