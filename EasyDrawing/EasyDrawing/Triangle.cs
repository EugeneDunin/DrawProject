using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EasyDrawing
{
    class Triangle : Shape
    {
        private Point[] triangle;
        private Point thirdPoint;
        private Point ThirdPointValue()
        {
           //int x = (first.X + last.X) / 2;
           //int y = (first.Y + last.Y);
           return new Point(first.X, last.Y);
        }
        public override void Navigate(object sender, PaintEventArgs e)
        {
            thirdPoint = ThirdPointValue();
            triangle = new Point[] { new Point(first.X,first.Y) , new Point(last.X, last.Y), thirdPoint};
            e.Graphics.DrawPolygon(pen, triangle);
        }
        public override void Draw(Graphics g)
        {
            g.DrawPolygon(pen, triangle);
        }
        public override void DrawInstant(Graphics g)
        {
            g.DrawPolygon(pen, new Point[] { new Point(first.X, first.Y), new Point(last.X, last.Y), ThirdPointValue()});
        }
    }
}
