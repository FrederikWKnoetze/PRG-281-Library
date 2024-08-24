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
using System.Windows.Forms;

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
            /*
            booklist.Add(new Book("111111111111", "A Song Of Ice And Fire", "Goerge", 0,new List<string>{"Famtasy","Action"}));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));
            readerlist.Add(new Reader("111111111111", "Sannie", "Koen"));*/
            
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


            //this is temp remember to delete
            SQLiteConnection.CreateFile("LibraryData.sqlite");




            //open connection to database so it can be accsesed
            myconn.Open();
            string sql = "";

            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);


            //Create table of readers
            sql = "CREATE TABLE IF NOT EXISTS tblReaders(readerID INTEGER PRIMARY KEY AUTOINCREMENT, firstname varchar(40) NOT NULL, lastname varchar(40) NOT NULL)";
            mycmd=new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            //create table of books
            sql = "CREATE TABLE IF NOT EXISTS tblBooks(bookID INTEGER PRIMARY KEY AUTOINCREMENT,isbn varchar(13), title varchar(40) NOT NULL, author varchar(40) NOT NULL, borrowed INTEGER )";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            //Create table of book genres
            //not space effecient by my sanity effecient
            sql = "CREATE TABLE IF NOT EXISTS tblBookGenres(genreID INTEGER PRIMARY KEY AUTOINCREMENT, genre TEXT, bookID INTEGER NOT NULL, FOREIGN KEY(bookID) REFERENCES tblBooks(bookID))";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            //create table of reader books
            sql = "CREATE TABLE IF NOT EXISTS tblReaderBooks(readerbookID INTEGER PRIMARY KEY AUTOINCREMENT,bookID INTEGER NOT NULL, readerID INTEGER NOT NULL, FOREIGN KEY(readerID) REFERENCES tblReaders(readerID), FOREIGN KEY(bookID) REFERENCES tblBooks(bookID))";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();


            //on program start run this on a thread to put it into objects


            //Creation of dummy data for talbe readers inputting firstname and lastname
            sql = @"
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Sannie', 'Koen');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('John', 'Doe');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Jane', 'Smith');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Alice', 'Johnson');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Bob', 'Williams');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Charlie', 'Brown');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('David', 'Jones');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Emma', 'Garcia');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Fiona', 'Martinez');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('George', 'Hernandez');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Hannah', 'Moore');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Ian', 'Taylor');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Julia', 'Anderson');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Kevin', 'Thomas');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Laura', 'Jackson');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Michael', 'White');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Nina', 'Lewis');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Oscar', 'Walker');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Paula', 'Hall');
    INSERT INTO tblReaders(firstname, lastname) VALUES ('Quincy', 'Allen');
";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();


            //creation of dummy data for tblbooks inputting isbn code auther name and book title
            sql = @"
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('1234567890123', 'Book Title 1', 'Author 1', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('2345678901234', 'Book Title 2', 'Author 2', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('3456789012345', 'Book Title 3', 'Author 3', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('4567890123456', 'Book Title 4', 'Author 4', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('5678901234567', 'Book Title 5', 'Author 5', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('6789012345678', 'Book Title 6', 'Author 6', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('7890123456789', 'Book Title 7', 'Author 7', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('8901234567890', 'Book Title 8', 'Author 8', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('9012345678901', 'Book Title 9', 'Author 9', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('0123456789012', 'Book Title 10', 'Author 10', 1);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('1123456789013', 'Book Title 11', 'Author 11', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('2123456789014', 'Book Title 12', 'Author 12', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('3123456789015', 'Book Title 13', 'Author 13', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('4123456789016', 'Book Title 14', 'Author 14', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('5123456789017', 'Book Title 15', 'Author 15', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('6123456789018', 'Book Title 16', 'Author 16', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('7123456789019', 'Book Title 17', 'Author 17', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('8123456789020', 'Book Title 18', 'Author 18', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('9123456789021', 'Book Title 19', 'Author 19', 0);
    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('0234567890122', 'Book Title 20', 'Author 20', 0);
";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();

            //creation of dummy data for tblbookgenres a book can have more than one genre
            sql = @"
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Action', 1);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Drama', 2);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Fantasy', 3);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Science Fiction', 4);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Mystery', 5);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Romance', 6);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Thriller', 7);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Horror', 8);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Adventure', 9);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Historical', 10);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Comedy', 11);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Biography', 12);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Non-fiction', 13);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Poetry', 14);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Self-help', 15);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Philosophy', 16);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Religion', 17);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Science', 18);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Travel', 19);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Young Adult', 20);
";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();

            // 
             sql = @"
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Action', 1);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Adventure', 2);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Comedy', 3);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Crime', 4);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Drama', 5);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Fantasy', 6);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Historical Fiction', 7);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Horror', 8);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Mystery', 9);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Romance', 10);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Science Fiction', 11);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Thriller', 12);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Western', 13);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Biography', 14);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Non-fiction', 15);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Self-help', 16);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Philosophy', 17);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Religion', 18);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Science', 19);
    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Travel', 20);
";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();

            //
            sql = @"
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (1, 1);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (2, 2);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (3, 3);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (4, 4);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (5, 5);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (6, 6);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (7, 7);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (8, 8);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (9, 9);
    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (10, 10);";
            mycmd = new SQLiteCommand(sql, myconn);
            mycmd.ExecuteNonQuery();










            //sql = "Select * from tblReaders";
            //mycmd = new SQLiteCommand(sql, myconn);

            //using (var reader = mycmd.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        MessageBox.Show(reader["firstname"].ToString());
            //    }
            //}




                //sql = "Insert into test (name,numbers) values ('testname',9000)";
                //mycmd = new SQLiteCommand(sql, myconn);
                //mycmd.ExecuteNonQuery();





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
