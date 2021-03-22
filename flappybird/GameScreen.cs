using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappybird
{
    public partial class GameScreen : Form
    {

        int pipespeed = 15;
        int gravity = 10;
        int score = 0;
        int life = 4;


        

        public GameScreen()
        {
            InitializeComponent();
            Game_menu.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PHflappybird_Click(object sender, EventArgs e)
        {

        }

        private void life_index()
        {
            if(life==1)
            {
                lyf1.Image = Properties.Resources.life_white;
                pipespeed = 10;
                gametimer.Stop();

                End EndWindow = new End();

                EndWindow.Show();

                this.Hide();


            }
            if (life==2)
            {
                lyf2.Image = Properties.Resources.life_white;
                pipespeed = 10;
                Game_menu.Show();
               
            }
            if(life==3)
            {
                lyf3.Image = Properties.Resources.life_white;
                pipespeed = 10;
                Game_menu.Show();
                

            }
        }

  



        private void gameTimerEvent(object sender, EventArgs e)
        {
            Flappybird.Top += gravity;
            Pipedown.Left -= pipespeed;
            Pipetop.Left -= pipespeed;
            Score.Text = score.ToString();

            if (Pipedown.Left < -50)
            {
                Pipedown.Left = 800;
                score++;
            }

            if (Pipetop.Left < -80)
            {
                Pipetop.Left = 950;
               
            }

            if (Flappybird.Bounds.IntersectsWith(Pipedown.Bounds) ||
                Flappybird.Bounds.IntersectsWith(Pipetop.Bounds) ||
                Flappybird.Bounds.IntersectsWith(Ground.Bounds) || Flappybird.Top < -25)


            {
                endGame();
                life = life - 1;
                life_index();
            }

            if(score > 5)
            {
               pipespeed = 15;
            }


        }

       // private void ResetGame();
            

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -11;
            }

        }


            private void gamekeyisup(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Space)
                {
                    gravity = 11;
                }
            }


        private void endGame()
        {

            gametimer.Stop();


            //End EndWindow = new End();

           // EndWindow.Show();


        }

       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_restart_Click(object sender, EventArgs e)
        {
            Game_menu.Hide();
            Flappybird.Location = new Point(16, 152);
            gametimer.Start();
            Score.Text = "Score: 0";
            pipespeed = 5;
            
      
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


  
