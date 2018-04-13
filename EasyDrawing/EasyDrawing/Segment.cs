using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EasyDrawing
{
    class Segment : Shape
    {
        public override void Navigate(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, first, last);
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, first, last);
        }
        public override void DrawInstant(Graphics g)
        {
            g.DrawLine(pen, first, last);
        }
    }
}
