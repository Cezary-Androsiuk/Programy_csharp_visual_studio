using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zegar
{
    public partial class Form1 : Form
    {
        long interval = 0;
        float clockFaceRadius = 130f;
        float secondArrowLength = 120f;
        float minuteArrowLength = 100f;
        float hourArrowLength = 60f;

        // const float ratio = 2f * (float)Math.PI;

        public Form1()
        {
            InitializeComponent();

            DateTime dt = DateTime.Now;
            this.interval = dt.Second + dt.Minute * 60 + dt.Hour * 60 * 60;
            this.label1.Text = dt.Hour.ToString() + " : " + dt.Minute.ToString() + " : " + dt.Second.ToString();
        }

        private PointF secondArrowTipPos()
        {
            double seconds = this.interval % 60;
            double rot = (seconds / 60f) * 2d * Math.PI;
            float x, y;
            x = (float) Math.Sin(rot);
            y = (float) Math.Cos(rot);
            return new PointF(this.clockFaceRadius + x * this.secondArrowLength, this.clockFaceRadius - y * this.secondArrowLength);
        }

        private PointF minuteArrowTipPos()
        {
            double minutes = this.interval % 3600;
            double rot = (minutes / 3600f) * 2d * Math.PI;
            float x, y;
            x = (float) Math.Sin(rot);
            y = (float) Math.Cos(rot);
            return new PointF(this.clockFaceRadius + x * this.minuteArrowLength, this.clockFaceRadius - y * this.minuteArrowLength);
        }

        private PointF hourArrowTipPos()
        {
            double hours = this.interval % 43200;
            double rot = (hours / 43200f) * 2d * Math.PI;
            float x, y;
            x = (float) Math.Sin(rot);
            y = (float) Math.Cos(rot);
            return new PointF(this.clockFaceRadius + x * this.hourArrowLength, this.clockFaceRadius - y * this.hourArrowLength);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            // clock face
            e.Graphics.DrawEllipse(Pens.Black, 0, 0, this.clockFaceRadius * 2, this.clockFaceRadius * 2);


            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(this.clockFaceRadius, clockFaceRadius), secondArrowTipPos());

            e.Graphics.DrawLine(new Pen(Color.Black, 2), new PointF(this.clockFaceRadius, clockFaceRadius), minuteArrowTipPos());

            e.Graphics.DrawLine(new Pen(Color.Black, 3), new PointF(this.clockFaceRadius, clockFaceRadius), hourArrowTipPos());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();

            this.interval++;

            if(this.interval >= (60 + 60*60 + 60*60*23)) // 24h loop
                this.interval = 0;

            // hidden on the right 
            DateTime dt = DateTime.Now;
            this.label1.Text = dt.Hour.ToString() + " : " + dt.Minute.ToString() + " : " + dt.Second.ToString();
            this.label2.Text = ((interval / 3600) % 24).ToString() + " : " + ((interval / 60) % 60).ToString() + " : " + ((interval) % 60).ToString();
        }
    }
}
