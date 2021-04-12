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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadGame(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame1(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();

            gameWindow.Show();

            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Highscore gameWindow = new Highscore();

            gameWindow.Show();

            this.Hide();
        }
    }
    }

