using System.Diagnostics;

namespace dane_ludzi
{
    public partial class Form1 : Form
    {
        String text;
        String savedTo = "";
        public Form1()
        {
            InitializeComponent();
        }
        private bool buildPerson()
        {
            if (this.tb_imie.Text != "") text += this.tb_imie.Text + ", ";
            else
            {
                MessageBox.Show("Wpisz imię");
                return false;
            }

            if (this.tb_nazwisko.Text != "") text += this.tb_nazwisko.Text + ", ";
            else
            {
                MessageBox.Show("Wpisz nazwisko");
                return false;
            }
            if (this.rb_male.Checked) text += "male" + ", ";
            else if (this.rb_female.Checked) text += "female" + ", ";
            else if (this.rb_other.Checked) text += "other" + ", ";
            else
            {
                MessageBox.Show("Zaznacz swoją płeć");
                return false;
            }
            text += this.birth.Value.ToString("yyyy-MM-dd") + ", ";
            text += this.height.Value.ToString() + ", "; ;
            if (this.eye_color.Text != "") text += this.eye_color.Text + ", ";
            else
            {
                MessageBox.Show("Wybierz kolor oczu");
                return false;
            }
            if (this.street.Text != "") text += this.street.Text + ", ";
            else
            {
                MessageBox.Show("Wpisz nazwę ulicy");
                return false;
            }
            if (this.mail_code.Text != "") text += this.mail_code.Text + ", ";
            else
            {
                MessageBox.Show("Wpisz kod pocztowy");
                return false;
            }
            if (this.city.Text != "") text += this.city.Text + ", ";
            else
            {
                MessageBox.Show("Wpisz nazwę miasta");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.buildPerson()) return;
            this.informations_out.Text = this.text;
        }

        private void clipboard_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.informations_out.Text);
        }

        private void noweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.informations_out.Text = "";
            this.tb_imie.Text = "";
            this.tb_nazwisko.Text = "";
            this.birth.Text = DateTime.Now.ToString();
            this.rb_male.Checked = false;
            this.rb_female.Checked = false;
            this.rb_other.Checked = false;
            this.height.Value = 170;
            this.eye_color.Text = "";
            this.street.Text = "";
            this.mail_code.Text = "";
            this.city.Text = "";
            this.savedTo = "";
        }

        private void saveToFile(String path)
        {
            if (!this.buildPerson()) return;
            StreamWriter file = new StreamWriter(path);
            file.WriteLineAsync(this.text);
            file.Close();
            savedTo = path;
        }

        private void readFromFile(String path)
        {
            StreamReader file = new StreamReader(path);
            this.text = file.ReadToEnd();

            String[] splited = this.text.Split(new char[] { ',', ' ' });

            this.tb_imie.Text = splited[0];

            this.tb_nazwisko.Text = splited[1];
            if (splited[2] == "male") this.rb_male.Checked = true;
            else if (splited[2] == "female") this.rb_female.Checked = true;
            else if (splited[2] == "other") this.rb_other.Checked = true;
/*
            text += this.birth.Value.ToString("yyyy-MM-dd") + ", ";
            text += this.height.Value.ToString() + ", ";
            this.eye_color.Text != ""
            this.street.Text != ""
            this.mail_code.Text != ""
            this.city.Text != ""*/
            file.Close();
            savedTo = path;
        }

        

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.savedTo == "") // nie było zapisywane
            {
                this.saveFileDialog1.FileName = "dane.csv";
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.saveToFile(this.saveFileDialog1.FileName);
                }
            }
            else // było już zapisywane
            {
                this.saveToFile(this.saveFileDialog1.FileName);
            }
            
        }

        private void zapiszAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.savedTo == "")
                this.saveFileDialog1.FileName = "dane.csv";
            else
                this.saveFileDialog1.FileName = this.savedTo;
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.saveToFile(this.saveFileDialog1.FileName);
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.savedTo == "")
                this.openFileDialog1.FileName = "dane.csv";
            else
                this.openFileDialog1.FileName = savedTo;
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.readFromFile(this.openFileDialog1.FileName);
            }
        }
    }
}