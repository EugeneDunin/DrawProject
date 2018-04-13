namespace EasyDrawing
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Circle = new System.Windows.Forms.ToolStripButton();
            this.Triangle = new System.Windows.Forms.ToolStripButton();
            this.Star = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.Coordinates = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectionButtonDisactivate = new System.Windows.Forms.RadioButton();
            this.SelectionButtonActivate = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.Location = new System.Drawing.Point(7, 48);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(779, 349);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Line,
            this.Rectangle,
            this.Circle,
            this.Triangle,
            this.Star,
            this.Ellipse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(23, 22);
            this.Line.Text = "toolStripButton1";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(23, 22);
            this.Rectangle.Text = "toolStripButton2";
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Circle
            // 
            this.Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(23, 22);
            this.Circle.Text = "toolStripButton2";
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Triangle
            // 
            this.Triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Triangle.Image = ((System.Drawing.Image)(resources.GetObject("Triangle.Image")));
            this.Triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(23, 22);
            this.Triangle.Text = "toolStripButton3";
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Star
            // 
            this.Star.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Star.Image = ((System.Drawing.Image)(resources.GetObject("Star.Image")));
            this.Star.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(23, 22);
            this.Star.Text = "toolStripButton4";
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(23, 22);
            this.Ellipse.Text = "toolStripButton1";
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(183, 8);
            this.NumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.NumericUpDown.TabIndex = 4;
            this.NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown.Click += new System.EventHandler(this.NumericUpDown_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ColorButton.Location = new System.Drawing.Point(256, 5);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(101, 23);
            this.ColorButton.TabIndex = 5;
            this.ColorButton.Text = "Цвет кисти";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(363, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(95, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Очистить лист";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(464, 5);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(103, 23);
            this.OutputButton.TabIndex = 7;
            this.OutputButton.Text = "Вывести фигуры";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // Coordinates
            // 
            this.Coordinates.AutoSize = true;
            this.Coordinates.Location = new System.Drawing.Point(12, 400);
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(51, 13);
            this.Coordinates.TabIndex = 8;
            this.Coordinates.Text = "X: 0  Y: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectionButtonDisactivate);
            this.groupBox1.Controls.Add(this.SelectionButtonActivate);
            this.groupBox1.Location = new System.Drawing.Point(573, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 37);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выделение";
            // 
            // SelectionButtonDisactivate
            // 
            this.SelectionButtonDisactivate.AutoSize = true;
            this.SelectionButtonDisactivate.Location = new System.Drawing.Point(86, 14);
            this.SelectionButtonDisactivate.Name = "SelectionButtonDisactivate";
            this.SelectionButtonDisactivate.Size = new System.Drawing.Size(82, 17);
            this.SelectionButtonDisactivate.TabIndex = 1;
            this.SelectionButtonDisactivate.TabStop = true;
            this.SelectionButtonDisactivate.Text = "Выключить";
            this.SelectionButtonDisactivate.UseVisualStyleBackColor = true;
            this.SelectionButtonDisactivate.CheckedChanged += new System.EventHandler(this.SelectionButtonDisactivate_CheckedChanged);
            // 
            // SelectionButtonActivate
            // 
            this.SelectionButtonActivate.AutoSize = true;
            this.SelectionButtonActivate.Location = new System.Drawing.Point(6, 14);
            this.SelectionButtonActivate.Name = "SelectionButtonActivate";
            this.SelectionButtonActivate.Size = new System.Drawing.Size(74, 17);
            this.SelectionButtonActivate.TabIndex = 0;
            this.SelectionButtonActivate.TabStop = true;
            this.SelectionButtonActivate.Text = "Влкючить";
            this.SelectionButtonActivate.UseVisualStyleBackColor = true;
            this.SelectionButtonActivate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Coordinates);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PictureBox);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Main_Form";
            this.Text = "EasyDrawing";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Circle;
        private System.Windows.Forms.ToolStripButton Triangle;
        private System.Windows.Forms.ToolStripButton Star;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Label Coordinates;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SelectionButtonDisactivate;
        private System.Windows.Forms.RadioButton SelectionButtonActivate;
    }
}

