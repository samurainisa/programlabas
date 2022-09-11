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

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<Point> points = new List<Point>();
            
            for (int i = 0; i < 10; i++)
            {
                Point Point = new Point(random.Next(0, 141), random.Next(0, 141));
                points.Add(Point);
            }

            //foreach (Point point in points)
            //{
            //    Console.WriteLine(point.X);
            //    Console.WriteLine(point.Y);
            //}


            foreach (Point point in points)
            {
                Graphics g = dp3.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);
                g.FillEllipse(brush, point.X, point.Y, 5, 5);
            }
            
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<ColoredPoint> cpoints = new List<ColoredPoint>();

            for (int i = 0; i < 10; i++)
            {
                ColoredPoint coloredPoint = new ColoredPoint(random.Next(0, 141), random.Next(0, 141), Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                cpoints.Add(coloredPoint);
            }

            foreach (ColoredPoint cpoint in cpoints)
            {
                Console.WriteLine(cpoint.X);
                Console.WriteLine(cpoint.Y);
            }


            foreach (ColoredPoint cpoint in cpoints)
            {
                Graphics g = dp2.CreateGraphics();
                //draw colored points 
                SolidBrush brush = new SolidBrush(cpoint.Color);
                g.FillEllipse(brush, cpoint.X, cpoint.Y,5,5);

            }
        }

        //setcolor of line method


        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<Line> lines = new List<Line>();

            //Point point1 = new Point(10, 40);
            //Point point2 = new Point(80, 141);

            for (int i = 0; i < 10; i++)
            {
                Point point1 = new Point(random.Next(0, 141), random.Next(0, 141));
                Point point2 = new Point(random.Next(0, 141), random.Next(0, 141));
                Line localline = new Line(point1, point2);
                lines.Add(localline);
            }

            foreach (Line line in lines)
            {
                
            }



            //Line line = new Line(point1, point2);
            //Console.WriteLine(line.GetLength());
            //line.GetLength();

            ////draw line on pictureBox1
            //Graphics g = dp.CreateGraphics();
            //line.SetColorAndDraw(Color.Red, dp);
            //line.SetColorAndDraw(Color.Green, dp);
        }
    }
}