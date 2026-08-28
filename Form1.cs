using System.DirectoryServices.ActiveDirectory;
using System.Numerics;

namespace Shoot_Out_Game_MOO_ICT
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, goUp, goDown, gameOver;
        bool vida50Apareceu = false;
        bool vida20Apareceu = false;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        Random randNum = new Random();
        int score;
        List<PictureBox> zombiesList = new List<PictureBox>();
        private object e;


        //fazer menu explicando todas as fases;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
                // se o jogador tiver menos de 50 de vida e vida nao tiver aparecido, dropa imagem vida
                if (playerHealth <= 50 && vida50Apareceu == false)
                {
                    DropVida();
                    vida50Apareceu = true;
                }
                // se o jogador tiver menos de 20 de vida e vida nao tiver aparecido, dropa imagem vida

                if (playerHealth <= 20 && vida20Apareceu == false)
                {
                    DropVida();
                    vida20Apareceu = true;
            }
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }


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


                // logica de quando surge a imagem e da 30 de vida ao jogador, mas nao pode passar de 100 de vida

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



                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            MakeZombies();

                            //se vc matar 15 zombies, a fase 1 ta ganha
                            if (score >= 15)

                            {
                                foreach (PictureBox zombie in zombiesList)
                                {
                                    this.Controls.Remove(zombie);
                                    zombie.Dispose();
                                }

                                zombiesList.Clear();
                                GameTimer.Stop();
                                MessageBox.Show("Fase 1 concluída! Fase 2 iniciando...");
                                //mensagem explicando a fase dois
                                Fase2();
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

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);


                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

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
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();



        }

        // Função para dropar vida quando o jogador estiver com menos de 50 ou 20 de vida
        private void DropVida()
        {
            PictureBox vida = new PictureBox();

            vida.Tag = "vida";
            vida.Image = Properties.Resources.ammo_Image; //mudar para imagem de vida
            vida.SizeMode = PictureBoxSizeMode.AutoSize;

            // Posição aleatória dentro do campo
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

        private void DropArame()
        {
            PictureBox arame = new PictureBox();
            arame.Image = Properties.Resources.arame; //pegar imagem do arame
            arame.SizeMode = PictureBoxSizeMode.AutoSize;
            arame.Left = randNum.Next(10, this.ClientSize.Width - arame.Width);
            arame.Top = randNum.Next(60, this.ClientSize.Height - arame.Height);
            arame.Tag = "arame";
            this.Controls.Add(arame);
            arame.BringToFront();
            player.BringToFront();
        }

        private void Fase2()
        {

            //dropar 3 arames na arena se apertar e
            int arames = 3;

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            if (e.KeyCode == Keys.E && arames > 0 && gameOver == false)
            {
                DropArame();

            }

        }





        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

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


            // Resetar as flags de vida como ainda n usadas
            vida50Apareceu = false;
            vida20Apareceu = false;

            GameTimer.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

    }
}
}