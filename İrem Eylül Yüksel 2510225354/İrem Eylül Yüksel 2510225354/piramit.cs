
using System;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class piramit : Form
    {
        TextBox textBox1;
        Button button1;
        ListBox listBox1;
        Label lblYukseklik;

        public piramit()
        {
            FormuHazirla();
        }

        private void FormuHazirla()
        {
            this.Text = "Piramit Çizimi";
            this.Width = 400;
            this.Height = 400;

            lblYukseklik = new Label();
            lblYukseklik.Text = "Yükseklik:";
            lblYukseklik.Top = 20;
            lblYukseklik.Left = 20;
            this.Controls.Add(lblYukseklik);

            textBox1 = new TextBox();
            textBox1.Top = 20;
            textBox1.Left = 100;
            textBox1.Width = 50;
            textBox1.ForeColor = System.Drawing.Color.Black;
            textBox1.BackColor = System.Drawing.Color.White;
            this.Controls.Add(textBox1);

            button1 = new Button();
            button1.Text = "Çiz";
            button1.Top = 60;
            button1.Left = 100;
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            listBox1 = new ListBox();
            listBox1.Top = 100;
            listBox1.Left = 20;
            listBox1.Width = 200;
            listBox1.Height = 200;
            this.Controls.Add(listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int yukseklik;
            if (!int.TryParse(textBox1.Text, out yukseklik) || yukseklik < 1)
            {
                MessageBox.Show("Geçerli bir yükseklik giriniz!");
                return;
            }

            for (int i = 1; i <= yukseklik; i++)
            {
                string satir = "";
                // boşluklar
                for (int j = 1; j <= yukseklik - i; j++)
                {
                    satir += " ";
                }
                // yıldızlar
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    satir += "*";
                }
                listBox1.Items.Add(satir);
            }
        }
    }
}

