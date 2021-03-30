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


        public Highscore()

        {
            InitializeComponent();

            InitializeDatabaseConnection();
            List<string>[] allDevices = GetAllscores();

            for (int i = 0; i < allDevices[0].Count; i++)
            {
                ListViewItem newDeviceItem = new ListViewItem(new string[]
                {
                    allDevices[0][i],
                    allDevices[1][i],
                    allDevices[2][i],
                    allDevices[3][i],
                });

                listView1.Items.Add(newDeviceItem);
            }

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

        public List<string>[] GetAllscores()
        {

            string sqlQuery = "SELECT * FROM score";
            //   new DateTime = DateTime;

            List<string>[] resultList = new List<string>[6];
            resultList[0] = new List<string>();
            resultList[1] = new List<string>();
            resultList[2] = new List<string>();
            resultList[3] = new List<string>();


            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    resultList[0].Add(dataReader["Position"] + "");
                    resultList[1].Add(dataReader["Score"] + "");
                    resultList[2].Add(dataReader["Name"] + "");
                    resultList[3].Add(dataReader["DateTime"] + "");



                }
                dataReader.Close();

                this.CloseConnection();

                return resultList;
            }
            else
            {
                return resultList;
            }
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnLoadClick(object sender, EventArgs e)
        {


            // listView1.Columns.Add("Position");
            //  listView1.Columns.Add("Name", 70, HorizontalAlignment.Center);
            //listView1.Columns.Add("Date", 70, HorizontalAlignment.Center);
            // listView1.Columns.Add("Time", 70, HorizontalAlignment.Right);
            //listView1.View = View.Details;

            //     List<string>[] allDevices = GetAllscores();

            //     for (int i = 0; i < allDevices[0].Count; i++)
            //  {
            //   ListViewItem newDeviceItem = new ListViewItem(new string[]
            //   {
            //     allDevices[0][i],
            //    allDevices[1][i],
            //   allDevices[2][i],





            //  });


    }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}
        //   private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        
    

