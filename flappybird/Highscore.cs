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
    public partial class Highscore : Form
    {
        private MySqlConnection connection;

        public Highscore(int totolscore)

        {
            InitializeComponent();


        }
        private void InitializeDatabaseConnection()
        {
            string server = "localhost";
            string database = "flappy bird";
            string dbUsername = "root";
            string dbPassword = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";








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



        private void pictureBox3_Click(object sender, EventArgs e)
        {
        Close();
        }

    private void pictureBox5_Click(object sender, EventArgs e)
        {
        Form2 gameWindow = new Form2();

        gameWindow.Show();

        this.Hide();


        }

        private void tbscore_TextChanged(object sender, EventArgs e)
        {
            
        }
    }   
}
