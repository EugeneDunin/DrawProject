using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace EasyDrawing
{
    public partial class Main_Form : Form
    {
        private bool isPresed = false;
        private Point FirstPoint, LastPoint, delta;
        Bitmap canvas;
        Graphics g;
        private Pen p;
        private ShapeFabric sourceFabric;
        private Shape shape;
        int ShapeObjIndex;
        public enum Item
        {
            Line, Rectangle, Circle, Triangle, Star, Ellipse
        };
        Item CurrentItem = Item.Line;
        //==================================================
        //==================================================
        public Main_Form() // Конструктор класса
        {
            InitializeComponent();

            sourceFabric = new SegmentFabric();
            shape = sourceFabric.Create();

            canvas = new Bitmap(PictureBox.ClientRectangle.Width, PictureBox.ClientRectangle.Height);

            PictureBox.Image = canvas;
            g = Graphics.FromImage(canvas);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            p = new Pen(Color.Black, (float)NumericUpDown.Value);
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Shape.pencil = p;
        }
        //==================================================
        //==================================================
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isPresed)
            {
                if (MoveObject)
                {
                    e.Graphics.DrawImage(canvas, 0, 0);
                }
                else
                {
                    shape.first = FirstPoint;
                    shape.last = LastPoint;
                    shape.Navigate(sender, e);
                }
                
            }
        }
        //==================================================
        //==================================================

        private void PictureBox_MouseDown(object sender, MouseEventArgs e) // Событие нажатия мыши
        {
            isPresed = true;

            if ((ShapeObjIndex = GetPressedDotIndex(e)) != -1 && MoveObject)
            {
                delta.X = e.X - Shapes[ShapeObjIndex].first.X;
                delta.Y = e.Y - Shapes[ShapeObjIndex].first.Y;
            }
            else
            {
                FirstPoint = e.Location;
                Shape.pencil = p;  // Задаём параметры фигур
            }
        }

        //==================================================
        //==================================================
        private void PictureBox_MouseUp(object sender, MouseEventArgs e) // Событие отжатия мыши
        {
            isPresed = false;
            //PictureBox.Image = canvas;
            if (!MoveObject)
            {
                shape.Draw(g);
                PictureBox.Image = canvas;
            }
        }

        //==================================================
        //==================================================
        private void PictureBox_MouseMove(object sender, MouseEventArgs e) // Перерисовка холста
        {
            Coordinates.Text = string.Format("X: {0}  Y:{1}", e.X, e.Y);
            if (isPresed)
            {
                if (MoveObject && ShapeObjIndex != -1)
                {
                    Shapes[ShapeObjIndex].first.X = e.X - delta.X;
                    Shapes[ShapeObjIndex].first.Y = e.Y - delta.Y;
                    RefreshCanvas();
                    PictureBox.Invalidate();
                }
                else
                {
                    LastPoint = e.Location;
                    PictureBox.Invalidate();
                    PictureBox.Update();
                }
            }
        }
        //==================================================
        //==================================================
        private void ClearButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            PictureBox.Invalidate();
            Shapes.Clear();
        }
        //==================================================
        //==================================================
        private void ColorButton_Click(object sender, EventArgs e) // Изменение цвета пера
        {
            if (ColorDialog.ShowDialog() != DialogResult.OK) return;
            p.Color = ColorDialog.Color;
        }
    }
}

