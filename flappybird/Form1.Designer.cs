
namespace Flappybird
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            ((System.ComponentModel.ISupportInitialize)(this.Pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pipedown
            // 
            this.Pipedown.BackColor = System.Drawing.Color.Transparent;
            this.Pipedown.Image = ((System.Drawing.Image)(resources.GetObject("Pipedown.Image")));
            this.Pipedown.Location = new System.Drawing.Point(659, 233);
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
            this.Pipetop.Location = new System.Drawing.Point(659, 2);
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
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lives :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lyf1
            // 
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
            this.lyf2.Image = ((System.Drawing.Image)(resources.GetObject("lyf2.Image")));
            this.lyf2.Location = new System.Drawing.Point(238, 9);
            this.lyf2.Name = "lyf2";
            this.lyf2.Size = new System.Drawing.Size(25, 30);
            this.lyf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lyf2.TabIndex = 11;
            this.lyf2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Flappy Bird Marthijs Ydema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyf2)).EndInit();
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
    }
}

