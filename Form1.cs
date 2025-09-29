using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappybird
{
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            // Kuşun düşmesi
            flappyBird.Top += gravity;

            // Boruların hareketi
            BoruAlt.Left -= boruHızı;
            BoruUst.Left -= boruHızı;

            // Borular ekrandan çıkınca tekrar sağa getir
            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800;
                score++;
            }
            if (BoruUst.Left < -180)
            {
                BoruUst.Left = 950;
                score++;
            }

            // Bulutların hareketi
            bulut.Left -= 5;
            if (bulut.Left < -100) { bulut.Left = 800; }

            bulut1.Left -= 5;
            if (bulut1.Left < -100) { bulut1.Left = 800; }

            bulut2.Left -= 5;
            if (bulut2.Left < -100) { bulut2.Left = 800; }

            bulut3.Left -= 5;
            if (bulut3.Left < -100) { bulut3.Left = 800; }

            bulut4.Left -= 5;
            if (bulut4.Left < -100) { bulut3.Left = 800; }

            bulut5.Left -= 5;
            if (bulut5.Left < -100) { bulut3.Left = 800; }

            bulut6.Left -= 5;
            if (bulut6.Left < -100) { bulut3.Left = 800; }

            bulut7.Left -= 5;
            if (bulut7.Left < -100) { bulut3.Left = 800; }

            bulut8.Left -= 5;
            if (bulut8.Left < -100) { bulut3.Left = 800; }

            bulut9.Left -= 5;
            if (bulut9.Left < -100) { bulut3.Left = 800; }

            bulut10.Left -= 5;
            if (bulut10.Left < -100) { bulut3.Left = 800; }

            bulut11.Left -= 5;
            if (bulut11.Left < -100) { bulut3.Left = 800; }

            // Skor güncelle
            scoreText.Text = "Score: " + score;

            // Çarpışma kontrolleri
            if (flappyBird.Bounds.IntersectsWith(BoruAlt.Bounds) ||
                flappyBird.Bounds.IntersectsWith(BoruUst.Bounds) ||
                flappyBird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }

            // Hız artışı
            if (score > 5) { boruHızı = 12; }

            // Ekranın üst sınırını geçerse oyun biter
            if (flappyBird.Top < -25) { endGame(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Eğer istersen buraya başlatma kodları ekleyebilirsin
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over!!!";
        }

        private void BoruAlt_Click(object sender, EventArgs e) { }

        private void scoreText_Click(object sender, EventArgs e) { }

        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }
    }
}

