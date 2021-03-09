
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
            ((System.ComponentModel.ISupportInitialize)(this.Pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipetop)).BeginInit();
            this.SuspendLayout();
            // 
            // Pipedown
            // 
            this.Pipedown.BackColor = System.Drawing.Color.Transparent;
            this.Pipedown.Image = ((System.Drawing.Image)(resources.GetObject("Pipedown.Image")));
            this.Pipedown.Location = new System.Drawing.Point(609, 281);
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
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(81, 24);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score : 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pipedown;
        private System.Windows.Forms.PictureBox Flappybird;
        private System.Windows.Forms.PictureBox Pipetop;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gametimer;
    }
}

