using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USSR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float x = 50;
        float y = 200;
        float x0 = 50;
        float y0 = 200;
        float v = 0;
        float vx;
        float vy;
        float fx;
        float fy;
        float ax;
        float ay;
        float ang;
        float t = 0;
        float t0 = 0;
        float m;
        float g = 9.81f;
        float k = 2f;
        float zemlya = 201;
        double pi = Math.PI / 180;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            vy = (float)(v * Math.Sin(ang * pi));
            vx = (float)(v * Math.Cos(ang * pi));
            fx = -k * vx * vx;
            fy = -(m * g + k * v * vy);
            t++;
            float dt = t / 100;
            ax = fx / m;
            ay = fy / y;
            vx = vx + ax * dt;
            vy = vy + ay * dt;
            y -= vx + ax * dt * dt / 2;
            x += vy - ay * dt * dt / 2;
            if (y >= zemlya)
            {
                timer1.Stop();
            }
            pictureBox1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            float.TryParse(TBspeed.Text, out v);
            float.TryParse(TBangle.Text, out ang);
            float.TryParse(TBresistance.Text, out m);
            timer1.Start();
            timer1.Interval = 10;           
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Black, x, y, 20, 20);
            e.Graphics.DrawLine(Pens.Black, 60, 250, 60, 10);
            e.Graphics.DrawLine(Pens.Black, 40, 210, 900, 210);
            e.Graphics.DrawLine(Pens.Black, 60, 10, 55, 30);
            e.Graphics.DrawLine(Pens.Black, 60, 10, 65, 30);
            e.Graphics.DrawLine(Pens.Black, 900, 210, 880, 205);
            e.Graphics.DrawLine(Pens.Black, 900, 210, 880, 215);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();        
            x = x0;
            y = y0;
            t = t0;           
            pictureBox1.Refresh();
        }

        
    }
}

