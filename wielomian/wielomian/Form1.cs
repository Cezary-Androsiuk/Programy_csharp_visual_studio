using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace wielomian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.numericUpDown11_ValueChanged(this, EventArgs.Empty);
            this.button1_Click(this, EventArgs.Empty);
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            this.nud2.Visible = false;
            this.l2.Visible = false;
            this.nud3.Visible = false;
            this.l3.Visible = false;
            this.nud4.Visible = false;
            this.l4.Visible = false;
            this.nud5.Visible = false;
            this.l5.Visible = false;
            this.nud6.Visible = false;
            this.l6.Visible = false;
            this.nud7.Visible = false;
            this.l7.Visible = false;
            this.nud8.Visible = false;
            this.l8.Visible = false;
            this.nud9.Visible = false;
            this.l9.Visible = false;
            this.nud10.Visible = false;
            this.l10.Visible = false;
            this.nud11.Visible = false;
            this.l11.Visible = false;
            
            // użył bym case ale tutaj nie można przechodzić po instrukcjach w dół (wymagany jest break;)
            if(numericUpDown1.Value > 0)
            {
                this.nud2.Visible = true;
                this.l2.Visible = true;
                if (numericUpDown1.Value > 1)
                {
                    this.nud3.Visible = true;
                    this.l3.Visible = true;
                    if (numericUpDown1.Value > 2)
                    {
                        this.nud4.Visible = true;
                        this.l4.Visible = true;
                        if (numericUpDown1.Value > 3)
                        {
                            this.nud5.Visible = true;
                            this.l5.Visible = true;
                            if (numericUpDown1.Value > 4)
                            {
                                this.nud6.Visible = true;
                                this.l6.Visible = true;
                                if (numericUpDown1.Value > 5)
                                {
                                    this.nud7.Visible = true;
                                    this.l7.Visible = true;
                                    if (numericUpDown1.Value > 6)
                                    {
                                        this.nud8.Visible = true;
                                        this.l8.Visible = true;
                                        if (numericUpDown1.Value > 7)
                                        {
                                            this.nud9.Visible = true;
                                            this.l9.Visible = true;
                                            if (numericUpDown1.Value > 8)
                                            {
                                                this.nud10.Visible = true;
                                                this.l10.Visible = true;
                                                if (numericUpDown1.Value > 9)
                                                {
                                                    this.nud11.Visible = true;
                                                    this.l11.Visible = true;
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private double function(int x)
        {
            double y = 0;
            if (nud1.Visible) y += (double)nud1.Value;
            if (nud2.Visible) y += (double)nud2.Value * Math.Pow(x, 1);
            if (nud3.Visible) y += (double)nud3.Value * Math.Pow(x, 2);
            if (nud4.Visible) y += (double)nud4.Value * Math.Pow(x, 3);
            if (nud5.Visible) y += (double)nud5.Value * Math.Pow(x, 4);
            if (nud6.Visible) y += (double)nud6.Value * Math.Pow(x, 5);
            if (nud7.Visible) y += (double)nud7.Value * Math.Pow(x, 6);
            if (nud8.Visible) y += (double)nud8.Value * Math.Pow(x, 7);
            if (nud9.Visible) y += (double)nud9.Value * Math.Pow(x, 8);
            if (nud10.Visible) y += (double)nud10.Value * Math.Pow(x, 9);
            if (nud11.Visible) y += (double)nud11.Value * Math.Pow(x, 10);

            return y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.function();
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Zaznacz obszar żeby przybliżyć");
            Series series = this.chart1.Series.Add("wykres wielomimianu");
            series.ChartType = SeriesChartType.Spline;
            for(int i=-1000; i<=1000; i++)
            {
                series.Points.AddXY(i, this.function(i));
            }
            ChartArea ca = this.chart1.ChartAreas[0];
            ca.AxisX.ScaleView.Zoomable = true;
            ca.CursorX.AutoScroll = true;
            ca.CursorX.IsUserSelectionEnabled = true;
            ca.AxisY.ScaleView.Zoomable = true;
            ca.CursorY.AutoScroll = true;
            ca.CursorY.IsUserSelectionEnabled = true;
        }

        private void nud1_ValueChanged(object sender, EventArgs e)
        {
            this.button1_Click(sender, e);
        }

    }
}
