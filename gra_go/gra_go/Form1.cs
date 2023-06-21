using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra_go
{
    public partial class Form1 : Form
    {
        int planeSize = 19;
        Button[,] plane = new Button[19, 19];
        int buttonSize = 30;
        public Form1()
        {
            InitializeComponent();
            this.build_buttons();
        }

        private void build_buttons()
        {
            for (int i = 0; i < 19; i++)
            {
                for(int j=0; j < 19; j++)
                {
                    this.plane[i, j] = new System.Windows.Forms.Button();
                    this.plane[i, j].Location = new System.Drawing.Point(j* this.buttonSize,i * this.buttonSize);
                    this.plane[i, j].Name = "button_r" + i.ToString() + "_c" + j.ToString();
                    this.plane[i, j].Size = new System.Drawing.Size(this.buttonSize, this.buttonSize);
                    this.plane[i, j].Margin = new System.Windows.Forms.Padding(0);
                    this.plane[i, j].TabIndex = 0;
                    this.plane[i, j].Tag = "0";
                    this.plane[i, j].UseVisualStyleBackColor = true;

                    this.plane[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    this.plane[i, j].BackColor = System.Drawing.Color.Transparent;
                    this.plane[i, j].Margin = new System.Windows.Forms.Padding(0);
                    this.plane[i, j].FlatAppearance.BorderSize = 0;

                    this.plane[i, j].Click += new System.EventHandler(this.button1_Click);
                    this.plane[i, j].Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);

                    this.panel1.Controls.Add(this.plane[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Tag = "1";
        }

        private void draw_on_button(PaintEventArgs e, Point p1, Point p2)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2.0f), p1.X, p1.Y, p2.X, p2.Y);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button b = sender as Button;
            Point middle = new Point(this.buttonSize / 2, this.buttonSize / 2);
            int zero = 0;
            int half = this.buttonSize / 2;
            int full = this.buttonSize;
            int circleSize = 6;
            if(b.Tag.ToString() == "1")
            {
                e.Graphics.DrawEllipse(new Pen(Color.Black, 2f), middle.X - circleSize, middle.Y - circleSize, circleSize * 2, circleSize * 2);
            }


            /*  Draw Corners  */
            if (b.Location.X == 0 && b.Location.Y == 0) // left top
            {
                this.draw_on_button(e, middle, new Point(half, full)); // middle to bottom
                this.draw_on_button(e, middle, new Point(full, half)); // middle to right
                return;
            }
            if (b.Location.X == 0 && b.Location.Y == this.buttonSize * (this.planeSize - 1))
            {
                this.draw_on_button(e, middle, new Point(half, zero)); // middle to top 
                this.draw_on_button(e, middle, new Point(full, half)); // middle to right
                return;
            }
            if (b.Location.X == this.buttonSize * (this.planeSize - 1) && b.Location.Y == 0)
            {
                this.draw_on_button(e, middle, new Point(half, full)); // middle to bottom
                this.draw_on_button(e, middle, new Point(zero, half)); // middle to left
                return;
            }
            if (b.Location.X == this.buttonSize * (this.planeSize - 1) && b.Location.Y == this.buttonSize * (this.planeSize - 1))
            {
                this.draw_on_button(e, middle, new Point(half, zero)); // middle to top 
                this.draw_on_button(e, middle, new Point(zero, half)); // middle to left
                return;
            }


            /*  Draw Sides  */
            if (b.Location.X == 0) // left side
            {
                this.draw_on_button(e, middle, new Point(half, zero)); // middle to top 
                this.draw_on_button(e, middle, new Point(half, full)); // middle to bottom
                this.draw_on_button(e, middle, new Point(full, half)); // middle to right
                return;
            }
            if (b.Location.X == this.buttonSize * (this.planeSize - 1)) // right side
            {
                this.draw_on_button(e, middle, new Point(half, zero)); // middle to top 
                this.draw_on_button(e, middle, new Point(half, full)); // middle to bottom
                this.draw_on_button(e, middle, new Point(zero, half)); // middle to left
                return;
            }
            if (b.Location.Y == 0) // top side
            {
                this.draw_on_button(e, middle, new Point(half, full)); // middle to bottom
                this.draw_on_button(e, middle, new Point(zero, half)); // middle to left
                this.draw_on_button(e, middle, new Point(full, half)); // middle to right
                return;
            }
            if (b.Location.Y == this.buttonSize * (this.planeSize - 1)) // bottom side
            {
                this.draw_on_button(e, middle, new Point(half, zero)); // middle to top 
                this.draw_on_button(e, middle, new Point(zero, half)); // middle to left
                this.draw_on_button(e, middle, new Point(full, half)); // middle to right
                return;
            }


            /*  Draw Middle  */
            this.draw_on_button(e, middle, new Point(half, zero)); // middle to top 
            this.draw_on_button(e, middle, new Point(half, full)); // middle to bottom
            this.draw_on_button(e, middle, new Point(zero, half)); // middle to left
            this.draw_on_button(e, middle, new Point(full, half)); // middle to right
        }
    }
}
