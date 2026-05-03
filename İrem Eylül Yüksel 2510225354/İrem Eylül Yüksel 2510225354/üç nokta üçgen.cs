using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace İrem_Eylül_Yüksel_2510225354
{
    public partial class üç_nokta_üçgen : Form
    {
        private List<Point> noktalar = new List<Point>();

        public üç_nokta_üçgen()
        {
            InitializeComponent();
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.Paint += pictureBox1_Paint;
            // Menu butonu ekle
            Button btnMenu = new Button();
            btnMenu.Text = "Menu";
            btnMenu.Size = new Size(80, 30);
            btnMenu.Location = new Point(10, 50);
            btnMenu.Click += BtnMenu_Click;
            this.Controls.Add(btnMenu);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Sağ tık → reset
            if (e.Button == MouseButtons.Right)
            {
                noktalar.Clear();
                label1.Text = "";
                pictureBox1.Invalidate();
                return;
            }

            if (noktalar.Count < 3)
            {
                noktalar.Add(e.Location);
            }

            if (noktalar.Count == 3)
            {
                Hesapla();
                pictureBox1.Invalidate();
            }
            else
            {
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Noktaları çiz
            foreach (Point p in noktalar)
            {
                g.FillEllipse(Brushes.Red, p.X - 4, p.Y - 4, 8, 8);
            }

            // 3 nokta varsa üçgen çiz
            if (noktalar.Count == 3)
            {
                g.DrawPolygon(Pens.Black, noktalar.ToArray());
            }
        }

        void Hesapla()
        {
            Point A = noktalar[0];
            Point B = noktalar[1];
            Point C = noktalar[2];

            double a = Mesafe(A, B);
            double b = Mesafe(B, C);
            double c = Mesafe(C, A);

            double cevre = a + b + c;

            // Heron formülü
            double s = cevre / 2;
            double alan = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            label1.Text = $"Çevre: {cevre:F2}   Alan: {alan:F2}";
        }

        double Mesafe(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
