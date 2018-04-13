using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EasyDrawing
{
    class Ellipse: MyRectangle
    {
        public override void Navigate(object sender, PaintEventArgs e)
        {
            CalculatePoints();
            rectangle = new Rectangle(first.X, first.Y, width, height);
            e.Graphics.DrawEllipse(pen, rectangle);
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, rectangle);
        }
        public override void DrawInstant(Graphics g)
        {
            g.DrawEllipse(pen, first.X, first.Y, last.X - first.X, last.Y - first.Y);
        }
    }
}