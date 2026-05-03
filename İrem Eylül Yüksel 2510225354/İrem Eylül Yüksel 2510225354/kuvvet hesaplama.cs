using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class kuvvet_hesaplama : Form
    {
        private TextBox txtTaban;
        private TextBox txtUs;
        private Button btnHesapla;
        private Label lblSonuc;

        public kuvvet_hesaplama()
        {
            InitializeComponent();

            // Taban TextBox
            txtTaban = new TextBox();
            txtTaban.Location = new System.Drawing.Point(30, 30);
            txtTaban.Width = 80;
            txtTaban.PlaceholderText = "Taban";
            this.Controls.Add(txtTaban);

            // Üs TextBox
            txtUs = new TextBox();
            txtUs.Location = new System.Drawing.Point(120, 30);
            txtUs.Width = 80;
            txtUs.PlaceholderText = "Üs";
            this.Controls.Add(txtUs);

            // Hesapla Button
            btnHesapla = new Button();
            btnHesapla.Text = "Hesapla";
            btnHesapla.Location = new System.Drawing.Point(220, 28);
            btnHesapla.Click += BtnHesapla_Click;
            this.Controls.Add(btnHesapla);

            // Sonuç Label
            lblSonuc = new Label();
            lblSonuc.Location = new System.Drawing.Point(30, 70);
            lblSonuc.AutoSize = true;
            this.Controls.Add(lblSonuc);
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            long taban, us;
            if (!long.TryParse(txtTaban.Text, out taban) || !long.TryParse(txtUs.Text, out us) || us < 0)
            {
                lblSonuc.Text = "Lütfen geçerli bir taban ve pozitif üs girin.";
                return;
            }
            lblSonuc.Text = $"Sonuç: {UstAl(taban, us)}";
        }

        private long UstAl(long taban, long us)
        {
            long sonuc = 1;
            while (us > 0)
            {
                if (us % 2 == 1)
                {
                    sonuc *= taban;
                }
                taban *= taban;
                us /= 2;
            }
            return sonuc;
        }
    }
}

