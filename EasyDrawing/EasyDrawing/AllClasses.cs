using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EasyDrawing
{
    //абстрактный класс - фигура
    public abstract class Shape
    {
        public abstract void Drawing(Graphics Canvas, Pen myPen, int x1, int y1, int x2, int y2);
    }
    // класс абстрактной фабрики
    abstract class ShapeFactory
    {
        public abstract Shape CreateLine();
        public abstract Shape CreateCirle();
        public abstract Shape CreateRectangle();
        public abstract Shape CreateTriangle();
        public abstract Shape CreateStar();
    }
}
