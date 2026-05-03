using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class not_gösterici : Form
    {
        private readonly List<int> notlar = new List<int>();

        // Eğer Designer boş ise kullanılacak kontroller
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;

        public not_gösterici()
        {
            InitializeComponent();
            EnsureControls();
        }

        // Designer'da kontroller yoksa burada oluşturup event ataması yapar
        private void EnsureControls()
        {
            // Eğer Designer zaten kontrolleri oluşturduysa (alanlar doluysa) işlem yapma
            if (this.textBox1 != null && this.pictureBox1 != null && this.button1 != null && this.button2 != null)
                return;

            // TextBox
            if (this.textBox1 == null)
            {
                textBox1 = new TextBox();
                textBox1.Left = 10;
                textBox1.Top = 10;
                textBox1.Width = 100;
                this.Controls.Add(textBox1);
            }

            // PictureBox
            if (this.pictureBox1 == null)
            {
                pictureBox1 = new PictureBox();
                pictureBox1.Left = 10;
                pictureBox1.Top = 50;
                pictureBox1.Width = 400;
                pictureBox1.Height = 200;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(pictureBox1);
            }

            // Button1 - Not Ekle
            if (this.button1 == null)
            {
                button1 = new Button();
                button1.Left = 120;
                button1.Top = 10;
                button1.Text = "Ekle";
                button1.Click += button1_Click;
                this.Controls.Add(button1);
            }

            // Button2 - Grafik
            if (this.button2 == null)
            {
                button2 = new Button();
                button2.Left = 200;
                button2.Top = 10;
                button2.Text = "Grafik";
                button2.Click += button2_Click;
                this.Controls.Add(button2);
            }
        }

        // Not ekleme (button1 event handler)
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int not))
            {
                notlar.Add(not);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Grafik çizme (button2 event handler)
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            using (Graphics g = pictureBox1.CreateGraphics())
            using (Pen kalem = new Pen(Color.Black))
            {
                Brush firca = Brushes.Blue;

                int genislik = 30;
                int baslangicX = 20;

                for (int i = 0; i < notlar.Count; i++)
                {
                    int yukseklik = notlar[i] * 2; // ölçekleme

                    g.FillRectangle(firca,
                        baslangicX + i * (genislik + 10),
                        pictureBox1.Height - yukseklik,
                        genislik,
                        yukseklik);

                    g.DrawString(notlar[i].ToString(),
                        new Font("Arial", 10),
                        Brushes.Black,
                        baslangicX + i * (genislik + 10),
                        pictureBox1.Height - yukseklik - 20);
                }
            }
        }
    }
}
