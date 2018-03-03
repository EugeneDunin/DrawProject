using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasyDrawing
{
    public partial class Main_Form : Form
    {
        bool isPresed;
        int x1, y1, x2, y2;
        Bitmap snapshot, tempDraw;
        Color MyColor;
        int lineWidth;

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
             Graphics g = Graphics.FromImage(tempDraw);
             Pen myPen = new Pen(MyColor, lineWidth);
             g.DrawLine(myPen, x1, y1, x2, y2);
             myPen.Dispose();
             e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
             g.Dispose();
             x1 = x2;
             y1 = y2;

        }

        private void tool_Click(object sender, EventArgs e)
        {
            Line.Checked = false;
            Pencil.Checked = false;
            Rectangle.Checked = false;
            Circle.Checked = false;
            Triangle.Checked = false;
            Star.Checked = false;
            ToolStripButton btnClicked = sender as ToolStripButton;
            btnClicked.Checked = true;
        }

        private void NumericUpDown_Click(object sender, EventArgs e) // Толщина пера
        {
            lineWidth = (int)NumericUpDown.Value;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            MyColor = ColorDialog.Color;
        }

        public Main_Form() // Конструктор класса
        {
            InitializeComponent();
            snapshot = new Bitmap(PictureBox.ClientRectangle.Width, PictureBox.ClientRectangle.Height);
            tempDraw = (Bitmap)snapshot.Clone();
            MyColor = Color.Wheat;
            lineWidth = 1;
            Pencil.Checked = true;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e) // Событие нажатия маши
        {
            isPresed = true;
            x1 = e.X;
            y1 = e.Y;
            tempDraw = (Bitmap)snapshot.Clone();
        }
        
        private void PictureBox_MouseUp(object sender, MouseEventArgs e) // Событие отжатия маши
        {
            isPresed = false;
            snapshot = (Bitmap)tempDraw.Clone();
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e) // Перерисовка холста
        {
            if (isPresed)
            {
                x2 = e.X;
                y2 = e.Y;
                PictureBox.Invalidate();
                PictureBox.Update();
            }
        }

    }
}
