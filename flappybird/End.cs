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
    public partial class End : Form
    {
        public End(int totalscore)
        {
            InitializeComponent();
            eindscore.Text = totalscore.ToString();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();

            gameWindow.Show();

            this.Hide();
        }

        private void eindscore_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
