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
            labelFase3 = new Label();
            buttonFase3 = new Button();
            panelRelatorioFinal = new Panel();
            buttonVoltarMenu = new Button();
            lblTentativasFinal = new Label();
            lblKillsFinal = new Label();
            labelRelatorio = new Label();
            painelmenu.SuspendLayout();
            painelcomojogar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagemteclas).BeginInit();
            painelFase2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            panelFase3.SuspendLayout();
            panelRelatorioFinal.SuspendLayout();
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
            painelmenu.Controls.Add(lblGameOver);
            painelmenu.Controls.Add(iniciarjogo);
            painelmenu.Controls.Add(titulomenu);
            painelmenu.Controls.Add(txtArames);
            painelmenu.Location = new Point(15, 9);
            painelmenu.Margin = new Padding(3, 2, 3, 2);
            painelmenu.Name = "painelmenu";
            painelmenu.Size = new Size(1049, 731);
            painelmenu.TabIndex = 8;
            // 
            // lblTempoFase3
            // 
            lblTempoFase3.AutoSize = true;
            lblTempoFase3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempoFase3.ForeColor = SystemColors.ButtonFace;
            lblTempoFase3.Location = new Point(452, 39);
            lblTempoFase3.Name = "lblTempoFase3";
            lblTempoFase3.Size = new Size(106, 23);
            lblTempoFase3.TabIndex = 18;
            lblTempoFase3.Text = "Tempo: 20";
            lblTempoFase3.Visible = false;
            // 
            // comojogar
            // 
            comojogar.BackColor = Color.FromArgb(255, 128, 0);
            comojogar.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comojogar.ForeColor = SystemColors.ButtonHighlight;
            comojogar.Location = new Point(388, 280);
            comojogar.Margin = new Padding(3, 2, 3, 2);
            comojogar.Name = "comojogar";
            comojogar.Size = new Size(216, 51);
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
            iniciarjogo.Location = new Point(388, 208);
            iniciarjogo.Margin = new Padding(3, 2, 3, 2);
            iniciarjogo.Name = "iniciarjogo";
            iniciarjogo.Size = new Size(216, 52);
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
            titulomenu.Location = new Point(206, 55);
            titulomenu.Name = "titulomenu";
            titulomenu.Size = new Size(583, 79);
            titulomenu.TabIndex = 0;
            titulomenu.Text = "SHOOT OUT GAME";
            // 
            // txtArames
            // 
            txtArames.AutoSize = true;
            txtArames.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtArames.ForeColor = Color.DarkOrange;
            txtArames.Location = new Point(152, 2);
            txtArames.Margin = new Padding(4, 0, 4, 0);
            txtArames.Name = "txtArames";
            txtArames.Size = new Size(104, 24);
            txtArames.TabIndex = 17;
            txtArames.Text = "Arames: 3";
            txtArames.Click += iniciarjogo_Click;
            // 
            // painelcomojogar
            // 
            painelcomojogar.Controls.Add(botaovoltar);
            painelcomojogar.Controls.Add(explicacao01);
            painelcomojogar.Controls.Add(imagemteclas);
            painelcomojogar.Controls.Add(titulocomojogar);
            painelcomojogar.Location = new Point(15, 16);
            painelcomojogar.Margin = new Padding(3, 2, 3, 2);
            painelcomojogar.Name = "painelcomojogar";
            painelcomojogar.Size = new Size(1049, 730);
            painelcomojogar.TabIndex = 9;
            painelcomojogar.Visible = false;
            // 
            // botaovoltar
            // 
            botaovoltar.BackColor = Color.FromArgb(255, 128, 0);
            botaovoltar.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botaovoltar.ForeColor = Color.White;
            botaovoltar.Location = new Point(840, 451);
            botaovoltar.Margin = new Padding(3, 2, 3, 2);
            botaovoltar.Name = "botaovoltar";
            botaovoltar.Size = new Size(115, 29);
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
            explicacao01.ImageAlign = ContentAlignment.BottomRight;
            explicacao01.Location = new Point(178, 182);
            explicacao01.Name = "explicacao01";
            explicacao01.Size = new Size(805, 180);
            explicacao01.TabIndex = 2;
            explicacao01.Text = resources.GetString("explicacao01.Text");
            // 
            // imagemteclas
            // 
            imagemteclas.Location = new Point(0, 0);
            imagemteclas.Margin = new Padding(3, 2, 3, 2);
            imagemteclas.Name = "imagemteclas";
            imagemteclas.Size = new Size(88, 38);
            imagemteclas.TabIndex = 4;
            imagemteclas.TabStop = false;
            // 
            // titulocomojogar
            // 
            titulocomojogar.AutoSize = true;
            titulocomojogar.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titulocomojogar.ForeColor = Color.FromArgb(255, 128, 0);
            titulocomojogar.Location = new Point(266, 56);
            titulocomojogar.Name = "titulocomojogar";
            titulocomojogar.Size = new Size(436, 79);
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
            painelFase2.Location = new Point(184, 202);
            painelFase2.Name = "painelFase2";
            painelFase2.Size = new Size(712, 360);
            painelFase2.TabIndex = 10;
            // 
            // buttonContinuar
            // 
            buttonContinuar.BackColor = SystemColors.ButtonFace;
            buttonContinuar.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonContinuar.ForeColor = Color.DarkOrange;
            buttonContinuar.Location = new Point(310, 310);
            buttonContinuar.Margin = new Padding(3, 4, 3, 4);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(151, 62);
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
            labelFase2Comacando.Location = new Point(120, 209);
            labelFase2Comacando.Name = "labelFase2Comacando";
            labelFase2Comacando.Size = new Size(492, 82);
            labelFase2Comacando.TabIndex = 5;
            labelFase2Comacando.Text = "A fase 2 está começando...\r\nMate 20 zumbis para passar de nível\r\n";
            // 
            // labelFase1Concluida
            // 
            labelFase1Concluida.AutoSize = true;
            labelFase1Concluida.Font = new Font("Showcard Gothic", 34.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFase1Concluida.ForeColor = Color.FromArgb(255, 128, 0);
            labelFase1Concluida.Location = new Point(111, 32);
            labelFase1Concluida.Name = "labelFase1Concluida";
            labelFase1Concluida.Size = new Size(464, 59);
            labelFase1Concluida.TabIndex = 4;
            labelFase1Concluida.Text = "FASE 1 CONCLUÍDA!";
            labelFase1Concluida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // healthBar
            // 
            healthBar.Location = new Point(890, 15);
            healthBar.Margin = new Padding(5);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(218, 26);
            healthBar.TabIndex = 16;
            healthBar.Value = 100;
            healthBar.Visible = false;
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(64, 64, 64);
            player.Image = Properties.Resources.up;
            player.Location = new Point(436, 408);
            player.Margin = new Padding(4, 4, 4, 4);
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
            label1.Location = new Point(656, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 20;
            label1.Text = "Health: ";
            label1.Visible = false;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = Color.DarkOrange;
            txtScore.Location = new Point(376, 11);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(71, 24);
            txtScore.TabIndex = 22;
            txtScore.Text = "Kills: 0";
            txtScore.Visible = false;
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmmo.ForeColor = Color.DarkOrange;
            txtAmmo.Location = new Point(13, 11);
            txtAmmo.Margin = new Padding(4, 0, 4, 0);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(93, 24);
            txtAmmo.TabIndex = 23;
            txtAmmo.Text = "Ammo: 0";
            txtAmmo.Visible = false;
            // 
            // labelMensagemTeclaE
            // 
            labelMensagemTeclaE.AutoSize = true;
            labelMensagemTeclaE.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMensagemTeclaE.ForeColor = Color.DarkOrange;
            labelMensagemTeclaE.Location = new Point(455, 315);
            labelMensagemTeclaE.Margin = new Padding(4, 0, 4, 0);
            labelMensagemTeclaE.Name = "labelMensagemTeclaE";
            labelMensagemTeclaE.Size = new Size(280, 24);
            labelMensagemTeclaE.TabIndex = 24;
            labelMensagemTeclaE.Text = "Pressione E para usar arame";
            labelMensagemTeclaE.Visible = false;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Microsoft Sans Serif", 30F);
            lblGameOver.ForeColor = SystemColors.ButtonFace;
            lblGameOver.Location = new Point(183, 143);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(697, 46);
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
            panelFase3.BackColor = Color.WhiteSmoke;
            panelFase3.Controls.Add(labelFase3);
            panelFase3.Controls.Add(buttonFase3);
            panelFase3.Location = new Point(214, 273);
            panelFase3.Name = "panelFase3";
            panelFase3.Size = new Size(704, 353);
            panelFase3.TabIndex = 28;
            panelFase3.Visible = false;
            // 
            // labelFase3
            // 
            labelFase3.AutoSize = true;
            labelFase3.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFase3.ForeColor = Color.FromArgb(255, 128, 0);
            labelFase3.Location = new Point(24, 61);
            labelFase3.Name = "labelFase3";
            labelFase3.Size = new Size(794, 92);
            labelFase3.TabIndex = 0;
            labelFase3.Text = "Você terá balas infinitas\r\nSobreviva a um ataque de zumbis em 20s \r\n";
            // 
            // buttonFase3
            // 
            buttonFase3.BackColor = Color.FromArgb(255, 128, 0);
            buttonFase3.Location = new Point(236, 148);
            buttonFase3.Margin = new Padding(3, 2, 3, 2);
            buttonFase3.Name = "buttonFase3";
            buttonFase3.Size = new Size(193, 63);
            buttonFase3.TabIndex = 1;
            buttonFase3.Text = "Continuar para fase 3";
            buttonFase3.UseVisualStyleBackColor = false;
            buttonFase3.Click += buttonFase3_Click;
            // 
            // panelRelatorioFinal
            // 
            panelRelatorioFinal.Controls.Add(buttonVoltarMenu);
            panelRelatorioFinal.Controls.Add(lblTentativasFinal);
            panelRelatorioFinal.Controls.Add(lblKillsFinal);
            panelRelatorioFinal.Controls.Add(labelRelatorio);
            panelRelatorioFinal.Location = new Point(15, 7);
            panelRelatorioFinal.Name = "panelRelatorioFinal";
            panelRelatorioFinal.Size = new Size(1203, 993);
            panelRelatorioFinal.TabIndex = 29;
            panelRelatorioFinal.Visible = false;
            // 
            // buttonVoltarMenu
            // 
            buttonVoltarMenu.BackColor = Color.FromArgb(255, 128, 0);
            buttonVoltarMenu.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltarMenu.ForeColor = SystemColors.ButtonFace;
            buttonVoltarMenu.Location = new Point(441, 478);
            buttonVoltarMenu.Name = "buttonVoltarMenu";
            buttonVoltarMenu.Size = new Size(272, 83);
            buttonVoltarMenu.TabIndex = 3;
            buttonVoltarMenu.Text = "Voltar ";
            buttonVoltarMenu.UseVisualStyleBackColor = false;
            buttonVoltarMenu.Click += buttonVoltarMenu_Click;
            // 
            // lblTentativasFinal
            // 
            lblTentativasFinal.AutoSize = true;
            lblTentativasFinal.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTentativasFinal.ForeColor = SystemColors.ButtonFace;
            lblTentativasFinal.Location = new Point(174, 286);
            lblTentativasFinal.Name = "lblTentativasFinal";
            lblTentativasFinal.Size = new Size(291, 46);
            lblTentativasFinal.TabIndex = 2;
            lblTentativasFinal.Text = "Tentativas: 0";
            // 
            // lblKillsFinal
            // 
            lblKillsFinal.AutoSize = true;
            lblKillsFinal.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKillsFinal.ForeColor = SystemColors.ButtonFace;
            lblKillsFinal.Location = new Point(174, 202);
            lblKillsFinal.Name = "lblKillsFinal";
            lblKillsFinal.Size = new Size(216, 46);
            lblKillsFinal.TabIndex = 1;
            lblKillsFinal.Text = "Mortes: 0";
            // 
            // labelRelatorio
            // 
            labelRelatorio.AutoSize = true;
            labelRelatorio.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelRelatorio.ForeColor = Color.FromArgb(255, 128, 0);
            labelRelatorio.Location = new Point(244, 39);
            labelRelatorio.Name = "labelRelatorio";
            labelRelatorio.Size = new Size(721, 98);
            labelRelatorio.TabIndex = 0;
            labelRelatorio.Text = "RELATÓRIO FINAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1232, 1017);
            Controls.Add(painelmenu);
            Controls.Add(painelcomojogar);
            Controls.Add(labelMensagemTeclaE);
            Controls.Add(player);
            Controls.Add(txtAmmo);
            Controls.Add(txtScore);
            Controls.Add(label1);
            Controls.Add(healthBar);
            Controls.Add(lblGameOver);
            Controls.Add(painelFase2);
            Controls.Add(panelFase3);
            Controls.Add(panelRelatorioFinal);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Zombie Shootout Game MOO ICT";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            painelmenu.ResumeLayout(false);
            painelmenu.PerformLayout();
            painelcomojogar.ResumeLayout(false);
            painelcomojogar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagemteclas).EndInit();
            painelFase2.ResumeLayout(false);
            painelFase2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            panelFase3.ResumeLayout(false);
            panelFase3.PerformLayout();
            panelRelatorioFinal.ResumeLayout(false);
            panelRelatorioFinal.PerformLayout();
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
        private Panel panelRelatorioFinal;
        private Button buttonVoltarMenu;
        private Label lblTentativasFinal;
        private Label lblKillsFinal;
        private Label labelRelatorio;
    }
}
