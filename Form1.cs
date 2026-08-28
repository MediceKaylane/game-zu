using System.DirectoryServices.ActiveDirectory;
using System.Numerics;

namespace Shoot_Out_Game_MOO_ICT
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, goUp, goDown, gameOver;
        bool vida50Apareceu = false;
        bool vida20Apareceu = false;
        bool fase2Ativa = false;

        string facing = "up";

        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        int arames = 3;

        Random randNum = new Random();
        int score;

        List<PictureBox> zombiesList = new List<PictureBox>();




        // fazer menu explicando todas as fases;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
            painelFase2.Visible = false;
            txtArames.Visible = false;
        }


        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;

                // VIDA SÓ APARECE NA FASE 1
                if (fase2Ativa == false)
                {
                    if (playerHealth <= 50 && vida50Apareceu == false)
                    {
                        DropVida();
                        vida50Apareceu = true;
                    }

                    if (playerHealth <= 20 && vida20Apareceu == false)
                    {
                        DropVida();
                        vida20Apareceu = true;
                    }
                }
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
                lblGameOver.Visible = true;
            }


            txtAmmo.Text = "Balas: " + ammo;
            txtScore.Text = "Mortes: " + score;


            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }


                // lógica da vida

                if (x is PictureBox && (string)x.Tag == "vida")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();

                        playerHealth += 30;

                        if (playerHealth > 100)
                        {
                            playerHealth = 100;
                        }
                    }
                }


                // ZUMBIS

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }


                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }

                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }

                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }

                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }



                // BALA MATA ZUMBI

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox &&
                        (string)j.Tag == "bullet" &&
                        x is PictureBox &&
                        (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();

                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();

                            zombiesList.Remove((PictureBox)x);

                            MakeZombies();


                            // Fase 1 termina com 2 mortes
                            if (score >= 2 && fase2Ativa == false)
                            {
                                foreach (PictureBox zombie in zombiesList)
                                {
                                    this.Controls.Remove(zombie);
                                    zombie.Dispose();
                                }

                                zombiesList.Clear();

                                GameTimer.Stop();

                                painelFase2.Visible = true;
                                painelFase2.BringToFront();

                                player.Visible = false;
                            }
                        }
                    }
                }


                // ARAME MATA ZUMBI
                if (x is PictureBox && (string)x.Tag == "arame")
                {
                    foreach (Control z in this.Controls)
                    {
                        if (z is PictureBox && (string)z.Tag == "zombie")
                        {
                            if (x.Bounds.IntersectsWith(z.Bounds))
                            {
                                score++;

                                this.Controls.Remove(z);
                                ((PictureBox)z).Dispose();

                                zombiesList.Remove((PictureBox)z);

                                MakeZombies();

                                // Remove o arame depois de matar o zumbi
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();

                                break;
                            }
                        }
                    }
                }

            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }


            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
        }


        private void KeyIsUp(object sender, KeyEventArgs e)
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


            // ATIRAR
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;

                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }


            // ARAME - SOMENTE NA FASE 2
            if (e.KeyCode == Keys.E &&
                fase2Ativa == true &&
                arames > 0 &&
                gameOver == false)
            {
                DropArame();
            }


            // REINICIAR
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }


        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();

            shootBullet.direction = direction;

            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);

            shootBullet.MakeBullet(this);
        }


        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();

            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;

            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);

            zombie.SizeMode = PictureBoxSizeMode.AutoSize;

            zombiesList.Add(zombie);

            this.Controls.Add(zombie);

            player.BringToFront();
        }


        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();

            ammo.Image = Properties.Resources.ammo_Image;

            ammo.SizeMode = PictureBoxSizeMode.AutoSize;

            ammo.Left = randNum.Next(
                10,
                this.ClientSize.Width - ammo.Width
            );

            ammo.Top = randNum.Next(
                60,
                this.ClientSize.Height - ammo.Height
            );

            ammo.Tag = "ammo";

            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();
        }


        // DROPA VIDA
        private void DropVida()
        {
            PictureBox vida = new PictureBox();

            vida.Tag = "vida";

            vida.Image = Properties.Resources.coracao;

            vida.Size = new Size(40, 40);

            vida.SizeMode = PictureBoxSizeMode.StretchImage;


            vida.Left = randNum.Next(
                10,
                this.ClientSize.Width - vida.Width
            );

            vida.Top = randNum.Next(
                60,
                this.ClientSize.Height - vida.Height
            );


            this.Controls.Add(vida);

            vida.BringToFront();
            player.BringToFront();
        }


        // DROP ARAME
        private void DropArame()
        {
            if (arames <= 0)
            {
                return;
            }


            PictureBox arame = new PictureBox();

            arame.Tag = "arame";

            arame.Image = Properties.Resources.arame; //trocar para imagem do arame

            arame.Size = new Size(80, 80);

            arame.SizeMode = PictureBoxSizeMode.StretchImage;


            // posição aleatória na arena
            arame.Left = randNum.Next(
                10,
                this.ClientSize.Width - arame.Width
            );

            arame.Top = randNum.Next(
                60,
                this.ClientSize.Height - arame.Height
            );


            this.Controls.Add(arame);

            arame.BringToFront();

            player.BringToFront();


            // diminui quantidade de arames
            arames--;


            // timer de 5 segundos
            System.Windows.Forms.Timer timerArame =
                new System.Windows.Forms.Timer();

            timerArame.Interval = 10000; // 10 segundos na arena o arame


            timerArame.Tick += (sender, e) =>
            {
                if (!arame.IsDisposed)
                {
                    this.Controls.Remove(arame);
                    arame.Dispose();
                }

                timerArame.Stop();
                timerArame.Dispose();
            };


            timerArame.Start();
        }


        // FASE 2
        // FASE 2
        private void Fase2()
        {
            fase2Ativa = true;

            arames = 3;

            txtArames.Visible = true;
            txtArames.Text = "Arames: " + arames;

            // Mostra a mensagem
            labelMensagemTeclaE.Visible = true;

            // Timer da mensagem
            System.Windows.Forms.Timer timerMensagem =
                new System.Windows.Forms.Timer();

            timerMensagem.Interval = 4000; // 

            timerMensagem.Tick += (sender, e) =>
            {
                labelMensagemTeclaE.Visible = false;

                timerMensagem.Stop();
                timerMensagem.Dispose();
            };

            // INICIA O TIMER
            timerMensagem.Start();


            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }
        }


        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            lblGameOver.Visible = false;

            painelFase2.Visible = false;

            player.Visible = true;


            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();


            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }


            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            arames = 3;

            fase2Ativa = false;


            vida50Apareceu = false;
            vida20Apareceu = false;


            GameTimer.Start();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            painelFase2.Visible = false;

            player.Visible = true;

            Fase2();

            GameTimer.Start();

            this.ActiveControl = null;
            this.Focus();
        }
    }
}