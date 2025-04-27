using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace YilanOyunu.UI
{
    public partial class Form1 : Form
    {
        int hýz=100;
        List<string> OyunTuru = new List<string> { "Kolay", "Orta", "Zor" };
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        int maxWidth;
        int maxHeight;

        int score;
        int highscore;

        Random rnd = new Random();
        bool goLeft, goRight, goDown, goUp;
        public Form1()
        {
            InitializeComponent();
            new Settings();

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }

                    }


                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }


            pnlYilan.Invalidate();
           
        }

        private void UpdatePictureBox(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }


            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
        }
        private void RestartGame()
        {
            maxWidth = pnlYilan.Width / Settings.Width - 1;
            maxHeight = pnlYilan.Height / Settings.Height - 1;

            Snake.Clear();

            btnBasla.Enabled = false;

            score = 0;
            lblScore.Text = score.ToString();

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            food = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            GameTimer.Interval = hýz;
            GameTimer.Start();
        }
        private void EatFood()
        {
            score += 1;

            lblScore.Text = score.ToString();

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = rnd.Next(2, maxWidth), Y = rnd.Next(2, maxHeight) };
            Hizlandirici();
            PanelKucultme();
        }
        private void GameOver()
        {
            GameTimer.Stop();
            btnBasla.Enabled = true;


            if (score > highscore)
            {
                highscore = score;

                lblHighScore.Text = highscore.ToString();
                lblHighScore.ForeColor = Color.Maroon;
                lblHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
            DialogResult result = MessageBox.Show(
                    "Oyunu yeniden baþlatmak istiyor musun?",  // Mesaj
              "Yeniden Baþlat",                          // Baþlýk
                 MessageBoxButtons.YesNo,                   // Butonlar: Evet ve Hayýr
                 MessageBoxIcon.Question);

            // Sonucu kontrol et
            if (result == DialogResult.Yes)
            {
                DialogResult otherResult = MessageBox.Show(
                    "Zorluk seviyenizi deðiþtirmek istiyor musun?",  // Mesaj
              "SEVÝYE",                          // Baþlýk
                 MessageBoxButtons.YesNo,                   // Butonlar: Evet ve Hayýr
                 MessageBoxIcon.Question);
                if (otherResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    RestartGame();
                }

            }
            else
            {
                // Hayýr seçildiðinde yapýlacaklar
                Application.Exit();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object? sender, KeyEventArgs e) // Fix for CS8622: Add nullable annotation to match the delegate's nullability.  
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        private void Hizlandirici()
        {
            if (score > 5 && score % 5 == 0)
            {
                GameTimer.Interval -= 10;
            }
        }

        private void btnKolay_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = false;
            GameTimer.Interval = 150;
            pnlGiris.Visible = false;
            hýz = GameTimer.Interval;
            lblGosterge.Text = "SEVÝYENÝZ : KOLAY";
        }

        private void btnOrta_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = false;
            GameTimer.Interval = 90;
            pnlGiris.Visible = false;
            hýz = GameTimer.Interval;
            lblGosterge.Text = "SEVÝYENÝZ : ORTA";
        }

        private void btnZor_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = false;
            GameTimer.Interval = 50;
            pnlGiris.Visible = false;
            hýz = GameTimer.Interval;
            lblGosterge.Text = "SEVÝYENÝZ : ZOR";
        }
        private void PanelKucultme()
        {
           
                if (score % 5 == 0 && score >=5) 
                {
                    if (pnlYilan.Width > 200 && pnlYilan.Height > 200)
                    {
                        pnlYilan.Width -= 50;
                        pnlYilan.Height -= 50;

                        maxWidth = pnlYilan.Width / Settings.Width - 1;
                        maxHeight = pnlYilan.Height / Settings.Height - 1;

                    ResetFood();
                    }
                }

        }
        private void ResetFood()
        {
            food = new Circle
            {
                X = rnd.Next(0, maxWidth),
                Y = rnd.Next(0, maxHeight)
            };
        }

    }
}
