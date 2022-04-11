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


            int x_beg = 500;
            int y_beg = 500;

            const int figure_count = 5;
            int[,] point_array = new int[figure_count, 2] { { 12, 23 }, { 14, 14 }, { 43, 66 }, { 56, 75 }, { 25, 64 } };

            int x0 = 250;
            int y0 = 100;
            

            for (double angle =0; ;angle+=0.3 )
            {
                
double rot_angle = (angle/* - 0.0001*/ * Math.PI) / 180;

                //rot_angle = (angle /*+ 0.0001*/ * Math.PI) / 180;
               
                for (int x = 0; x < figure_count; x++)
                {
                    if (x >= 1)
                    {
                        g.DrawLine(blackpen, x_beg +(x0 + (point_array[x - 1, 0] - x0) * (float)Math.Cos(rot_angle) - (point_array[x - 1, 1] - y0) * (float)Math.Sin(rot_angle)),
                            y_beg - (y0 + (point_array[x - 1, 0] - x0) * (float)Math.Sin(rot_angle) + (point_array[x - 1, 1] - y0) * (float)Math.Cos(rot_angle)),
                            x_beg +(x0 + (point_array[x, 0] - x0) * (float)Math.Cos(rot_angle) - (point_array[x, 1] - y0) * (float)Math.Sin(rot_angle)),
                            y_beg - (y0 + (point_array[x, 0] - x0) * (float)Math.Sin(rot_angle) + (point_array[x, 1] - y0) * (float)Math.Cos(rot_angle)));
                    }
                }
                g.DrawLine(blackpen, x_beg +(x0 + (point_array[0, 0] - x0) * (float)Math.Cos(rot_angle) - (point_array[0, 1] - y0) * (float)Math.Sin(rot_angle)),
                    y_beg - (y0 + (point_array[0, 0] - x0) * (float)Math.Sin(rot_angle) + (point_array[0, 1] - y0) * (float)Math.Cos(rot_angle)),
                    x_beg + (x0 + (point_array[figure_count - 1, 0] - x0) * (float)Math.Cos(rot_angle) - (point_array[figure_count - 1, 1] - y0) * (float)Math.Sin(rot_angle)),
                    y_beg - (y0 + (point_array[figure_count - 1, 0] - x0) * (float)Math.Sin(rot_angle) + (point_array[figure_count - 1, 1] - y0) * (float)Math.Cos(rot_angle)));
                
                
                Pen whitepen=new Pen(Color.White,1);
               double wangle = angle - 0.3;
                rot_angle = (wangle  * Math.PI) / 180;
                for (int x = 0; x < figure_count; x++)
                {
                    if (x >= 1)
                    {
                        g.DrawLine(whitepen, x_beg + (x0 + (point_array[x - 1, 0] - x0) * (float)Math.Cos(rot_angle) - (point_array[x - 1, 1] - y0) * (float)Math.Sin(rot_angle)),
                            y_beg - (y0 + (point_array[x - 1, 0] - x0) * (float)Math.Sin(rot_angle) + (point_array[x - 1, 1] - y0) * (float)Math.Cos(rot_angle)),
                            x_beg + (x0 + (point_array[x, 0] - x0) * (float)Math.Cos(rot_angle) - (point_array[x, 1] - y0) * (float)Math.Sin(rot_angle)),
                            y_beg - (y0 + (point_array[x, 0] - x0) * (float)Math.Sin(rot_angle) + (point_array[x, 1] - y0) * (float)Math.Cos(rot_angle)));
                    }
                }
                g.DrawLine(whitepen, x_beg + (x0 + (point_array[0, 0] - x0) * (float)Math.Cos(rot_angle) - (point_array[0, 1] - y0) * (float)Math.Sin(rot_angle)),
                    y_beg - (y0 + (point_array[0, 0] - x0) * (float)Math.Sin(rot_angle) + (point_array[0, 1] - y0) * (float)Math.Cos(rot_angle)),
                    x_beg + (x0 + (point_array[figure_count - 1, 0] - x0) * (float)Math.Cos(rot_angle) - (point_array[figure_count - 1, 1] - y0) * (float)Math.Sin(rot_angle)),
                    y_beg - (y0 + (point_array[figure_count - 1, 0] - x0) * (float)Math.Sin(rot_angle) + (point_array[figure_count - 1, 1] - y0) * (float)Math.Cos(rot_angle)));



                g.DrawLine(blackpen, 500, 0, 500, 1000);
                g.DrawLine(blackpen, 0, 500, 1000, 500);
                g.DrawLine(blackpen, 500, 0, 525, 25);
                g.DrawLine(blackpen, 500, 0, 475, 25);
                g.DrawLine(blackpen, 1000, 500, 975, 475);
                g.DrawLine(blackpen, 1000, 500, 975, 525);
                
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

            }


        }

        
    }
}
