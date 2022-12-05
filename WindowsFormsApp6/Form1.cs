using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool a = false, b = false;
        private void button1_Click(object sender, EventArgs e)
        {
            int hc=1, wc=1; 
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            int h = Convert.ToInt32(textBox1.Text);
            int w = Convert.ToInt32(textBox1.Text);
            Rectangle x = new Rectangle(pictureBox1.Width / 2, pictureBox1.Height / 2, w, h);
            label3.Text = $"P={Math.Round(2 * Math.PI * (x.Height / 2))}";
            label4.Text = $"S={Math.Round(Math.PI * ((x.Height / 2) * (x.Height / 2)))}";
            if (a)
            {
                while (x.Bottom > pictureBox1.Height - 5)
                {
                    hc++;
                    x.Height--;
                }
                while (x.Right > pictureBox1.Width - 5)
                {
                    wc++;
                    x.Width--;
                }
            }
            if (b)
            {
                while (x.Bottom < pictureBox1.Height - 5)
                {
                    hc--;
                    x.Height++;
                }
                while (x.Right < pictureBox1.Width - 5)
                {
                    wc--;
                    x.Width++;
                }
            }
            g.DrawEllipse(Pens.Black, x);
            label1.Text = $"Масштаб 1:{Math.Max(hc, wc)}";
            pictureBox1.Image = bmp;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            a = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            b = checkBox2.Checked;
        }
    }
}
