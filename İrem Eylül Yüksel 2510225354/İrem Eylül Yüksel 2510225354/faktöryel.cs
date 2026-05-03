using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class faktöryel : Form
    {
        private TextBox txtSayi;
        private Button btnHesapla;
        private Label lblSonuc;

        public faktöryel()
        {
            InitializeComponent();

            // TextBox
            txtSayi = new TextBox();
            txtSayi.Location = new System.Drawing.Point(30, 30);
            txtSayi.Width = 100;
            this.Controls.Add(txtSayi);

            // Button
            btnHesapla = new Button();
            btnHesapla.Text = "Faktöryel Hesapla";
            btnHesapla.Location = new System.Drawing.Point(140, 28);
            btnHesapla.Click += BtnHesapla_Click;
            this.Controls.Add(btnHesapla);

            // Label
            lblSonuc = new Label();
            lblSonuc.Location = new System.Drawing.Point(30, 70);
            lblSonuc.AutoSize = true;
            this.Controls.Add(lblSonuc);
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int sayi;
            long sonuc = 1;
            if (!int.TryParse(txtSayi.Text, out sayi) || sayi < 0)
            {
                lblSonuc.Text = "Lütfen geçerli ve pozitif bir sayı girin.";
                return;
            }
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            lblSonuc.Text = $"Sonuç: {sonuc}";
        }
    }
}
