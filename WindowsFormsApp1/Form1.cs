using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            Graphics g = CreateGraphics();
            Pen blackpen = new Pen(Color.Black, 1);

            g.DrawLine(blackpen, 500, 0, 500, 1000);
            g.DrawLine(blackpen, 0, 500, 1000, 500);
            g.DrawLine(blackpen, 500, 0, 525, 25);
            g.DrawLine(blackpen, 500, 0, 475, 25);
            g.DrawLine(blackpen, 1000, 500, 975, 475);
            g.DrawLine(blackpen, 1000, 500, 975, 525);
            Font Arial = new Font("Arial", 8);
            Brush brush = new SolidBrush(Color.Black);
            g.DrawString("0", Arial, brush, 500, 500);
            g.DrawString("x", Arial, brush, 1000, 500);
            g.DrawString("y", Arial, brush, 500, 0);


            for (int x = 0; x < 1000; x += 100)
            {
                g.DrawLine(blackpen, x, 495, x, 505);
                if (x == 100)
                {
                    g.DrawString("-4", Arial, brush, x, 500);
                }
                if (x == 200)
                {
                    g.DrawString("-3", Arial, brush, x, 500);
                }
                if (x == 300)
                {
                    g.DrawString("-2", Arial, brush, x, 500);
                }
                if (x == 400)
                {
                    g.DrawString("-1", Arial, brush, x, 500);
                }
                if (x == 600)
                {
                    g.DrawString("1", Arial, brush, x, 500);
                }
                if (x == 700)
                {
                    g.DrawString("2", Arial, brush, x, 500);
                }
                if (x == 800)
                {
                    g.DrawString("3", Arial, brush, x, 500);
                }
                if (x == 900)
                {
                    g.DrawString("4", Arial, brush, x, 500);
                }
            }
            for (int y = 0; y < 1000; y += 100)
            {
                g.DrawLine(blackpen, 495, y, 505, y);
                if (y == 100)
                {
                    g.DrawString("4", Arial, brush, 500, y);
                }
                if (y == 200)
                {
                    g.DrawString("3", Arial, brush, 500, y);
                }
                if (y == 300)
                {
                    g.DrawString("2", Arial, brush, 500, y);
                }
                if (y == 400)
                {
                    g.DrawString("1", Arial, brush, 500, y);
                }
                if (y == 600)
                {
                    g.DrawString("-1", Arial, brush, 500, y);
                }
                if (y == 700)
                {
                    g.DrawString("-2", Arial, brush, 500, y);
                }
                if (y == 800)
                {
                    g.DrawString("-3", Arial, brush, 500, y);
                }
                if (y == 900)
                {
                    g.DrawString("-4", Arial, brush, 500, y);
                }
            }


            int x_beg = 500 - 2;
            int y_beg = 500 - 4;
            for (double x = 0; x < 5; x += 0.001)
            {
                double xr = (x / Math.PI) * 180;
                double f = Math.Sin(xr);
                double xc = (xr * 100);
                double fc = f * 100;
                if (xc >= 500) { break; }
                g.DrawString("'", Arial, brush, x_beg + (float)xc, y_beg - (float)fc);
            }

            for (double x = 0.5; x < 4; x += 0.01)
            {
                // double xr = (x / Math.PI) * 180;
                double f = Math.Pow(x, (0.3 * Math.PI + 1));
                // double xc = (xr * 100);
                //double fc = f * 100;
                // if (xc >= 500) { break; }
                g.DrawString("'", Arial, brush, x_beg + (float)x * 100, y_beg - (float)f * 100);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

            Graphics g = CreateGraphics();
            Pen blackpen = new Pen(Color.Black, 1);

            g.DrawLine(blackpen, 500, 0, 500, 1000);
            g.DrawLine(blackpen, 0, 500, 1000, 500);
            g.DrawLine(blackpen, 500, 0, 525, 25);
            g.DrawLine(blackpen, 500, 0, 475, 25);
            g.DrawLine(blackpen, 1000, 500, 975, 475);
            g.DrawLine(blackpen, 1000, 500, 975, 525);
            Font Arial = new Font("Arial", 8);
            Brush brush = new SolidBrush(Color.Black);
            g.DrawString("0", Arial, brush, 500, 500);
            g.DrawString("x", Arial, brush, 1000, 500);
            g.DrawString("y", Arial, brush, 500, 0);


            for (int x = 0; x < 1000; x += 100)
            {
                g.DrawLine(blackpen, x, 495, x, 505);
                if (x == 100)
                {
                    g.DrawString("-4", Arial, brush, x, 500);
                }
                if (x == 200)
                {
                    g.DrawString("-3", Arial, brush, x, 500);
                }
                if (x == 300)
                {
                    g.DrawString("-2", Arial, brush, x, 500);
                }
                if (x == 400)
                {
                    g.DrawString("-1", Arial, brush, x, 500);
                }
                if (x == 600)
                {
                    g.DrawString("1", Arial, brush, x, 500);
                }
                if (x == 700)
                {
                    g.DrawString("2", Arial, brush, x, 500);
                }
                if (x == 800)
                {
                    g.DrawString("3", Arial, brush, x, 500);
                }
                if (x == 900)
                {
                    g.DrawString("4", Arial, brush, x, 500);
                }
            }
            for (int y = 0; y < 1000; y += 100)
            {
                g.DrawLine(blackpen, 495, y, 505, y);
                if (y == 100)
                {
                    g.DrawString("4", Arial, brush, 500, y);
                }
                if (y == 200)
                {
                    g.DrawString("3", Arial, brush, 500, y);
                }
                if (y == 300)
                {
                    g.DrawString("2", Arial, brush, 500, y);
                }
                if (y == 400)
                {
                    g.DrawString("1", Arial, brush, 500, y);
                }
                if (y == 600)
                {
                    g.DrawString("-1", Arial, brush, 500, y);
                }
                if (y == 700)
                {
                    g.DrawString("-2", Arial, brush, 500, y);
                }
                if (y == 800)
                {
                    g.DrawString("-3", Arial, brush, 500, y);
                }
                if (y == 900)
                {
                    g.DrawString("-4", Arial, brush, 500, y);
                }
            }


            int x_beg = 500 - 2;
            int y_beg = 500 - 4;
            for (double x = 0; x < 5; x += 0.001)
            {
                double xr = (x / Math.PI) * 180;
                double f = Math.Sin(xr);
                double xc = (xr * 100);
                double fc = f * 100;
                if (xc >= 500) { break; }
                g.DrawString("'", Arial, brush, x_beg + (float)xc, y_beg - (float)fc);
            }

            for (double x = 0.5; x < 4; x += 0.01)
            {
                // double xr = (x / Math.PI) * 180;
                double f = Math.Pow(x, (0.3 * Math.PI + 1));
                // double xc = (xr * 100);
                //double fc = f * 100;
                // if (xc >= 500) { break; }
                g.DrawString("'", Arial, brush, x_beg + (float)x * 100, y_beg - (float)f * 100);
            }
        }
    }
}
