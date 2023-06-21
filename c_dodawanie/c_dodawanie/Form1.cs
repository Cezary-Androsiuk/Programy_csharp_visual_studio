namespace c_dodawanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                if (rb_dodawanie.Checked)
                {
                    result = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                }
                else if (radioButton2.Checked)
                {
                    result = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                }
                else if (radioButton3.Checked)
                {
                    result = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                }
                else if (radioButton4.Checked)
                {
                    if (int.Parse(textBox2.Text) == 0)
                    {
                        label3.Text = "inf";
                        return;
                    }
                    result = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                }
                else if (radioButton5.Checked)
                {
                    if (int.Parse(textBox2.Text) == 0)
                    {
                        label3.Text = "inf";
                        return;
                    }
                    result = int.Parse(textBox1.Text) % int.Parse(textBox2.Text);
                }
                label3.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("integers only!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("small integers only!");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_dodawanie.Checked)
            {
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.rb_dodawanie.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.rb_dodawanie.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton4.Checked = false;
                this.radioButton5.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                this.rb_dodawanie.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton5.Checked = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                this.rb_dodawanie.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                this.radioButton4.Checked = false;
            }
        }
    }
}