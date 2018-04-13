using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDrawing
{
    abstract class ShapeFabric
    {
        public abstract Shape Create();
    }
    //================================================================================
    class CircleFabric : ShapeFabric
    {
        public override Shape Create()
        {
            return new Circle();
        }
    }
    //================================================================================
    class RectangleFabric : ShapeFabric
    {
        public override Shape Create()
        {
            return new MyRectangle();
        }
    }
    //================================================================================
    class EllipseFabric : ShapeFabric
    {
        public override Shape Create()
        {
            return new Ellipse();
        }
    }
    //================================================================================
    class TriangleFabric : ShapeFabric
    {
        public override Shape Create()
        {
            return new Triangle();
        }
    }
    //================================================================================
    class SegmentFabric : ShapeFabric
    {
        public override Shape Create()
        {
            return new Segment();
        }
    }
    //================================================================================
    class StarFabric : ShapeFabric
    {
        public override Shape Create()
        {
            return new Star();
        }
    }

}
