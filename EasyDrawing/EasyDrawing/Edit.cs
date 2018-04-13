using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EasyDrawing
{
    public partial class Main_Form
    {
        private int GetPressedDotIndex(MouseEventArgs e)//++++++++++++++++++++++++++++++++++++++++++++++++++
        {
            foreach (Shape obj in Shapes)
            {
                if (e.X < obj.first.X || e.X > obj.first.X + Math.Abs(obj.last.X - obj.first.X))
                    continue;

                if (e.Y < obj.first.Y || e.Y > obj.first.Y + Math.Abs(obj.last.Y - obj.first.Y))
                    continue;
                return Shapes.IndexOf(obj);
            }
            return -1;
        }

        private void RefreshCanvas()
        {
            g = Graphics.FromImage(canvas);
            g.Clear(Color.White);
            //PictureBox.Invalidate();
            foreach (Shape fig in Shapes)
            {
                fig.DrawInstant(g);
            }
        }
    }
}
