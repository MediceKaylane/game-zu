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
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // txtAmmo
            // 
            txtAmmo.AutoSize = true;
            txtAmmo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmmo.ForeColor = Color.White;
            txtAmmo.Location = new Point(17, 20);
            txtAmmo.Margin = new Padding(4, 0, 4, 0);
            txtAmmo.Name = "txtAmmo";
            txtAmmo.Size = new Size(114, 29);
            txtAmmo.TabIndex = 0;
            txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(491, 20);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(92, 29);
            txtScore.TabIndex = 0;
            txtScore.Text = "Kills: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(857, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 29);
            label1.TabIndex = 0;
            label1.Text = "Health: ";
            // 
            // healthBar
            // 
            healthBar.Location = new Point(967, 20);
            healthBar.Margin = new Padding(4, 5, 4, 5);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(249, 35);
            healthBar.TabIndex = 1;
            healthBar.Value = 100;
            // 
            // player
            // 
            player.Image = Properties.Resources.up;
            player.Location = new Point(569, 725);
            player.Margin = new Padding(4, 5, 4, 5);
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
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.ForeColor = SystemColors.ButtonFace;
            lblGameOver.Location = new Point(439, 231);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(260, 20);
            lblGameOver.TabIndex = 3;
            lblGameOver.Text = "Pressione enter para jogar novamente";
            lblGameOver.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1232, 1017);
            Controls.Add(lblGameOver);
            Controls.Add(label2);
            Controls.Add(player);
            Controls.Add(healthBar);
            Controls.Add(label1);
            Controls.Add(txtScore);
            Controls.Add(txtAmmo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Zombie Shootout Game MOO ICT";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
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
    }
}
