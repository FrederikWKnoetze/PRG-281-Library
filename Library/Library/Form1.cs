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
            SQLiteConnection.CreateFile("admin.sqlite");

            string connectionstring = "Data Source=admin.sqlite;Version=3;Encryption=SQLiteCrypt";
            SQLiteConnection myconn= new SQLiteConnection(connectionstring);
            myconn.Open();

            string sql = "Create table test (name varchar(20), numbers int)";
            SQLiteCommand mycmd = new SQLiteCommand(sql,myconn);
            mycmd.ExecuteNonQuery();

            sql = "Insert into test (name,numbers) values ('testname',9000)";
            mycmd = new SQLiteCommand(sql,myconn);
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

            sql = "select * from test";
            mycmd= new SQLiteCommand(sql, myconn);
            SQLiteDataReader reader = mycmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show("Name: " + reader["name"] + "\tScore: " + reader["numbers"]);
            }
            dataGridView1.DataSource = reader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int TempID = random.Next(10000,99999);
                Reader Test = new Reader(TempID.ToString(),"Test");
                
            }
            Reader Gideon = new Reader("12345", "Gideon");
            foreach (Reader reader in Reader.AllReaders)
            {
                string testID = textBox1.Text;
                string testName = textBox2.Text;

                if (testID == reader.ID && testName == reader.Name)
                {

                    MessageBox.Show($"ID: {reader.ID}, Name: {reader.Name}");
                }
            }
        }
    }
}
