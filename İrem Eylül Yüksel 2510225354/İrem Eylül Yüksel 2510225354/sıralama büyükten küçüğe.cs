using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class sıralama_büyükten_küçüğe : Form
    {
        public sıralama_büyükten_küçüğe()
        {
            InitializeComponent();
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            var text = inputTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Lütfen en az bir sayı girin.");
                return;
            }

            var parts = text.Split(new[] { ',', ';', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();
            foreach (var p in parts)
            {
                if (int.TryParse(p, out var v)) list.Add(v);
                else { MessageBox.Show($"Geçersiz sayı: {p}"); return; }
            }

            if (list.Count == 0)
            {
                MessageBox.Show("Geçerli sayı bulunamadı.");
                return;
            }

            list.Sort();
            list.Reverse(); // büyükten küçüğe

            resultListBox.Items.Clear();
            foreach (var num in list)
                resultListBox.Items.Add(num);
        }

    }
}
