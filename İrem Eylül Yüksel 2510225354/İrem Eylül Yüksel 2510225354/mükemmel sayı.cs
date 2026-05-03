using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class mükemmel_sayı : Form
    {
        private TextBox textBox1;
        private Button button1;
        private Label label1;

        public mükemmel_sayı()
        {
            InitializeComponent();
            KontrolleriOlustur();
        }

        private void KontrolleriOlustur()
        {
            // TextBox
            textBox1 = new TextBox();
            textBox1.Top = 20;
            textBox1.Left = 20;
            textBox1.Width = 150;
            this.Controls.Add(textBox1);

            // Button
            button1 = new Button();
            button1.Text = "Kontrol Et";
            button1.Top = 60;
            button1.Left = 20;
            button1.Click += button1_Click;
            this.Controls.Add(button1);

            // Label
            label1 = new Label();
            label1.Text = "Sonuç: ";
            label1.Top = 100;
            label1.Left = 20;
            label1.Width = 250;
            this.Controls.Add(label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            if (!int.TryParse(textBox1.Text, out sayi) || sayi < 1)
            {
                MessageBox.Show("Lütfen pozitif bir tam sayı giriniz!");
                return;
            }
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                    toplam += i;
            }
            if (toplam == sayi)
                label1.Text = sayi + " mükemmel sayıdır.";
            else
                label1.Text = sayi + " mükemmel sayı değildir.";
        }
    }
}
