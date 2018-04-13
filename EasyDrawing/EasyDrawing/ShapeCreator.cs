using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDrawing
{
    public partial class Main_Form
    {
        private List<Shape> Shapes = new List<Shape>() { }; // Список объектов на рисунке
        private void NumericUpDown_Click(object sender, EventArgs e) // Толщина пера
        {
            p.Width = (int)NumericUpDown.Value;
        }
        //==================================================
        //==================================================
        private void Line_Click(object sender, EventArgs e)
        {
            CurrentItem = Item.Line;
            ShapeEditor(new SegmentFabric());
        }
        //==================================================
        //==================================================
        private void Rectangle_Click(object sender, EventArgs e)
        {
            CurrentItem = Item.Rectangle;
            ShapeEditor(new RectangleFabric());
        }
        //==================================================
        //==================================================
        private void Circle_Click(object sender, EventArgs e)
        {
            CurrentItem = Item.Circle;
            ShapeEditor(new CircleFabric());
        }
        //==================================================
        //==================================================
        private void Triangle_Click(object sender, EventArgs e)
        {
            CurrentItem = Item.Triangle;
            ShapeEditor(new TriangleFabric());
        }
        //==================================================
        //==================================================
        private void Ellipse_Click(object sender, EventArgs e)
        {
            CurrentItem = Item.Ellipse;
            ShapeEditor(new EllipseFabric());
        }
        //==================================================
        //==================================================
        private void Star_Click(object sender, EventArgs e)
        {
            CurrentItem = Item.Star;
            ShapeEditor(new StarFabric());
        }
        //==================================================
        //==================================================
        private void ShapeEditor(ShapeFabric fabric)
        {
            shape = fabric.Create();
            Shapes.Add(shape);
        }
    }
}
