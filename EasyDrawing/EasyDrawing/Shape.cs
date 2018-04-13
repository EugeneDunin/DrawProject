using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EasyDrawing
{
    abstract class Shape
    {

        public Point first;
        public Point First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }
        public Point last;
        public Point Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }
        public static Pen pen;
        public static Pen pencil
        {
            set
            {
                pen = value;
            }
        }
        public virtual void Navigate(object sender, PaintEventArgs e) { }
        public virtual void Draw(Graphics g) { }
        public virtual void DrawInstant(Graphics g) { }
    }

    class FigureList
    {
        public static List<ShapeFabric> AllShapes = new List<ShapeFabric>()
        {
            new SegmentFabric(),
            new RectangleFabric(),
            new CircleFabric(),
            new EllipseFabric(),
            new TriangleFabric()
            //new StarFabric()
        };
    }
}
