﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EasyDrawing
{
    partial class Star : Shape
    {
        Point[] star;
        public override void Navigate(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawPolygon(pen, star);
        }
        public override void Draw(Graphics g)
        {
            //g.DrawPolygon(pen, star);
        }
    }
}