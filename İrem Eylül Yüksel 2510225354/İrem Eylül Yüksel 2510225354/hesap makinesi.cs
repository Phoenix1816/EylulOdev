using System;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class hesap_makinesi : Form
    {
        TextBox txtSayi1;
        TextBox txtSayi2;
        ComboBox cmbIslem;
        Button btnHesapla;
        Label lblSonuc;

        public hesap_makinesi()
        {
            InitializeComponent();
            FormuOlustur();
        }

        private void FormuOlustur()
        {
            // Sayı 1
            txtSayi1 = new TextBox();
            txtSayi1.Location = new System.Drawing.Point(20, 20);
            txtSayi1.Width = 100;
            this.Controls.Add(txtSayi1);

            // Sayı 2
            txtSayi2 = new TextBox();
            txtSayi2.Location = new System.Drawing.Point(140, 20);
            txtSayi2.Width = 100;
            this.Controls.Add(txtSayi2);

            // İşlem seçimi
            cmbIslem = new ComboBox();
            cmbIslem.Location = new System.Drawing.Point(20, 60);
            cmbIslem.Width = 100;
            cmbIslem.Items.AddRange(new string[] { "+", "-", "*", "/" });
            cmbIslem.SelectedIndex = 0;
            this.Controls.Add(cmbIslem);

            // Buton
            btnHesapla = new Button();
            btnHesapla.Text = "Hesapla";
            btnHesapla.Location = new System.Drawing.Point(140, 60);
            btnHesapla.Click += BtnHesapla_Click;
            this.Controls.Add(btnHesapla);

            // Sonuç
            lblSonuc = new Label();
            lblSonuc.Location = new System.Drawing.Point(20, 110);
            lblSonuc.Width = 250;
            lblSonuc.Text = "Sonuç:";
            this.Controls.Add(lblSonuc);
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc = 0;

            if (!double.TryParse(txtSayi1.Text, out sayi1) ||
                !double.TryParse(txtSayi2.Text, out sayi2))
            {
                MessageBox.Show("Lütfen sayı gir!");
                return;
            }

            switch (cmbIslem.SelectedItem.ToString())
            {
                case "+": sonuc = sayi1 + sayi2; break;
                case "-": sonuc = sayi1 - sayi2; break;
                case "*": sonuc = sayi1 * sayi2; break;
                case "/":
                    if (sayi2 == 0)
                    {
                        MessageBox.Show("0'a bölünemez!");
                        return;
                    }
                    sonuc = sayi1 / sayi2;
                    break;
            }

            lblSonuc.Text = "Sonuç: " + sonuc;
        }
    }
}