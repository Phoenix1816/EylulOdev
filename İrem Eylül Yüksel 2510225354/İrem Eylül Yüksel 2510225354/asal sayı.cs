using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class asal_sayı : Form
    {
        private TextBox txtSayi;
        private Button btnKontrol;
        private Label lblSonuc;
        private Button btnMenu;

        public asal_sayı()
        {
            InitializeComponent();

            // TextBox
            txtSayi = new TextBox();
            txtSayi.Location = new System.Drawing.Point(30, 30);
            txtSayi.Width = 100;
            this.Controls.Add(txtSayi);

            // Kontrol Button
            btnKontrol = new Button();
            btnKontrol.Text = "Asal mı?";
            btnKontrol.Location = new System.Drawing.Point(140, 28);
            btnKontrol.Click += BtnKontrol_Click;
            this.Controls.Add(btnKontrol);

            // Sonuç Label
            lblSonuc = new Label();
            lblSonuc.Location = new System.Drawing.Point(30, 70);
            lblSonuc.AutoSize = true;
            this.Controls.Add(lblSonuc);

            // Menu Button
            btnMenu = new Button();
            btnMenu.Text = "Menu";
            btnMenu.Location = new System.Drawing.Point(30, 110);
            btnMenu.Size = new System.Drawing.Size(80, 30);
            btnMenu.Click += BtnMenu_Click;
            this.Controls.Add(btnMenu);
        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            int sayi, c = 0;
            if (!int.TryParse(txtSayi.Text, out sayi))
            {
                lblSonuc.Text = "Lütfen geçerli bir sayı girin.";
                return;
            }
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    c++;
                }
            }
            if (c == 2)
            {
                lblSonuc.Text = $"{sayi} sayısı asal sayıdır.";
            }
            else
            {
                lblSonuc.Text = $"{sayi} sayısı asal sayı değildir.";
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
