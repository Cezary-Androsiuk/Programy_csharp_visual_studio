using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rysowanie
{
    public partial class Form1 : Form
    {
        bool pressed;
        int x1, x2;
        int y1, y2;
        int dotSize = 1;

        List<Point> points1;
        List<Point> points2;
        List<DrawType> shapeType;

        enum DrawType
        {
            dot,
            line,
            circle,
            rectangle
        }
        DrawType current_DrawType;

        public Form1()
        {
            InitializeComponent();
            pressed = false;
            this.x1 = 0;
            this.y1 = 0;
            this.x2 = 0;
            this.y2 = 0;
            this.points1 = new List<Point>();
            this.points2 = new List<Point>();
            this.shapeType = new List<DrawType>();
            this.current_DrawType = DrawType.dot;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.x1 = e.X;
            this.y1 = e.Y;
            this.x2 = e.X;
            this.y2 = e.Y;
            this.points1.Add(new Point(this.x1, this.y1));
            this.pressed = true;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.x2 = e.X;
            this.y2 = e.Y;
            this.pressed = false;
            this.points2.Add(new Point(this.x2, this.y2));
            this.shapeType.Add(this.current_DrawType);

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                this.x2 = e.X;
                this.y2 = e.Y;
            }
            pictureBox1.Invalidate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.current_DrawType = DrawType.dot;
            pictureBox1.Invalidate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.current_DrawType = DrawType.line;
            pictureBox1.Invalidate();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.current_DrawType = DrawType.circle;
            pictureBox1.Invalidate();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.current_DrawType = DrawType.rectangle;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // move draw

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (pressed)
            {
                switch (this.current_DrawType)
                {
                    case DrawType.dot:
                        e.Graphics.DrawEllipse(new Pen(Color.Black, 1), this.x1, this.y1, this.dotSize * 2, this.dotSize * 2);
                        break;
                    case DrawType.line:
                        e.Graphics.DrawLine(new Pen(Color.Black, 1), this.x1, this.y1, this.x2, this.y2);
                        break;
                    case DrawType.circle:
                        e.Graphics.DrawEllipse(new Pen(Color.Black, 1), this.x1, this.y1, Math.Abs(this.x2 - this.x1), Math.Abs(this.y2 - this.y1));
                        break;
                    case DrawType.rectangle:
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 1), this.x1, this.y1, Math.Abs(this.x2 - this.x1), Math.Abs(this.y2 - this.y1));
                        break;
                }
            }
            int range = this.points1.Count() - (this.points1.Count() != this.points2.Count() ? 1 : 0);
            for (int i = 0; i < range; i++)
            {
                switch (this.shapeType[i])
                {
                    case DrawType.dot:
                        e.Graphics.DrawEllipse(new Pen(Color.Black, 2),
                            this.points1[i].X - this.dotSize,
                            this.points1[i].Y - this.dotSize,
                            this.dotSize * 2,
                            this.dotSize * 2);
                        break;
                    case DrawType.line:
                        e.Graphics.DrawLine(new Pen(Color.Black, 2),
                            this.points1[i].X,
                            this.points1[i].Y,
                            this.points2[i].X,
                            this.points2[i].Y);
                        break;
                    case DrawType.circle:
                        e.Graphics.DrawEllipse(new Pen(Color.Black, 2),
                            this.points1[i].X,
                            this.points1[i].Y,
                            Math.Abs(this.points2[i].X - this.points1[i].X),
                            Math.Abs(this.points2[i].Y - this.points1[i].Y));
                        break;
                    case DrawType.rectangle:
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                            this.points1[i].X,
                            this.points1[i].Y,
                            Math.Abs(this.points2[i].X - this.points1[i].X),
                            Math.Abs(this.points2[i].Y - this.points1[i].Y));
                        break;

                }
            }
            
        }

    }
}
