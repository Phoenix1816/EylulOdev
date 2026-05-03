using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class çarpım_tablosu : Form
    {
        private List<ListBox> listBoxes = new List<ListBox>();
        private Button btnOlustur;

        public çarpım_tablosu()
        {
            InitializeComponent();

            // 9 adet ListBox'ı yatay olarak ekle
            for (int i = 0; i < 9; i++)
            {
                ListBox lb = new ListBox();
                lb.Name = $"listBox{i + 1}";
                lb.Size = new System.Drawing.Size(90, 180);
                lb.Location = new System.Drawing.Point(10 + i * 95, 10);
                this.Controls.Add(lb);
                listBoxes.Add(lb);
            }

            // Button ekle
            btnOlustur = new Button();
            btnOlustur.Text = "Çarpım Tablosu Oluştur";
            btnOlustur.Size = new System.Drawing.Size(200, 30);
            btnOlustur.Location = new System.Drawing.Point(10, 200);
            btnOlustur.Click += BtnOlustur_Click;
            this.Controls.Add(btnOlustur);
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            // Tüm ListBox'ları temizle
            foreach (var lb in listBoxes)
                lb.Items.Clear();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    string sonuc = $"{i} x {j} = {i * j}";
                    listBoxes[i - 1].Items.Add(sonuc);
                }
            }
        }
    }
}
