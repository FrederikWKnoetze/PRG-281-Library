using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Threading;

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
            dataGridView1.DataSource = data;

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
                dataGridView1.DataSource = readerData;
            }
            this.Hide();// Show the new form
            frmAdd_Book newForm = new frmAdd_Book(); // Create instance of the new form
            newForm.Show();
            
            


        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string (update with your database details)
            string connectionString = "Data Source=admin.sqlite;Version=3;";

            // SQL query with parameters
            string query = "SELECT COUNT(*) FROM tblReadersTest WHERE ID = @EnteredID AND ReaderName = @EnteredName";

            // Use SQLiteConnection instead of SqlConnection
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Add parameters with the entered values
                command.Parameters.AddWithValue("@EnteredID", textBox1.Text);
                command.Parameters.AddWithValue("@EnteredName", textBox2.Text);

                try
                {
                    connection.Open();
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    // If count is greater than 0, the ID and name are correct
                    // Implement your logic here, for example:
                    if (userCount > 0)
                    {
                        // Authentication successful
                        MessageBox.Show("ID and Name are correct.");
                    }
                    else
                    {
                        // Authentication failed
                        MessageBox.Show("Invalid ID or Name.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that might have occurred
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "ID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "ID";
                textBox1.ForeColor = Color.Silver;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Name";
                textBox2.ForeColor = Color.Silver;
            }
            else
            {
                textBox2.ForeColor = Color.Black;
            }
        }
    }
} 
