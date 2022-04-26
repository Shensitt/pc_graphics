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

        public int diag_pass_x;
        public int diag_pass_xx;
        public const int figure_count = 7;
        public int[,] point_array = new int[figure_count, 2] { { 270, 300 }, { 270, 200 }, { 400, 160 }, { 500, 230 }, { 380, 370 }, { 420, 260 }, { 360, 210 } };
        public Pen blackpen = new Pen(Color.Black, 1);
        public int x_beg = 500;
        public int y_beg = 500;


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            
            Graphics g = CreateGraphics();
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


          

            double diag_length, diag_length_pass = 1000;
            
            for (int x = 0; x < figure_count; x++)
            {
                if (x >= 1)
                {
                    g.DrawLine(blackpen, x_beg + point_array[x - 1, 0],//рисует изначальный многоугольник, все четко
                        y_beg - point_array[x - 1, 1],
                        x_beg + point_array[x, 0],
                        y_beg - point_array[x, 1]);

                    diag_length = Math.Sqrt//потом проверить, не оч надежно выглядит
                        (
                            Math.Pow
                            (
                                Math.Abs
                                (
                                Math.Abs(point_array[x - 1, 0]) - Math.Abs(point_array[x, 0])
                                ), 2
                            )

                            +

                            Math.Pow
                            (
                                Math.Abs
                                (
                                Math.Abs(point_array[x - 1, 1]) - Math.Abs(point_array[x, 1])
                                ), 2
                            )
                        );

                    if (diag_length_pass > diag_length)
                    {
                        diag_length_pass = diag_length;//мб сделать что-то сдесь
                        diag_pass_x = x-2;
                    }
                    //else
                    //{
                    //    if (diag_length_pass == diag_length)
                    //    {
                    //        diag_length_pass = diag_length;
                    //        diag_pass_xx = x;
                    //    }
                    //}


                }
            }
            g.DrawLine(blackpen, x_beg + point_array[0, 0],
                y_beg - point_array[0, 1],
                x_beg + point_array[figure_count - 1, 0],
                y_beg - point_array[figure_count - 1, 1]);


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();

            if (point_array[diag_pass_x-1,0]*point_array[diag_pass_x,1]+
                point_array[diag_pass_x,0]*point_array[diag_pass_x-1,1]+
                point_array[diag_pass_x-1,0]*point_array[diag_pass_x+1,1]-
                
                point_array[diag_pass_x+1,0]*point_array[diag_pass_x,1]-
                point_array[diag_pass_x+1,1]*point_array[diag_pass_x,0]-
                point_array[diag_pass_x-1,1]*point_array[diag_pass_x+1,0]

                > 0)
            {
                g.DrawLine(blackpen, x_beg + point_array[diag_pass_x-1, 0],
                y_beg - point_array[diag_pass_x-1, 1],
                x_beg + point_array[diag_pass_x+1, 0],
                y_beg - point_array[diag_pass_x+1, 1]);
            }

            int cycle_perf = 0;
            for(int x = 0; x < figure_count; x++)
            {
                if (cycle_perf == 1)
                {
                    break;
                }
                if (x == diag_pass_x)
                {
                    point_array[diag_pass_x, 0] = point_array[diag_pass_x+1,0];
                    point_array[diag_pass_x, 1] = point_array[diag_pass_x+1,1];
                    
                    for(int a = diag_pass_x+1; a < figure_count-1; a++)
                    {
                        point_array[a, 0] = point_array[a + 1, 0];
                        point_array[a, 1] = point_array[a + 1, 1];
                        break;
                        
                    }
                    cycle_perf = 1;
                }
            }

           

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = CreateGraphics();

            //if (point_array[diag_pass_x - 1, 0] * point_array[diag_pass_x, 1] +
            //    point_array[diag_pass_x, 0] * point_array[diag_pass_x - 1, 1] +
            //    point_array[diag_pass_x - 1, 0] * point_array[diag_pass_x + 1, 1] -

            //    point_array[diag_pass_x + 1, 0] * point_array[diag_pass_x, 1] -
            //    point_array[diag_pass_x + 1, 1] * point_array[diag_pass_x, 0] -
            //    point_array[diag_pass_x - 1, 1] * point_array[diag_pass_x + 1, 0]

            //    > 0)
            //{
            //    g.DrawLine(blackpen, x_beg + point_array[diag_pass_x - 1, 0],
            //    y_beg - point_array[diag_pass_x - 1, 1],
            //    x_beg + point_array[diag_pass_x + 1, 0],
            //    y_beg - point_array[diag_pass_x + 1, 1]);
            //}

            //int cycle_perf = 0;
            //for (int x = 0; x < figure_count; x++)
            //{
            //    if (cycle_perf == 1)
            //    {
            //        break;
            //    }
            //    if (x == diag_pass_x)
            //    {
            //        point_array[diag_pass_x, 0] = point_array[diag_pass_x + 1, 0];
            //        point_array[diag_pass_x, 1] = point_array[diag_pass_x + 1, 1];
            //        if (figure_count <= 3)
            //        {
            //            break;
            //        }
            //        for (int a = diag_pass_x + 1; a < figure_count - 1; a++)
            //        {
            //            point_array[a, 0] = point_array[a + 1, 0];
            //            point_array[a, 1] = point_array[a + 1, 1];
            //            break;

            //        }
            //        cycle_perf = 1;
            //    }
            //}


        }
    }
}
