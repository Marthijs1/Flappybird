using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Flappybird
{

    public partial class GameScreen : Form
    {

        int pipespeed = 10;
        int gravity = 10;
        int score = 0;
        int totalscore = 0;
        int life = 4;
        int lowest = 5;

        private MySqlConnection connection;


        public GameScreen()
        {
            InitializeComponent();
            Game_menu.Hide();
            panel1.Hide();
            InitializeDatabaseConnection();

        }


        private void InitializeDatabaseConnection()
        {
            string server = "localhost";
            string database = "flappy bird";
            string dbUsername = "root";
            string dbPassword = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

            connection = new MySqlConnection(connectionString);

        }

        private bool OpenConnection()
        {
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
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
            if (life == 1)
            {
                lyf1.Image = Properties.Resources.life_white;
                pipespeed = 15;
                gametimer.Stop();
                panel1.Show();

                if (totalscore > lowest)
                {
                    panel1.Show();
                }
                else
                {
                    End EndWindow = new End(totalscore);

                    EndWindow.Show();

                    this.Hide();
                }



            }

            if (life == 2)
            {
                lyf2.Image = Properties.Resources.life_white;
                pipespeed = 15;
                Game_menu.Show();

            }
            if (life == 3)
            {
                lyf3.Image = Properties.Resources.life_white;
                pipespeed = 15;
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

            if (score > 5)
            {
                pipespeed = 15;
            }
            if (score > 10)
            {
                pipespeed = 20;
            }
            if (score > 15)
            {
                pipespeed = 25;
            }
            if (score > 20)
            {
                pipespeed = 30;
            }
            if (score > 25)
            {
                pipespeed = 35;
            }


        }








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
            totalscore = totalscore + score;
            score = 0;



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
            pipespeed = 15;


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void lbl_restart_Click_1(object sender, EventArgs e)
        {
            Game_menu.Hide();
            Flappybird.Location = new Point(16, 152);
            gametimer.Start();
            Score.Text = "Score: 0";
            pipespeed = 15;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_restart_Click_2(object sender, EventArgs e)
        {
            Game_menu.Hide();
            Flappybird.Location = new Point(16, 152);
            gametimer.Start();
            Score.Text = "Score: 0";
            pipespeed = 15;
        }


        private void addscore()

        {

            string insertQuerry = "INSERT INTO score(Name, Score) VALUES (@Name, " + totalscore +")";


            connection.Open();


            MySqlCommand cmd = new MySqlCommand(insertQuerry, connection);


            cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 60);
            cmd.Parameters.Add("@Score", MySqlDbType.VarChar, 100);
         //   cmd.Parameters.Add("@DateTIme", MySqlDbType.VarChar, 100);


            cmd.Parameters["@Name"].Value = tbname.Text;
            cmd.Parameters["@Score"].Value = totalscore;
          //  cmd.Parameters["@DateTIme"].Value = txbDate.Text;

            if (cmd.ExecuteNonQuery() == 1)

            {

                tbname.Text = "score opgeslagen" + "\r\n";

            }

            CloseConnection();

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addscore();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}  
