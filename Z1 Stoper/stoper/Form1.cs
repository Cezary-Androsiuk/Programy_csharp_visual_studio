using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoper
{
    public partial class Form1 : Form
    {
        int czas;
        bool running;
        int laps;
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = "00:00:00";
            this.label2.Text = "";
            this.button1.Text = "Start";
            this.button2.Text = "Reset";
            this.czas = 0;
            this.running = false;
            this.laps = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czas++;
            if(czas % 10 == 0 || true)
            {
                int _ms = czas        % 100;
                int _s = (czas / 100) % 60;
                int _m = (czas / 600) % 60;
                int _h = (czas / 36_000);
                String ms = (_ms < 10 ? "0" + _ms.ToString() : _ms.ToString());
                String s = (_s < 10 ? "0" + _s.ToString() : _s.ToString());
                String m = (_m < 10 ? "0" + _m.ToString() : _m.ToString());
                String h = (_h != 0 ? _h.ToString() + ":" : "");
                this.label1.Text = h + m + ":" + s + ":" + ms;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!this.running)
            {
                this.timer1.Start();
                this.button1.Text = "Stop";
                this.button2.Text = "Lap";
                this.running = true;
            }
            else
            {
                this.timer1.Stop();
                this.button1.Text = "Start";
                this.button2.Text = "Reset";
                this.running = false;
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!this.running)
            {
                this.label1.Text = "00:00:00";
                this.label2.Text = "";
            }
            else
            {
                if (this.laps > 10)
                    this.label2.Text = this.label2.Text.Remove(0,this.label2.Text.IndexOf("\n")+1);
                this.label2.Text += this.label1.Text + "\n";
                this.laps++;
            }
        }
    }
}
