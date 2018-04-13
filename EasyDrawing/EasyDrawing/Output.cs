using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace EasyDrawing
{
    public partial class Main_Form
    {
        private void OutputButton_Click(object sender, EventArgs e)
        {
            int x = 20, y = 20;
            foreach (ShapeFabric fig in FigureList.AllShapes)
            {
                Shape figure = fig.Create();
                figure.First = new Point(x, y);
                figure.Last = new Point(x + 40, y + 30);
                figure.DrawInstant(g);
                if (x == 80)
                {
                    x = 20;
                }
                else
                {
                    y += 40;
                }
            }
            PictureBox.Invalidate();
        }
    }
}
