using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ColoredPoint : Point
    {
        private int x;
        private int y;



        private System.Drawing.Color color;

        public ColoredPoint()
        {
            color = System.Drawing.Color.Black;
        }



        public ColoredPoint(int x, int y, System.Drawing.Color color) : base(x, y)
        {
            this.color = color;
        }

        public System.Drawing.Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public new void SetColor(System.Drawing.Color color)
        {
            System.Drawing.Graphics graphics = System.Windows.Forms.Form.ActiveForm.CreateGraphics();
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(color);
            Console.WriteLine("Цвет изменён на " + color);
        }

        public new System.Drawing.Color GetColor()
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
