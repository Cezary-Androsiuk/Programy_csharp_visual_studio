using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {
        int[,] plane = new int[3, 3];
        int currentMove = 1;
        int moveCount = 0;

        public Form1()
        {
            InitializeComponent();

        }

        int checkRowSum(int sum)
        {
            this.label10.Text += sum.ToString() + "\n";
            if (sum == 30)
            {
                return 1;
            }
            else if (sum == 3)
            {
                return 2;
            }
            return -1;
        }

        int checkPlane()
        {
            int checkResult = -1;
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    sum += this.plane[i, j];
                checkResult = this.checkRowSum(sum);
                if (checkResult != -1) return checkResult;
                sum = 0;

                for (int j = 0; j < 3; j++)
                    sum += this.plane[j, i];
                checkResult = this.checkRowSum(sum);
                if (checkResult != -1) return checkResult;
                sum = 0;
            }

            for (int i = 0; i < 3; i++)
                sum += this.plane[i, i];
            checkResult = this.checkRowSum(sum);
            if (checkResult != -1) return checkResult;
            sum = 0;

            for (int i = 0; i < 3; i++)
                sum += this.plane[3 - 1 - i, 3 - 1 - i];
            checkResult = this.checkRowSum(sum);
            if (checkResult != -1) return checkResult;
            sum = 0;

            if (this.moveCount == 9)
            {
                return 3;
            }
            return -1;
        }

        void buildLabel(Label label, int x, int y)
        {
            label.Text = (this.currentMove == 1 ? "X" : "O") + " na (" + x.ToString() + "," + y.ToString() + ")";
            label.Visible = true;
        }

        void drawOnButton(Button button)
        {
            button.Tag = this.currentMove;
            button.Text = (this.currentMove == 1 ? "X" : "O");
        }

        void handleEndGame(int endCase)
        {
            DialogResult result;
            switch (endCase)
            {
                case 1: // O win
                    result = MessageBox.Show("O win!", "GAME OVER", MessageBoxButtons.OKCancel);
                    break;
                case 2: // X win
                    result = MessageBox.Show("X win!", "GAME OVER", MessageBoxButtons.OKCancel);
                    break;
                case 3: // Draw
                    result = MessageBox.Show("Draw!", "GAME OVER", MessageBoxButtons.OKCancel);
                    break;
                default:
                    result = MessageBox.Show("ERROR!", "GAME OVER", MessageBoxButtons.OKCancel);
                    break;
            }
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //clear
                b1.Text = "";
                b1.Tag = 0;
                b2.Text = "";
                b2.Tag = 0;
                b3.Text = "";
                b3.Tag = 0;
                b4.Text = "";
                b4.Tag = 0;
                b5.Text = "";
                b5.Tag = 0;
                b6.Text = "";
                b6.Tag = 0;
                b7.Text = "";
                b7.Tag = 0;
                b8.Text = "";
                b8.Tag = 0;
                b9.Text = "";
                b9.Tag = 0;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;

                this.plane = new int[3, 3];
                this.currentMove = 1;
                this.moveCount = 0;
            }

        } 

        void wykonajRuch(object button, int x, int y)
        {
            if (plane[x, y] == 0)
            {
                this.label10.Text = "";
                this.moveCount++;
                switch (moveCount)
                {
                    case 1: buildLabel(this.label1, x, y); break;
                    case 2: buildLabel(this.label2, x, y); break;
                    case 3: buildLabel(this.label3, x, y); break;
                    case 4: buildLabel(this.label4, x, y); break;
                    case 5: buildLabel(this.label5, x, y); break;
                    case 6: buildLabel(this.label6, x, y); break;
                    case 7: buildLabel(this.label7, x, y); break;
                    case 8: buildLabel(this.label8, x, y); break;
                    case 9: buildLabel(this.label9, x, y); break;
                }

                plane[x, y] = currentMove;

                this.drawOnButton((Button)button);

                int checkedPlane = this.checkPlane();
                if (checkedPlane != -1)
                    this.handleEndGame(checkedPlane);
                

                if (currentMove == 1)
                    currentMove = 10;
                else
                    currentMove = 1;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.b1))
            {
                this.wykonajRuch(sender, 0, 0);
            }
            else if (sender.Equals(this.b2))
            {
                this.wykonajRuch(sender, 1, 0);
            }
            else if (sender.Equals(this.b3))
            {
                this.wykonajRuch(sender, 2, 0);
            }
            else if (sender.Equals(this.b4))
            {
                this.wykonajRuch(sender, 0, 1);
            }
            else if (sender.Equals(this.b5))
            {
                this.wykonajRuch(sender, 1, 1);
            }
            else if (sender.Equals(this.b6))
            {
                this.wykonajRuch(sender, 2, 1);
            }
            else if (sender.Equals(this.b7))
            {
                this.wykonajRuch(sender, 0, 2);
            }
            else if (sender.Equals(this.b8))
            {
                this.wykonajRuch(sender, 1, 2);
            }
            else if (sender.Equals(this.b9))
            {
                this.wykonajRuch(sender, 2, 2);
            }
        }
    }
}
