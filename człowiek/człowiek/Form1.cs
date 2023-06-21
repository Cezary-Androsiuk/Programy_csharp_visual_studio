using System.Security.Cryptography.X509Certificates;

namespace człowiek
{
   
    public partial class Form1 : Form
    {
        int nr_person;
        List<Czlowiek> mieszkancy;
        void updateFormEnv()
        {
            this.toolStripTextBox1.Text = this.nr_person.ToString(); 
            if (this.mieszkancy[nr_person] is Kierownik)
            {
                Kierownik k = (Kierownik)mieszkancy[this.nr_person];
                this.textBox1.Text = this.mieszkancy[nr_person].getImie();
                this.textBox2.Text = this.mieszkancy[nr_person].getNazwisko();
                this.dateTimePicker1.Value = this.mieszkancy[nr_person].getDataUrodzenia();
                this.groupBox1.Visible = true;
                this.comboBox1.Text = k.getStanowisko().ToString();
                this.numericUpDown1.Text = k.getWynagrodzenie().ToString();
                this.groupBox2.Visible = true;
                this.comboBox2.Text = k.getDzialZarzadzany().ToString();
            }
            else if (this.mieszkancy[nr_person] is Pracownik)
            {
                Pracownik p = (Pracownik)mieszkancy[this.nr_person];
                this.textBox1.Text = p.getImie();
                this.textBox2.Text = p.getNazwisko();
                this.dateTimePicker1.Value = p.getDataUrodzenia();
                this.groupBox1.Visible = true;
                this.comboBox1.Text = p.getStanowisko().ToString();
                this.numericUpDown1.Text = p.getWynagrodzenie().ToString();
                this.groupBox2.Visible = false;
            }
            else if (this.mieszkancy[nr_person] is Czlowiek)
            {
                Czlowiek c = mieszkancy[this.nr_person];
                this.textBox1.Text = c.getImie();
                this.textBox2.Text = c.getNazwisko();
                this.dateTimePicker1.Value = c.getDataUrodzenia();
                this.groupBox1.Visible = false;
                this.groupBox2.Visible = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.nr_person= 0;
            this.mieszkancy = new List<Czlowiek>();
            this.mieszkancy.Add(new Czlowiek("staś11", "stasienki11", DateTime.Now));
            this.mieszkancy.Add(new Czlowiek("staś12", "stasienki12", DateTime.Now));
            this.mieszkancy.Add(new Czlowiek("staś13", "stasienki13", DateTime.Now));
            this.mieszkancy.Add(new Czlowiek("staś14", "stasienki14", DateTime.Now));

            this.mieszkancy.Add(new Pracownik("staś21", "stasienki21", DateTime.Now, Stanowisko.Programista, 1001));
            this.mieszkancy.Add(new Pracownik("staś22", "stasienki22", DateTime.Now, Stanowisko.Tester, 1002));
            this.mieszkancy.Add(new Pracownik("staś23", "stasienki23", DateTime.Now, Stanowisko.Senior, 1003));
            this.mieszkancy.Add(new Pracownik("staś24", "stasienki24", DateTime.Now, Stanowisko.Programista, 1004));

            this.mieszkancy.Add(new Kierownik("staś31", "stasienki31", DateTime.Now, Stanowisko.Kierownik, 2001, Dzial.IT));
            this.mieszkancy.Add(new Kierownik("staś32", "stasienki32", DateTime.Now, Stanowisko.Kierownik, 2002, Dzial.Techniczny));
            this.mieszkancy.Add(new Kierownik("staś33", "stasienki33", DateTime.Now, Stanowisko.Kierownik, 2003, Dzial.Bazy));
            this.mieszkancy.Add(new Kierownik("staś34", "stasienki34", DateTime.Now, Stanowisko.Kierownik, 2004, Dzial.Sieci));

            this.updateFormEnv();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            this.nr_person = 0;
            this.updateFormEnv();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.nr_person = this.mieszkancy.Count()-1;
            this.updateFormEnv();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(this.nr_person > 0)
                this.nr_person--;
            this.updateFormEnv();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (this.nr_person < this.mieszkancy.Count() - 1)
                this.nr_person++;
            this.updateFormEnv();
        }
    }

    enum Stanowisko
    {
        Kierownik,
        Programista,
        Tester,
        Senior
    };
    enum Dzial
    {
        IT,
        Techniczny,
        Bazy,
        Sieci
    };
    class Czlowiek
    {
        protected String imie;
        protected String nazwisko;
        protected DateTime dataUrodzenia;

        public Czlowiek(string imie, string nazwisko, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }
        public String getImie() { return this.imie; }
        public String getNazwisko() { return this.nazwisko; }
        public DateTime getDataUrodzenia() { return this.dataUrodzenia; }
        public void setImie(String imie) {  this.imie =imie; }
        public void setNazwisko(String nazwisko) { this.nazwisko = nazwisko; }
        public void setDataUrodzenia(DateTime dataUrodzenia) { this.dataUrodzenia = dataUrodzenia; }
    }
    class Pracownik : Czlowiek
    {
        protected Stanowisko stanowisko;
        protected int wynagrodzenie;

        public Pracownik(string imie, string nazwisko, DateTime dataUrodzenia, Stanowisko stanowisko, int wynagrodzenie) : 
            base(imie, nazwisko, dataUrodzenia)
        {
            this.stanowisko = stanowisko;
            this.wynagrodzenie = wynagrodzenie;
        }
        public Stanowisko getStanowisko() { return this.stanowisko; }
        public void setStanowisko(Stanowisko stanowisko) { this.stanowisko = stanowisko; }
        public int getWynagrodzenie() { return this.wynagrodzenie; }
        public void setWynagrodzenie(int wynagrodzenie) { this.wynagrodzenie = wynagrodzenie; }
    }
    class Kierownik : Pracownik
    {
        public Dzial dzialZarzadzany;
        public Kierownik(string imie, string nazwisko, DateTime dataUrodzenia, Stanowisko stanowisko, int wynagrodzenie, Dzial dzialZarzadzany) :
            base(imie, nazwisko, dataUrodzenia, stanowisko, wynagrodzenie)
        {
            this.dzialZarzadzany = dzialZarzadzany;
        }
        public Dzial getDzialZarzadzany() { return this.dzialZarzadzany; }
        public void setDzialZarzadzany(Dzial dzialZarzadzany) { this.dzialZarzadzany = dzialZarzadzany; }
    }
}