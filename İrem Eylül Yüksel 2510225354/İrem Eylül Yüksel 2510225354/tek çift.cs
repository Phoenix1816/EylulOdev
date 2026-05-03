using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class tek_cift : Form
    {
        List<int> sayilar = new List<int>();

        public tek_cift()
        {
            InitializeComponent();
        }

        // Sayı ekleme butonu
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int sayi))
            {
                sayilar.Add(sayi);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir tam sayı giriniz.");
            }
        }

        // Tek / Çift ayırma butonu
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Tekler
            listBox2.Items.Clear(); // Çiftler

            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    listBox2.Items.Add(sayi); // Çift
                }
                else
                {
                    listBox1.Items.Add(sayi); // Tek
                }
            }
        }
    }
}