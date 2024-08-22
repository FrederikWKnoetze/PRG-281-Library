using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            //test
=======

            //check to see if database admin exsists if not create it
            if (File.Exists("admin.sqlite"))
            {
                // MessageBox.Show("file exsisst");
                //test mesage
            } else
            {
                SQLiteConnection.CreateFile("admin.sqlite");
            }
            //open connection to database so it can be accsesed
            string connectionstring = "Data Source=admin.sqlite;Version=3;Encryption=SQLiteCrypt";
            SQLiteConnection myconn = new SQLiteConnection(connectionstring);
            myconn.Open();


            string sql = "";
            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);



            //try
            //{
            //    sql = "Create table test (name varchar(20), numbers int)";
            //    mycmd = new SQLiteCommand(sql, myconn);
            //    mycmd.ExecuteNonQuery();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("table exsisted");
            //    throw;
            //}
            //for this to work will need more code.

            //creates table is it does not exsist
            sql = "Create table if not exists test (name varchar(20), numbers int)";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();


            //there is enough dummy data
            sql = "Insert into test (name,numbers) values ('testname',9000)";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            sql = "Insert into test (name,numbers) values ('testname1',9001)";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            sql = "Insert into test (name,numbers) values ('testname2',9002)";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            sql = "Insert into test (name,numbers) values ('testname3',9003)";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();


            // SQLiteDataReader reader = mycmd.ExecuteReader();
            //get data into datagrid
            sql = "select * from test";
            mycmd = new SQLiteCommand(sql, myconn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(mycmd);
            DataTable data = new DataTable();
            adapter.Fill(data);

            //display dummy data to test
            //while (reader.Read())
            //{
            //    MessageBox.Show("Name: " + reader["name"] + "\tScore: " + reader["numbers"]);
            //}

            ////////Gideon CODE\\\\\\\\\
            sql = "DROP TABLE IF EXISTS tblReadersTest";

            using (SQLiteCommand cmdDeleteTable = new SQLiteCommand(sql, myconn))
            {
                cmdDeleteTable.ExecuteNonQuery();
                MessageBox.Show("TBL deleted");
            }


            sql = "CREATE TABLE IF NOT EXISTS tblReadersTest (ID  VARCHAR(30), ReaderName VARCHAR(30))";
            using (SQLiteCommand cmdReaders = new SQLiteCommand(sql, myconn)) // Renamed to cmdReaders
            {
                cmdReaders.ExecuteNonQuery();
            }

            // Insert dummy data into 'tblReaders'
            Reader Gideon = new Reader("012345", "Gideon");

            // Prepare the SQL query to insert the Reader object
            sql = @"INSERT INTO tblReadersTest (ID, ReaderName) 
               VALUES (@ID, @ReaderName)";

            // Use a parameterized query to avoid SQL injection
            using (SQLiteCommand cmdInsertReader = new SQLiteCommand(sql, myconn))
            {
                // Add parameters for ID and ReaderName
                cmdInsertReader.Parameters.AddWithValue("@ID", Gideon.ID);
                cmdInsertReader.Parameters.AddWithValue("@ReaderName", Gideon.Name);

                // Execute the query
                cmdInsertReader.ExecuteNonQuery();
            }
            // Fetch data from 'tblReaders' table and display in DataGridView2
            sql = "SELECT * FROM tblReadersTest";
            using (SQLiteCommand cmdSelectReaders = new SQLiteCommand(sql, myconn)) // Renamed to cmdSelectReaders
            {
                SQLiteDataAdapter adapterReaders = new SQLiteDataAdapter(cmdSelectReaders);
                DataTable readerData = new DataTable();
                adapterReaders.Fill(readerData);
            }
>>>>>>> Stashed changes
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
<<<<<<< Updated upstream
                int TempID = random.Next(10000,99999);
                Reader Test = new Reader(TempID.ToString(),"Test");
                
            }
            Reader Gideon = new Reader("12345", "Gideon");
            foreach (Reader reader in Reader.AllReaders)
            {
                string testID = textBox1.Text;
                string testName = textBox2.Text;
=======
                // Add parameters with the entered values
                command.Parameters.AddWithValue("@EnteredID", txtID.Text);
                command.Parameters.AddWithValue("@EnteredName", txtPassword.Text);
>>>>>>> Stashed changes

                if (testID == reader.ID && testName == reader.Name)
                {

                    MessageBox.Show($"ID: {reader.ID}, Name: {reader.Name}");
                }
<<<<<<< Updated upstream
=======
                catch (Exception ex)
                {
                    // Handle any errors that might have occurred
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "ID";
                txtID.ForeColor = Color.Silver;
            }
            else
            {
                txtID.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Name")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Name";
                txtPassword.ForeColor = Color.Silver;
            }
            else
            {
                txtPassword.ForeColor = Color.Black;
>>>>>>> Stashed changes
            }
        }
    }
}
