using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Point
    {
        private int x;
        private int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //getter and setter
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        //setcolor method
        public void SetColor(System.Drawing.Color color)
        {
            System.Drawing.Graphics graphics = System.Windows.Forms.Form.ActiveForm.CreateGraphics();
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(color);
            Console.WriteLine("Цвет изменён на " + color);
        }

        //getcolor method
        public System.Drawing.Color GetColor()
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(1, 1);
            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, 1, 1);
            graphics.CopyFromScreen(rect.Location, System.Drawing.Point.Empty, rect.Size);
            System.Drawing.Color color = bitmap.GetPixel(0, 0);
            return color;
        } 
    }

}
