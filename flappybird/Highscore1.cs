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
    public partial class Highscore1 : Form



    {
        private MySqlConnection connection;
        public Highscore1()
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

            connection = new MySqlConnection(connectionString);






        }

        private bool OpenConnection()
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

        private void sql(int totalscore)

        {

            OpenConnection();




            string insertQuerry = "INSERT INTO scores( Name, Score) VALUES (@Naam, " + totalscore + ")";




            MySqlCommand cmd = new MySqlCommand(insertQuerry, connection);




            cmd.Parameters.Add("@Naam", MySqlDbType.VarChar, 25);

            cmd.Parameters["@Naam"].Value = tbname.Text;




            if (cmd.ExecuteNonQuery() == 1)

            {

                tbname.Text = "score opgeslagen" + "\r\n";






            }




            CloseConnection();
        }
    }
}