using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EasyDrawing
{
    public class MySegment: Shape
    {
        public override void Drawing(Graphics Canvas, Pen myPen, int x1, int y1, int x2, int y2)
        {
            Canvas.DrawLine(myPen, x1, y1, x2, y2);
        }
    }
}
