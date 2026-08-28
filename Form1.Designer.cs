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
            txtAmmo = new Label();
            txtScore = new Label();
            label1 = new Label();
            healthBar = new ProgressBar();
            player = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            lblGameOver = new Label();
            labelFase1Concluida = new Label();
            painelFase2 = new Panel();
            buttonContinuar = new Button();
            labelFase2Comacando = new Label();
            txtArames = new Label();
            labelMensagemTeclaE = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            painelFase2.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmmo.ForeColor = Color.DarkOrange;
            txtAmmo.Location = new Point(15, 15);
            txtAmmo.Margin = new Padding(4, 0, 4, 0);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(93, 24);
            txtAmmo.TabIndex = 0;
            txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = Color.DarkOrange;
            txtScore.Location = new Point(430, 15);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(71, 24);
            txtScore.TabIndex = 0;
            txtScore.Text = "Kills: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(750, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "Health: ";
            // 
            // healthBar
            // 
            healthBar.Location = new Point(846, 15);
            healthBar.Margin = new Padding(4);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(218, 26);
            healthBar.TabIndex = 1;
            healthBar.Value = 100;
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(64, 64, 64);
            player.Image = Properties.Resources.up;
            player.Location = new Point(498, 544);
            player.Margin = new Padding(4);
            player.Name = "player";
            player.Size = new Size(71, 100);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimerEvent;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 0;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("BankGothic Md BT", 30F);
            lblGameOver.ForeColor = SystemColors.ButtonFace;
            lblGameOver.Location = new Point(86, 360);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(904, 41);
            lblGameOver.TabIndex = 3;
            lblGameOver.Text = "Pressione enter para jogar novamente";
            lblGameOver.Visible = false;
            // 
            // labelFase1Concluida
            // 
            labelFase1Concluida.AutoSize = true;
            labelFase1Concluida.Font = new Font("BankGothic Md BT", 35F);
            labelFase1Concluida.ForeColor = Color.Orange;
            labelFase1Concluida.Location = new Point(77, 34);
            labelFase1Concluida.Name = "labelFase1Concluida";
            labelFase1Concluida.Size = new Size(577, 49);
            labelFase1Concluida.TabIndex = 4;
            labelFase1Concluida.Text = "FASE 1 CONCLUÍDA!";
            labelFase1Concluida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // painelFase2
            // 
            painelFase2.BackColor = Color.Black;
            painelFase2.BorderStyle = BorderStyle.FixedSingle;
            painelFase2.Controls.Add(buttonContinuar);
            painelFase2.Controls.Add(labelFase2Comacando);
            painelFase2.Controls.Add(labelFase1Concluida);
            painelFase2.Location = new Point(197, 156);
            painelFase2.Name = "painelFase2";
            painelFase2.Size = new Size(712, 360);
            painelFase2.TabIndex = 5;
            // 
            // buttonContinuar
            // 
            buttonContinuar.BackColor = SystemColors.ButtonFace;
            buttonContinuar.Font = new Font("BankGothic Md BT", 12F);
            buttonContinuar.ForeColor = Color.DarkOrange;
            buttonContinuar.Location = new Point(271, 222);
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
            labelFase2Comacando.Font = new Font("BankGothic Lt BT", 18F);
            labelFase2Comacando.ForeColor = Color.DarkOrange;
            labelFase2Comacando.Location = new Point(167, 143);
            labelFase2Comacando.Name = "labelFase2Comacando";
            labelFase2Comacando.Size = new Size(368, 25);
            labelFase2Comacando.TabIndex = 5;
            labelFase2Comacando.Text = "A fase 2 está começando...";
            // 
            // txtArames
            // 
            txtArames.AutoSize = true;
            txtArames.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtArames.ForeColor = Color.DarkOrange;
            txtArames.Location = new Point(209, 17);
            txtArames.Margin = new Padding(4, 0, 4, 0);
            txtArames.Name = "txtArames";
            txtArames.Size = new Size(104, 24);
            txtArames.TabIndex = 6;
            txtArames.Text = "Arames: 3";
            // 
            // labelMensagemTeclaE
            // 
            labelMensagemTeclaE.AutoSize = true;
            labelMensagemTeclaE.Font = new Font("BankGothic Md BT", 15F);
            labelMensagemTeclaE.ForeColor = SystemColors.ButtonFace;
            labelMensagemTeclaE.Location = new Point(197, 95);
            labelMensagemTeclaE.Name = "labelMensagemTeclaE";
            labelMensagemTeclaE.Size = new Size(662, 21);
            labelMensagemTeclaE.TabIndex = 7;
            labelMensagemTeclaE.Text = "Pressione a tecla E para ativar lançar arame pela arena";
            labelMensagemTeclaE.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1078, 763);
            Controls.Add(labelMensagemTeclaE);
            Controls.Add(txtArames);
            Controls.Add(painelFase2);
            Controls.Add(lblGameOver);
            Controls.Add(label2);
            Controls.Add(player);
            Controls.Add(healthBar);
            Controls.Add(label1);
            Controls.Add(txtScore);
            Controls.Add(txtAmmo);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Zombie Shootout Game MOO ICT";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            painelFase2.ResumeLayout(false);
            painelFase2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private Label label2;
        private Label lblGameOver;
        private Label labelFase1Concluida;
        private Panel painelFase2;
        private Label labelFase2Comacando;
        private Button buttonContinuar;
        private Label txtArames;
        private Label labelMensagemTeclaE;
    }
}
