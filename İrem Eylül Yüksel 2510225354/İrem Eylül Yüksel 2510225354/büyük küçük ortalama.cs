using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class büyük_küçük_ortalama : Form
    {
        public büyük_küçük_ortalama()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            var text = inputTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Lütfen en az bir sayı girin.");
                return;
            }

            var parts = text.Split(new[] { ',', ';', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<double>();
            foreach (var p in parts)
            {
                if (double.TryParse(p, out var v))
                    list.Add(v);
                else
                {
                    MessageBox.Show($"Geçersiz sayı: {p}");
                    return;
                }
            }

            if (list.Count == 0)
            {
                MessageBox.Show("Geçerli sayı bulunamadı.");
                return;
            }

            double min = double.MaxValue;
            double max = double.MinValue;
            double toplam = 0;
            foreach (var v in list)
            {
                if (v < min) min = v;
                if (v > max) max = v;
                toplam += v;
            }

            double ort = toplam / list.Count;
            double kareToplam = 0;
            foreach (var v in list)
                kareToplam += (v - ort) * (v - ort);
            double std = Math.Sqrt(kareToplam / list.Count);

            resultLabel.Text = $"Adet: {list.Count}\nEn Küçük: {min}\nEn Büyük: {max}\nOrtalama: {ort:F4}\nStandart Sapma: {std:F4}";
        }
    }
}
