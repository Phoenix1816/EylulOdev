using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class sesli_sessiz : Form
    {
        private TextBox txtHarf;
        private Button btnKontrol;
        private Label lblSonuc;
        private Button btnForm2yeGit;

        public sesli_sessiz()
        {
            InitializeComponent();

            // TextBox
            txtHarf = new TextBox();
            txtHarf.Location = new System.Drawing.Point(30, 30);
            txtHarf.MaxLength = 1;
            txtHarf.Width = 50;
            this.Controls.Add(txtHarf);

            // Button
            btnKontrol = new Button();
            btnKontrol.Text = "Kontrol Et";
            btnKontrol.Location = new System.Drawing.Point(100, 28);
            btnKontrol.Click += BtnKontrol_Click;
            this.Controls.Add(btnKontrol);

            // Label
            lblSonuc = new Label();
            lblSonuc.Location = new System.Drawing.Point(30, 70);
            lblSonuc.AutoSize = true;
            this.Controls.Add(lblSonuc);
            // Form2'ye geçiş butonu
            btnForm2yeGit = new Button();
            btnForm2yeGit.Text = "Menu";
            btnForm2yeGit.Location = new System.Drawing.Point(30, 110);
            btnForm2yeGit.Click += BtnForm2yeGit_Click;
            this.Controls.Add(btnForm2yeGit);
        }

        private void BtnKontrol_Click(object sender, EventArgs e)
        {
            char[] sesliHarfler = { 'A', 'E', 'I','İ', 'O', 'Ö', 'U', 'Ü',
                        'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            if (string.IsNullOrWhiteSpace(txtHarf.Text))
            {
                lblSonuc.Text = "Lütfen bir harf girin.";
                return;
            }

            char harf = txtHarf.Text[0];
            bool sesliMi = false;

            for (int i = 0; i < sesliHarfler.Length; i++)
            {
                if (sesliHarfler[i] == harf)
                {
                    sesliMi = true;
                    break;
                }
            }

            if (sesliMi)
            {
                lblSonuc.Text = $"{harf} harfi sesli harftir.";
            }
            else
            {
                lblSonuc.Text = $"{harf} harfi sesli harf değildir.";
            }
        }
        private void BtnForm2yeGit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
