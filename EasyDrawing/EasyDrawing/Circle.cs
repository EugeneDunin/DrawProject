using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EasyDrawing
{
    class Circle : MyRectangle
    {
        public override void Navigate(object sender, PaintEventArgs e)
        {
            CalculatePoints();
            rectangle = new Rectangle(first.X, first.Y, width, width);
            e.Graphics.DrawEllipse(pen, rectangle);
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, rectangle);
        }
        public override void DrawInstant(Graphics g)
        {
            int x = 0;
            if (last.X - first.X >= last.Y - first.Y)
                x = last.X - first.X;
            else
                x = last.Y - first.Y;
            g.DrawEllipse(pen, first.X, first.Y, x, x);
        }
    }
}
