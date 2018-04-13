using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EasyDrawing
{
    class MyRectangle : Shape
    {
        protected Rectangle rectangle;
        protected bool reverseX, reverseY;
        protected int width, height;
        protected void SetVertexX()
        {
            if (!(first.X < last.X && first.Y < last.Y))
            {
                Point buf = first;
                first.X = Last.X;
                last.X = buf.X;
            }
        }
        protected void SetVertexY()
        {
            if (!(first.X < last.X && first.Y < last.Y))
            {
                Point buf = First;
                first.Y = Last.Y;
                last.Y = buf.Y;
            }
        }
        protected void SetVertex2X()
        {
            double v1X = first.X;
            if (reverseX)
            {
                v1X += width;
            }

            if (v1X > last.X)
            {
                first.X = last.X;

                last.X = (int)v1X;
                reverseX = true;
            }
            else
            {
                reverseX = false;
            }
        }

        protected void SetVertex2Y()
        {
            double v1Y = first.Y;
            if (reverseY)
            {
                v1Y += height;
            }

            if (v1Y > last.Y)
            {
                first.Y = last.Y;

                last.Y = (int)v1Y;
                reverseY = true;
            }
            else
            {
                reverseY = false;
            }
        }

        protected void getsize()
        {
            width = Math.Abs(last.X - first.X);
            height = Math.Abs(last.Y - first.Y);
        }
        
        protected void CalculatePoints()
        {
            getsize();
            SetVertex2X();
            SetVertex2Y();
        }
        public override void Navigate(object sender, PaintEventArgs e)
        {
            CalculatePoints();
            rectangle = new Rectangle(first.X, first.Y, width, height);
            e.Graphics.DrawRectangle(pen, rectangle);
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, first.X, first.Y, width, height);
        }
        public override void DrawInstant(Graphics g)
        {
            g.DrawRectangle(pen, first.X, first.Y, last.X - first.X, last.Y - first.Y);
        }
    }
}
