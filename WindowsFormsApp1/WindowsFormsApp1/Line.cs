using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Line
    {
        private Point point1;
        private Point point2;

        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public Point GetPoint1()
        {
            return point1;
        }

        public Point GetPoint2()
        {
            return point2;
        }

        public void SetPoint1(Point point1)
        {
            this.point1 = point1;
        }

        public void SetPoint2(Point point2)
        {
            this.point2 = point2;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }




        //setcolor method
        public void SetColorAndDraw(System.Drawing.Color color, System.Windows.Forms.Panel panel)
        {
            System.Drawing.Graphics graphics = panel.CreateGraphics();
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(color);
            graphics.DrawLine(new System.Drawing.Pen(brush), point1.X, point1.Y, point2.X, point2.Y);
            Console.WriteLine("Цвет изменён на " + color);
            Console.WriteLine("Линия отрисована");
        }
    
        
        //getcolor method
        public System.Drawing.Color GetColor()
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(1, 1);
            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(point1.X, point1.Y, 1, 1);
            graphics.CopyFromScreen(rect.Location, System.Drawing.Point.Empty, rect.Size);
            System.Drawing.Color color = bitmap.GetPixel(0, 0);
            return color;
        }
    }
}
