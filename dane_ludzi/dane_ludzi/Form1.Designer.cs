namespace dane_ludzi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mail_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.eye_color = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_other = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.tb_nazwisko = new System.Windows.Forms.TextBox();
            this.tb_imie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.informations_out = new System.Windows.Forms.TextBox();
            this.clipboard_copy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.eye_color);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.birth);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tb_nazwisko);
            this.groupBox1.Controls.Add(this.tb_imie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generator osób:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data urodzenia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 117);
            this.button1.TabIndex = 11;
            this.button1.Text = "Utwórz Osobę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.city);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mail_code);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.street);
            this.groupBox3.Location = new System.Drawing.Point(6, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 124);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Miasto";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(55, 80);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(90, 23);
            this.city.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kod pocztowy";
            // 
            // mail_code
            // 
            this.mail_code.Location = new System.Drawing.Point(88, 51);
            this.mail_code.Name = "mail_code";
            this.mail_code.Size = new System.Drawing.Size(57, 23);
            this.mail_code.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ulica";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(45, 22);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 23);
            this.street.TabIndex = 0;
            // 
            // eye_color
            // 
            this.eye_color.FormattingEnabled = true;
            this.eye_color.Items.AddRange(new object[] {
            "niebieskie",
            "zielone",
            "szare",
            "brązowe",
            "czarne",
            "białe"});
            this.eye_color.Location = new System.Drawing.Point(196, 152);
            this.eye_color.Name = "eye_color";
            this.eye_color.Size = new System.Drawing.Size(121, 23);
            this.eye_color.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kolor oczu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wzrost";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(197, 123);
            this.height.Maximum = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(120, 23);
            this.height.TabIndex = 6;
            this.height.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(94, 77);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(223, 23);
            this.birth.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_other);
            this.groupBox2.Controls.Add(this.rb_female);
            this.groupBox2.Controls.Add(this.rb_male);
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Płeć:";
            // 
            // rb_other
            // 
            this.rb_other.AutoSize = true;
            this.rb_other.Location = new System.Drawing.Point(6, 72);
            this.rb_other.Name = "rb_other";
            this.rb_other.Size = new System.Drawing.Size(83, 19);
            this.rb_other.TabIndex = 2;
            this.rb_other.TabStop = true;
            this.rb_other.Text = "coś innego";
            this.rb_other.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(6, 47);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(67, 19);
            this.rb_female.TabIndex = 1;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "typiarka";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(6, 22);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(54, 19);
            this.rb_male.TabIndex = 0;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "typek";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // tb_nazwisko
            // 
            this.tb_nazwisko.Location = new System.Drawing.Point(69, 51);
            this.tb_nazwisko.Name = "tb_nazwisko";
            this.tb_nazwisko.Size = new System.Drawing.Size(100, 23);
            this.tb_nazwisko.TabIndex = 3;
            // 
            // tb_imie
            // 
            this.tb_imie.Location = new System.Drawing.Point(69, 22);
            this.tb_imie.Name = "tb_imie";
            this.tb_imie.Size = new System.Drawing.Size(100, 23);
            this.tb_imie.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // informations_out
            // 
            this.informations_out.Location = new System.Drawing.Point(355, 27);
            this.informations_out.Multiline = true;
            this.informations_out.Name = "informations_out";
            this.informations_out.Size = new System.Drawing.Size(241, 305);
            this.informations_out.TabIndex = 1;
            // 
            // clipboard_copy
            // 
            this.clipboard_copy.Location = new System.Drawing.Point(355, 338);
            this.clipboard_copy.Name = "clipboard_copy";
            this.clipboard_copy.Size = new System.Drawing.Size(241, 29);
            this.clipboard_copy.TabIndex = 13;
            this.clipboard_copy.Text = "Skopiuj do schowka";
            this.clipboard_copy.UseVisualStyleBackColor = true;
            this.clipboard_copy.Click += new System.EventHandler(this.clipboard_copy_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.edytujToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noweToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.toolStripSeparator,
            this.zapiszToolStripMenuItem,
            this.zapiszAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.zakończToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // noweToolStripMenuItem
            // 
            this.noweToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noweToolStripMenuItem.Image")));
            this.noweToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.noweToolStripMenuItem.Name = "noweToolStripMenuItem";
            this.noweToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.noweToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noweToolStripMenuItem.Text = "&Nowe";
            this.noweToolStripMenuItem.Click += new System.EventHandler(this.noweToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otwórzToolStripMenuItem.Image")));
            this.otwórzToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otwórzToolStripMenuItem.Text = "&Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zapiszToolStripMenuItem.Image")));
            this.zapiszToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszToolStripMenuItem.Text = "&Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszAsToolStripMenuItem
            // 
            this.zapiszAsToolStripMenuItem.Name = "zapiszAsToolStripMenuItem";
            this.zapiszAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszAsToolStripMenuItem.Text = "Zapisz &As";
            this.zapiszAsToolStripMenuItem.Click += new System.EventHandler(this.zapiszAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakończToolStripMenuItem.Text = "&Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.edytujToolStripMenuItem.Text = "&Edytuj";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.clipboard_copy_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 382);
            this.Controls.Add(this.clipboard_copy);
            this.Controls.Add(this.informations_out);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Projekt2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_nazwisko;
        private TextBox tb_imie;
        private Label label2;
        private Label label1;
        private DateTimePicker birth;
        private GroupBox groupBox2;
        private RadioButton rb_other;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private Label label3;
        private NumericUpDown height;
        private ComboBox eye_color;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox street;
        private Button button1;
        private Label label7;
        private TextBox city;
        private Label label6;
        private TextBox mail_code;
        private Label label8;
        private TextBox informations_out;
        private Button clipboard_copy;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem noweToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem zapiszAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private ToolStripMenuItem edytujToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}