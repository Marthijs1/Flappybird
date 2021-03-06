
namespace Flappybird
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.Pipedown = new System.Windows.Forms.PictureBox();
            this.Flappybird = new System.Windows.Forms.PictureBox();
            this.Pipetop = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.Ground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lyf1 = new System.Windows.Forms.PictureBox();
            this.lyf3 = new System.Windows.Forms.PictureBox();
            this.lyf2 = new System.Windows.Forms.PictureBox();
            this.Game_menu = new System.Windows.Forms.GroupBox();
            this.highscore2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            ((System.ComponentModel.ISupportInitialize)(this.Pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf2)).BeginInit();
            this.Game_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pipedown
            // 
            this.Pipedown.BackColor = System.Drawing.Color.Transparent;
            this.Pipedown.Image = ((System.Drawing.Image)(resources.GetObject("Pipedown.Image")));
            this.Pipedown.Location = new System.Drawing.Point(673, 273);
            this.Pipedown.Name = "Pipedown";
            this.Pipedown.Size = new System.Drawing.Size(100, 176);
            this.Pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipedown.TabIndex = 3;
            this.Pipedown.TabStop = false;
            // 
            // Flappybird
            // 
            this.Flappybird.BackColor = System.Drawing.Color.Transparent;
            this.Flappybird.Image = ((System.Drawing.Image)(resources.GetObject("Flappybird.Image")));
            this.Flappybird.Location = new System.Drawing.Point(16, 152);
            this.Flappybird.Name = "Flappybird";
            this.Flappybird.Size = new System.Drawing.Size(88, 63);
            this.Flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappybird.TabIndex = 4;
            this.Flappybird.TabStop = false;
            this.Flappybird.Click += new System.EventHandler(this.PHflappybird_Click);
            // 
            // Pipetop
            // 
            this.Pipetop.BackColor = System.Drawing.Color.Transparent;
            this.Pipetop.Image = ((System.Drawing.Image)(resources.GetObject("Pipetop.Image")));
            this.Pipetop.Location = new System.Drawing.Point(605, -8);
            this.Pipetop.Name = "Pipetop";
            this.Pipetop.Size = new System.Drawing.Size(100, 116);
            this.Pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipetop.TabIndex = 5;
            this.Pipetop.TabStop = false;
            this.Pipetop.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Ranchers", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Transparent;
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(81, 24);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score : 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(98)))), ((int)(((byte)(51)))));
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-5, 399);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(837, 92);
            this.Ground.TabIndex = 7;
            this.Ground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ranchers", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Levens :";
            // 
            // lyf1
            // 
            this.lyf1.BackColor = System.Drawing.Color.Transparent;
            this.lyf1.Image = ((System.Drawing.Image)(resources.GetObject("lyf1.Image")));
            this.lyf1.Location = new System.Drawing.Point(207, 9);
            this.lyf1.Name = "lyf1";
            this.lyf1.Size = new System.Drawing.Size(25, 30);
            this.lyf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lyf1.TabIndex = 9;
            this.lyf1.TabStop = false;
            // 
            // lyf3
            // 
            this.lyf3.BackColor = System.Drawing.Color.Transparent;
            this.lyf3.Image = ((System.Drawing.Image)(resources.GetObject("lyf3.Image")));
            this.lyf3.Location = new System.Drawing.Point(269, 9);
            this.lyf3.Name = "lyf3";
            this.lyf3.Size = new System.Drawing.Size(25, 30);
            this.lyf3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lyf3.TabIndex = 10;
            this.lyf3.TabStop = false;
            // 
            // lyf2
            // 
            this.lyf2.BackColor = System.Drawing.Color.Transparent;
            this.lyf2.Image = ((System.Drawing.Image)(resources.GetObject("lyf2.Image")));
            this.lyf2.Location = new System.Drawing.Point(238, 9);
            this.lyf2.Name = "lyf2";
            this.lyf2.Size = new System.Drawing.Size(25, 30);
            this.lyf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lyf2.TabIndex = 11;
            this.lyf2.TabStop = false;
            // 
            // Game_menu
            // 
            this.Game_menu.BackColor = System.Drawing.Color.Transparent;
            this.Game_menu.Controls.Add(this.highscore2);
            this.Game_menu.Controls.Add(this.pictureBox1);
            this.Game_menu.Controls.Add(this.label3);
            this.Game_menu.Controls.Add(this.label4);
            this.Game_menu.Controls.Add(this.lbl_restart);
            this.Game_menu.Controls.Add(this.label2);
            this.Game_menu.Font = new System.Drawing.Font("Ranchers", 14.25F, System.Drawing.FontStyle.Bold);
            this.Game_menu.Location = new System.Drawing.Point(216, 78);
            this.Game_menu.Name = "Game_menu";
            this.Game_menu.Size = new System.Drawing.Size(307, 191);
            this.Game_menu.TabIndex = 12;
            this.Game_menu.TabStop = false;
            this.Game_menu.Text = "Menu";
            // 
            // highscore2
            // 
            this.highscore2.Location = new System.Drawing.Point(68, 195);
            this.highscore2.Name = "highscore2";
            this.highscore2.Size = new System.Drawing.Size(200, 100);
            this.highscore2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ranchers", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Afsluiten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ranchers", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(110, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score : 0";
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.Font = new System.Drawing.Font("Ranchers", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_restart.ForeColor = System.Drawing.Color.White;
            this.lbl_restart.Location = new System.Drawing.Point(119, 113);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(72, 24);
            this.lbl_restart.TabIndex = 1;
            this.lbl_restart.Text = "Restart";
            this.lbl_restart.Click += new System.EventHandler(this.lbl_restart_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ranchers", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(93, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Game Over!!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Location = new System.Drawing.Point(269, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ranchers", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vul hier uw naam in";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(50, 27);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 0;
            this.tbname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Game_menu);
            this.Controls.Add(this.lyf2);
            this.Controls.Add(this.lyf3);
            this.Controls.Add(this.lyf1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Pipetop);
            this.Controls.Add(this.Flappybird);
            this.Controls.Add(this.Pipedown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Marthijs Ydema";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf2)).EndInit();
            this.Game_menu.ResumeLayout(false);
            this.Game_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pipedown;
        private System.Windows.Forms.PictureBox Flappybird;
        private System.Windows.Forms.PictureBox Pipetop;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lyf1;
        private System.Windows.Forms.PictureBox lyf3;
        private System.Windows.Forms.PictureBox lyf2;
        private System.Windows.Forms.GroupBox Game_menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel highscore2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
    }
}

