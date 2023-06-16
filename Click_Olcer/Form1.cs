using System;
using System.Windows.Forms;

namespace Click_Olcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0;
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz");
            }
            else
            {
                textBox1.Enabled = false;
                timer1.Enabled = true;
                sayi++;
                button1.Text = sayi.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString();
            if (sayac <= 0)
            {
                button1.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show(textBox1.Text + " Saniyede " + button1.Text + " defa tıkladınız.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            if (textBox1.Text != "")
            {
                sayac = int.Parse(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = 0;
            sayac = 0;
            textBox1.Enabled = true;
            button1.Enabled = true;
            timer1.Enabled = false;
            textBox1.Text = "0";
            label1.Text = "-";
            button1.Text = "";
        }

    }
}
