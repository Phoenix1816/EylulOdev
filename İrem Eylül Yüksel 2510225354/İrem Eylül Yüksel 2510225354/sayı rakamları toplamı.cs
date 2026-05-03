using System;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class sayı_rakamları_toplamı : Form
    {
        TextBox textBox1;
        Button button1;
        Label label1;

        public sayı_rakamları_toplamı()
        {
            InitializeComponent();
            KontrolleriOlustur();
        }

        private void KontrolleriOlustur()
        {
            // TextBox
            textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(20, 20);
            textBox1.Width = 150;
            this.Controls.Add(textBox1);

            // Button
            button1 = new Button();
            button1.Text = "Hesapla";
            button1.Location = new System.Drawing.Point(20, 60);
            button1.Click += button1_Click;
            this.Controls.Add(button1);

            // Label
            label1 = new Label();
            label1.Location = new System.Drawing.Point(20, 100);
            label1.Width = 250;
            label1.Text = "Rakamlar toplamı: ";
            this.Controls.Add(label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sayi = textBox1.Text;
            int toplam = 0;

            // sadece rakam kontrolü
            foreach (char c in sayi)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Lütfen sadece sayı giriniz!");
                    return;
                }

                toplam += c - '0';
            }

            label1.Text = "Rakamlar toplamı: " + toplam;
        }
    }
}