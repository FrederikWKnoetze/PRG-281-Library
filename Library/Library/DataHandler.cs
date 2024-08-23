using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;

namespace Library
{
    
    internal class DataHandler
    {
        public static string connectionstring = "Data Source=LibraryData.sqlite;Version=3;";
        public static SQLiteConnection myconn = new SQLiteConnection(connectionstring);

        public static List<Reader> readerlist = new List<Reader>();
        public static List<Book> booklist = new List<Book>();

        public static void CreateData()
        {
            booklist.Add(new Book("111111111111", "A Song Of Ice And Fire", "Goerge", false,new List<string>{"Famtasy","Action"}));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            
        }











 
        public void CreateDatabase()
        {
            //Database code Start
            //
            //check to see if database admin exsists if not create it
            if (File.Exists("LibraryData.sqlite"))
            {
                // MessageBox.Show("file exsisst");
                //test mesage
            }
            else
            {
                SQLiteConnection.CreateFile("LibraryData.sqlite");
            }

            //open connection to database so it can be accsesed
            myconn.Open();
            string sql = "";

            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);


            //Create table of readers
            sql = "CREATE TABLE IF NOT EXISTS tblReaders(id varcar(13) NOT NULL PRIMARY KEY, firstname varchar(40), lastname varchar(40))";
            mycmd=new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();

            //create table of books
            sql = "CREATE TABLE IF NOT EXISTS tblBooks(isbn varchar(13), title varchar(40), author varchar(40))";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();








            //using (var reader = command.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        string userName = reader["UserName"].ToString();
            //        int age = int.Parse(reader["Age"].ToString());
            //    }

                //How to create table
                //sql = "Create table if not exists test (name varchar(20), numbers int)";
                //mycmd = new SQLiteCommand(sql, myconn);
                //mycmd.ExecuteNonQuery();


                //How to run sql
                //sql = "Insert into test (name,numbers) values ('testname',9000)";
                //mycmd = new SQLiteCommand(sql, myconn);
                //mycmd.ExecuteNonQuery();

                //How to put data into dragrid or something
                //sql = "select * from test";
                //mycmd = new SQLiteCommand(sql, myconn);
                //SQLiteDataAdapter adapter = new SQLiteDataAdapter(mycmd);
                //DataTable data = new DataTable();
                //adapter.Fill(data);


                //sql reader something for this
                //while (reader.Read())
                //{
                //    MessageBox.Show("Name: " + reader["name"] + "\tScore: " + reader["numbers"]);
                //}

                ////////Gideon CODE\\\\\\\\\
                //sql = "DROP TABLE IF EXISTS tblReadersTest";

                //using (SQLiteCommand cmdDeleteTable = new SQLiteCommand(sql, myconn))
                //{
                //    cmdDeleteTable.ExecuteNonQuery();
                //    //  MessageBox.Show("TBL deleted");
                //}


                //another way to create table
                //sql = "CREATE TABLE IF NOT EXISTS tblReadersTest (ID  VARCHAR(30), ReaderName VARCHAR(30))";
                //using (SQLiteCommand cmdReaders = new SQLiteCommand(sql, myconn)) // Renamed to cmdReaders
                //{
                //    cmdReaders.ExecuteNonQuery();
                //}

                // Insert dummy data into 'tblReaders'
                //Reader Gideon = new Reader("012345", "Gideon");

                //// Prepare the SQL query to insert the Reader object
                //sql = @"INSERT INTO tblReadersTest (ID, ReaderName) 
                //   VALUES (@ID, @ReaderName)";

                //// Use a parameterized query to avoid SQL injection
                //using (SQLiteCommand cmdInsertReader = new SQLiteCommand(sql, myconn))
                //{
                //    // Add parameters for ID and ReaderName
                //    cmdInsertReader.Parameters.AddWithValue("@ID", Gideon.ID);
                //    cmdInsertReader.Parameters.AddWithValue("@ReaderName", Gideon.Name);

                //    // Execute the query
                //    cmdInsertReader.ExecuteNonQuery();
                //}

                // Fetch data from 'tblReaders' table and display in DataGridView2
                //datagrid 2 is gone
                //sql = "SELECT * FROM tblReadersTest";
                //using (SQLiteCommand cmdSelectReaders = new SQLiteCommand(sql, myconn)) // Renamed to cmdSelectReaders
                //{
                //    SQLiteDataAdapter adapterReaders = new SQLiteDataAdapter(cmdSelectReaders);
                //    DataTable readerData = new DataTable();
                //    adapterReaders.Fill(readerData);
                //    //   dataGridView1.DataSource = readerData;
                //}

                //
                //Database code End





            }
    }
}
