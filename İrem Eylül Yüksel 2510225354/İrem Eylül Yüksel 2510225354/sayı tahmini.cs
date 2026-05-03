using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class sayı_tahmini : Form
    {
        private Label label1;
        private Button button1;
        private int adim = 0;
        private readonly string[] adimlar = new string[]
        {
            "Bir sayı tut (bana söyleme!)",
            "Tuttuğun sayıyı 2 ile çarp.",
            "Sonuca 4 ekle.",
            "Şimdi sonucu 2'ye böl.",
            "Elde ettiğin sonuçtan tuttuğun sayıyı çıkar.",
            "Sonuç: 2 😎"
        };

        public sayı_tahmini()
        {
            InitializeComponent();
            KontrolleriOlustur();
        }

        private void KontrolleriOlustur()
        {
            label1 = new Label();
            label1.Text = adimlar[adim];
            label1.Top = 50;
            label1.Left = 30;
            label1.Width = 400;
            label1.Height = 40;
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(label1);

            button1 = new Button();
            button1.Text = "Devam";
            button1.Top = 120;
            button1.Left = 30;
            button1.Width = 100;
            button1.Click += button1_Click;
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adim++;
            if (adim < adimlar.Length)
            {
                label1.Text = adimlar[adim];
                if (adim == adimlar.Length - 1)
                {
                    button1.Enabled = false;
                }
            }
        }
    }
}

