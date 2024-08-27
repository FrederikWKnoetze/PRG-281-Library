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
            //SQLiteConnection.CreateFile("LibraryData.sqlite");

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

//            //Creation of dummy data for talbe readers inputting firstname and lastname
//            sql = @"
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Sannie', 'Koen');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('John', 'Doe');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Jane', 'Smith');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Alice', 'Johnson');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Bob', 'Williams');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Charlie', 'Brown');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('David', 'Jones');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Emma', 'Garcia');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Fiona', 'Martinez');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('George', 'Hernandez');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Hannah', 'Moore');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Ian', 'Taylor');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Julia', 'Anderson');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Kevin', 'Thomas');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Laura', 'Jackson');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Michael', 'White');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Nina', 'Lewis');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Oscar', 'Walker');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Paula', 'Hall');
//    INSERT INTO tblReaders(firstname, lastname) VALUES ('Quincy', 'Allen');
//";
//            mycmd = new SQLiteCommand(sql, myconn);
//            mycmd.ExecuteNonQuery();

//            //1 means true
//            //creation of dummy data for tblbooks inputting isbn code auther name and book title
//            sql = @"
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('1234567890123', 'The Silent Patient', 'Haruki Murakami', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('2345678901234', 'Where the Crawdads Sing', 'Jane Austen', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('3456789012345', 'Atomic Habits', 'George Orwell', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('4567890123456', 'Becoming', 'J.K. Rowling', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('5678901234567', 'The Night Circus', 'Ernest Hemingway', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('6789012345678', 'Sapiens: A Brief History of Humankind', 'Chimamanda Ngozi Adichie', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('7890123456789', 'The Alchemist', 'Margaret Atwood', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('8901234567890', 'Educated', 'Gabriel García Márquez', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('9012345678901', '1984', 'Stephen King', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('0123456789012', 'To Kill a Mockingbird', 'Toni Morrison', 1);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('1123456789013', 'The Great Gatsby', 'Agatha Christie', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('2123456789014', 'Circe', 'F. Scott Fitzgerald', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('3123456789015', 'The Catcher in the Rye', 'Kazuo Ishiguro', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('4123456789016', 'Dune', 'Virginia Woolf', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('5123456789017', 'The Road', 'Alice Walker', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('6123456789018', 'Brave New World', 'J.R.R. Tolkien', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('7123456789019', 'The Book Thief', 'Octavia Butler', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('8123456789020', 'The Girl on the Train', 'Neil Gaiman', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('9123456789021', 'Little Fires Everywhere', 'Isabel Allende', 0);
//    INSERT INTO tblBooks(isbn, title, author, borrowed) VALUES ('0234567890122', 'The Seven Husbands of Evelyn Hugo', 'Charles Dickens', 0);
//";
//            mycmd = new SQLiteCommand(sql, myconn);
//            mycmd.ExecuteNonQuery();

//            //creation of dummy data for tblbookgenres a book can have more than one genre
//            sql = @"
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Action', 1);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Drama', 2);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Fantasy', 3);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Science Fiction', 4);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Mystery', 5);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Romance', 6);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Thriller', 7);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Horror', 8);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Adventure', 9);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Historical', 10);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Comedy', 11);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Biography', 12);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Non-fiction', 13);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Poetry', 14);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Self-help', 15);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Philosophy', 16);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Religion', 17);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Science', 18);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Travel', 19);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Young Adult', 20);
//";
//            mycmd = new SQLiteCommand(sql, myconn);
//            mycmd.ExecuteNonQuery();

//            // 
//             sql = @"
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Action', 1);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Adventure', 2);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Comedy', 3);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Crime', 4);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Drama', 5);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Fantasy', 6);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Historical Fiction', 7);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Horror', 8);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Mystery', 9);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Romance', 10);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Science Fiction', 11);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Thriller', 12);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Western', 13);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Biography', 14);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Non-fiction', 15);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Self-help', 16);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Philosophy', 17);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Religion', 18);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Science', 19);
//    INSERT INTO tblBookGenres(genre, bookID) VALUES ('Travel', 20);
//";
//            mycmd = new SQLiteCommand(sql, myconn);
//            mycmd.ExecuteNonQuery();

//            //
//            sql = @"
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (1, 1);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (2, 2);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (3, 3);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (4, 4);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (5, 5);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (6, 6);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (7, 7);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (8, 8);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (9, 9);
//    INSERT INTO tblReaderBooks(bookID, readerID) VALUES (10, 10);";
//            mycmd = new SQLiteCommand(sql, myconn);
//            mycmd.ExecuteNonQuery();

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
