namespace Shoot_Out_Game_MOO_ICT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GameTimer = new System.Windows.Forms.Timer(components);
            painelmenu = new Panel();
            lblTempoFase3 = new Label();
            comojogar = new Button();
            iniciarjogo = new Button();
            titulomenu = new Label();
            txtArames = new Label();
            painelcomojogar = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            botaovoltar = new Button();
            explicacao01 = new Label();
            imagemteclas = new PictureBox();
            titulocomojogar = new Label();
            painelFase2 = new Panel();
            buttonContinuar = new Button();
            labelFase2Comacando = new Label();
            labelFase1Concluida = new Label();
            healthBar = new ProgressBar();
            player = new PictureBox();
            label1 = new Label();
            txtScore = new Label();
            txtAmmo = new Label();
            labelMensagemTeclaE = new Label();
            lblGameOver = new Label();
            timerFase3 = new System.Windows.Forms.Timer(components);
            panelFase3 = new Panel();
            buttonFase3 = new Button();
            labelFase3 = new Label();
            painelmenu.SuspendLayout();
            painelcomojogar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemteclas).BeginInit();
            painelFase2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panelFase3.SuspendLayout();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimerEvent;
            // 
            // painelmenu
            // 
            painelmenu.BackgroundImage = (Image)resources.GetObject("painelmenu.BackgroundImage");
            painelmenu.BorderStyle = BorderStyle.FixedSingle;
            painelmenu.Controls.Add(lblTempoFase3);
            painelmenu.Controls.Add(comojogar);
            painelmenu.Controls.Add(iniciarjogo);
            painelmenu.Controls.Add(titulomenu);
            painelmenu.Controls.Add(txtArames);
            painelmenu.Location = new Point(17, 12);
            painelmenu.Name = "painelmenu";
            painelmenu.Size = new Size(1199, 974);
            painelmenu.TabIndex = 8;
            // 
            // lblTempoFase3
            // 
            lblTempoFase3.AutoSize = true;
            lblTempoFase3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempoFase3.ForeColor = SystemColors.ButtonFace;
            lblTempoFase3.Location = new Point(471, 53);
            lblTempoFase3.Name = "lblTempoFase3";
            lblTempoFase3.Size = new Size(129, 29);
            lblTempoFase3.TabIndex = 18;
            lblTempoFase3.Text = "Tempo: 20";
            lblTempoFase3.Visible = false;
            // 
            // comojogar
            // 
            comojogar.BackColor = Color.FromArgb(255, 128, 0);
            comojogar.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comojogar.ForeColor = SystemColors.ButtonHighlight;
            comojogar.Location = new Point(444, 374);
            comojogar.Name = "comojogar";
            comojogar.Size = new Size(247, 68);
            comojogar.TabIndex = 2;
            comojogar.Text = "COMO JOGAR";
            comojogar.UseVisualStyleBackColor = false;
            comojogar.Click += comojogar_Click;
            // 
            // iniciarjogo
            // 
            iniciarjogo.BackColor = Color.FromArgb(255, 128, 0);
            iniciarjogo.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iniciarjogo.ForeColor = SystemColors.ButtonFace;
            iniciarjogo.Location = new Point(444, 278);
            iniciarjogo.Name = "iniciarjogo";
            iniciarjogo.Size = new Size(247, 70);
            iniciarjogo.TabIndex = 1;
            iniciarjogo.Text = "JOGAR\r\n";
            iniciarjogo.UseVisualStyleBackColor = false;
            iniciarjogo.Click += iniciarjogo_Click;
            // 
            // titulomenu
            // 
            titulomenu.AutoSize = true;
            titulomenu.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titulomenu.ForeColor = Color.FromArgb(255, 128, 0);
            titulomenu.Location = new Point(236, 73);
            titulomenu.Name = "titulomenu";
            titulomenu.Size = new Size(721, 98);
            titulomenu.TabIndex = 0;
            titulomenu.Text = "SHOOT OUT GAME";
            // 
            // txtArames
            // 
            txtArames.AutoSize = true;
            txtArames.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtArames.ForeColor = Color.DarkOrange;
            txtArames.Location = new Point(174, 2);
            txtArames.Margin = new Padding(5, 0, 5, 0);
            txtArames.Name = "txtArames";
            txtArames.Size = new Size(129, 29);
            txtArames.TabIndex = 17;
            txtArames.Text = "Arames: 3";
            txtArames.Click += iniciarjogo_Click;
            // 
            // painelcomojogar
            // 
            painelcomojogar.Controls.Add(pictureBox2);
            painelcomojogar.Controls.Add(pictureBox1);
            painelcomojogar.Controls.Add(botaovoltar);
            painelcomojogar.Controls.Add(explicacao01);
            painelcomojogar.Controls.Add(imagemteclas);
            painelcomojogar.Controls.Add(titulocomojogar);
            painelcomojogar.Location = new Point(17, 21);
            painelcomojogar.Name = "painelcomojogar";
            painelcomojogar.Size = new Size(1199, 974);
            painelcomojogar.TabIndex = 9;
            painelcomojogar.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // botaovoltar
            // 
            botaovoltar.BackColor = Color.FromArgb(255, 128, 0);
            botaovoltar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botaovoltar.ForeColor = Color.White;
            botaovoltar.Location = new Point(960, 601);
            botaovoltar.Name = "botaovoltar";
            botaovoltar.Size = new Size(131, 39);
            botaovoltar.TabIndex = 3;
            botaovoltar.Text = "Voltar";
            botaovoltar.UseVisualStyleBackColor = false;
            botaovoltar.Click += botaovoltar_Click;
            // 
            // explicacao01
            // 
            explicacao01.AutoSize = true;
            explicacao01.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            explicacao01.ForeColor = Color.FromArgb(255, 128, 0);
            explicacao01.Location = new Point(204, 242);
            explicacao01.Name = "explicacao01";
            explicacao01.Size = new Size(734, 26);
            explicacao01.TabIndex = 2;
            explicacao01.Text = "Utilize as teclas para se movimentar e pressione espaço para atirar";
            // 
            // imagemteclas
            // 
            imagemteclas.Location = new Point(0, 0);
            imagemteclas.Name = "imagemteclas";
            imagemteclas.Size = new Size(100, 50);
            imagemteclas.TabIndex = 4;
            imagemteclas.TabStop = false;
            // 
            // titulocomojogar
            // 
            titulocomojogar.AutoSize = true;
            titulocomojogar.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulocomojogar.ForeColor = Color.FromArgb(255, 128, 0);
            titulocomojogar.Location = new Point(304, 74);
            titulocomojogar.Name = "titulocomojogar";
            titulocomojogar.Size = new Size(539, 98);
            titulocomojogar.TabIndex = 0;
            titulocomojogar.Text = "COMO JOGAR";
            // 
            // painelFase2
            // 
            painelFase2.BackColor = Color.LightGray;
            painelFase2.BorderStyle = BorderStyle.FixedSingle;
            painelFase2.Controls.Add(buttonContinuar);
            painelFase2.Controls.Add(labelFase2Comacando);
            painelFase2.Controls.Add(labelFase1Concluida);
            painelFase2.Location = new Point(210, 269);
            painelFase2.Margin = new Padding(3, 4, 3, 4);
            painelFase2.Name = "painelFase2";
            painelFase2.Size = new Size(813, 479);
            painelFase2.TabIndex = 10;
            // 
            // buttonContinuar
            // 
            buttonContinuar.BackColor = SystemColors.ButtonFace;
            buttonContinuar.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonContinuar.ForeColor = Color.DarkOrange;
            buttonContinuar.Location = new Point(310, 296);
            buttonContinuar.Margin = new Padding(3, 4, 3, 4);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(173, 83);
            buttonContinuar.TabIndex = 6;
            buttonContinuar.Text = "CONTINUAR";
            buttonContinuar.UseVisualStyleBackColor = false;
            buttonContinuar.Click += buttonContinuar_Click;
            // 
            // labelFase2Comacando
            // 
            labelFase2Comacando.AutoSize = true;
            labelFase2Comacando.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFase2Comacando.ForeColor = Color.DarkOrange;
            labelFase2Comacando.Location = new Point(219, 209);
            labelFase2Comacando.Name = "labelFase2Comacando";
            labelFase2Comacando.Size = new Size(359, 41);
            labelFase2Comacando.TabIndex = 5;
            labelFase2Comacando.Text = "A fase 2 está começando...";
            // 
            // labelFase1Concluida
            // 
            labelFase1Concluida.AutoSize = true;
            labelFase1Concluida.Font = new Font("Showcard Gothic", 34.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFase1Concluida.ForeColor = Color.FromArgb(255, 128, 0);
            labelFase1Concluida.Location = new Point(127, 43);
            labelFase1Concluida.Name = "labelFase1Concluida";
            labelFase1Concluida.Size = new Size(564, 71);
            labelFase1Concluida.TabIndex = 4;
            labelFase1Concluida.Text = "FASE 1 CONCLUÍDA!";
            labelFase1Concluida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // healthBar
            // 
            healthBar.Location = new Point(846, 15);
            healthBar.Margin = new Padding(5);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(249, 35);
            healthBar.TabIndex = 16;
            healthBar.Value = 100;
            healthBar.Visible = false;
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(64, 64, 64);
            player.Image = Properties.Resources.up;
            player.Location = new Point(498, 544);
            player.Margin = new Padding(5);
            player.Name = "player";
            player.Size = new Size(71, 100);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 18;
            player.TabStop = false;
            player.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(750, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 29);
            label1.TabIndex = 20;
            label1.Text = "Health: ";
            label1.Visible = false;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = Color.DarkOrange;
            txtScore.Location = new Point(430, 15);
            txtScore.Margin = new Padding(5, 0, 5, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(92, 29);
            txtScore.TabIndex = 22;
            txtScore.Text = "Kills: 0";
            txtScore.Visible = false;
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmmo.ForeColor = Color.DarkOrange;
            txtAmmo.Location = new Point(15, 15);
            txtAmmo.Margin = new Padding(5, 0, 5, 0);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(114, 29);
            txtAmmo.TabIndex = 23;
            txtAmmo.Text = "Ammo: 0";
            txtAmmo.Visible = false;
            // 
            // labelMensagemTeclaE
            // 
            labelMensagemTeclaE.AutoSize = true;
            labelMensagemTeclaE.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMensagemTeclaE.ForeColor = Color.DarkOrange;
            labelMensagemTeclaE.Location = new Point(520, 420);
            labelMensagemTeclaE.Margin = new Padding(5, 0, 5, 0);
            labelMensagemTeclaE.Name = "labelMensagemTeclaE";
            labelMensagemTeclaE.Size = new Size(351, 29);
            labelMensagemTeclaE.TabIndex = 24;
            labelMensagemTeclaE.Text = "Pressione E para usar arame";
            labelMensagemTeclaE.Visible = false;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Microsoft Sans Serif", 30F);
            lblGameOver.ForeColor = SystemColors.ButtonFace;
            lblGameOver.Location = new Point(178, 200);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(877, 58);
            lblGameOver.TabIndex = 27;
            lblGameOver.Text = "Pressione enter para jogar novamente";
            lblGameOver.Visible = false;
            // 
            // timerFase3
            // 
            timerFase3.Interval = 1000;
            timerFase3.Tick += timerFase3_Tick;
            // 
            // panelFase3
            // 
            panelFase3.Controls.Add(buttonFase3);
            panelFase3.Controls.Add(labelFase3);
            panelFase3.Location = new Point(214, 273);
            panelFase3.Name = "panelFase3";
            panelFase3.Size = new Size(805, 471);
            panelFase3.TabIndex = 28;
            panelFase3.Visible = false;
            // 
            // buttonFase3
            // 
            buttonFase3.BackColor = Color.FromArgb(255, 128, 0);
            buttonFase3.Location = new Point(270, 198);
            buttonFase3.Name = "buttonFase3";
            buttonFase3.Size = new Size(221, 84);
            buttonFase3.TabIndex = 1;
            buttonFase3.Text = "Continuar para fase 3";
            buttonFase3.UseVisualStyleBackColor = false;
            // 
            // labelFase3
            // 
            labelFase3.AutoSize = true;
            labelFase3.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFase3.ForeColor = Color.FromArgb(255, 128, 0);
            labelFase3.Location = new Point(24, 61);
            labelFase3.Name = "labelFase3";
            labelFase3.Size = new Size(748, 46);
            labelFase3.TabIndex = 0;
            labelFase3.Text = "Parabéns você chegou no nível final!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1232, 1017);
            Controls.Add(healthBar);
            Controls.Add(panelFase3);
            Controls.Add(lblGameOver);
            Controls.Add(label1);
            Controls.Add(txtScore);
            Controls.Add(txtAmmo);
            Controls.Add(painelFase2);
            Controls.Add(painelmenu);
            Controls.Add(painelcomojogar);
            Controls.Add(labelMensagemTeclaE);
            Controls.Add(player);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Zombie Shootout Game MOO ICT";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            painelmenu.ResumeLayout(false);
            painelmenu.PerformLayout();
            painelcomojogar.ResumeLayout(false);
            painelcomojogar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemteclas).EndInit();
            painelFase2.ResumeLayout(false);
            painelFase2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            panelFase3.ResumeLayout(false);
            panelFase3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private Panel painelmenu;
        private Button comojogar;
        private Button iniciarjogo;
        private Label titulomenu;
        private Panel painelcomojogar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button botaovoltar;
        private Label explicacao01;
        private PictureBox imagemteclas;
        private Label titulocomojogar;
        private Panel painelFase2;
        private Button buttonContinuar;
        private Label labelFase2Comacando;
        private Label labelFase1Concluida;
        private ProgressBar healthBar;
        private Label txtArames;
        private PictureBox player;
        private Label label1;
        private Label txtScore;
        private Label txtAmmo;
        private Label labelMensagemTeclaE;
        private Label lblGameOver;
        private System.Windows.Forms.Timer timerFase3;
        private Label lblTempoFase3;
        private Panel panelFase3;
        private Button buttonFase3;
        private Label labelFase3;
    }
}
