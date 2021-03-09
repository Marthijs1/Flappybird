
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PHpipeup = new System.Windows.Forms.PictureBox();
            this.PHflappybird = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PHpipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHflappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PHpipeup
            // 
            this.PHpipeup.BackColor = System.Drawing.Color.Transparent;
            this.PHpipeup.Image = ((System.Drawing.Image)(resources.GetObject("PHpipeup.Image")));
            this.PHpipeup.Location = new System.Drawing.Point(609, 269);
            this.PHpipeup.Name = "PHpipeup";
            this.PHpipeup.Size = new System.Drawing.Size(100, 188);
            this.PHpipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PHpipeup.TabIndex = 3;
            this.PHpipeup.TabStop = false;
            // 
            // PHflappybird
            // 
            this.PHflappybird.BackColor = System.Drawing.Color.Transparent;
            this.PHflappybird.Image = ((System.Drawing.Image)(resources.GetObject("PHflappybird.Image")));
            this.PHflappybird.Location = new System.Drawing.Point(12, 142);
            this.PHflappybird.Name = "PHflappybird";
            this.PHflappybird.Size = new System.Drawing.Size(88, 63);
            this.PHflappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PHflappybird.TabIndex = 4;
            this.PHflappybird.TabStop = false;
            this.PHflappybird.Click += new System.EventHandler(this.PHflappybird_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(197)))), ((int)(((byte)(206)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PHflappybird);
            this.Controls.Add(this.PHpipeup);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PHpipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHflappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PHpipeup;
        private System.Windows.Forms.PictureBox PHflappybird;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

