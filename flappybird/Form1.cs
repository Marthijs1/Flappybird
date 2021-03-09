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
    public partial class Form1 : Form
    {

        int pipespeed = 8;
        int gravity = 5;
        int score = 0;



        public Form1()
        {
            InitializeComponent();
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

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Flappybird.Top += gravity;
            Pipedown.Left -= pipespeed;
            Pipetop.Left -= pipespeed;
            Score.Text = score.ToString();

            if (Pipedown.Left <-50)
            {
                Pipedown.Left = 800;
                score++;
              }
             
            if(Pipetop.Left < -80)
            {
                Pipetop.Left = 950;
                score++;
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
            private void endGame()
            {
                gametimer.Stop();
                Score.Text += " Game over";
            }
       
        
        }



    }
}      
