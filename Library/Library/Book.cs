using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    interface IUpdateBookDB
    {
        void UpdateBookDB();
    }
    internal class Book : IUpdateBookDB
    {
        private string isbn;
        private string title;
        private string author;
        private int borrowed;
        private string genres;

        public string ISBN
        {   get { return isbn; } 
            set { isbn = value; } 
        }
        public string Title
        {   get { return title; } 
            set { title = value; } 
        }
        public string Author
        {   get { return author; }
            set { author = value; } 
        }
        public int Borrowed
        {   get { return borrowed; }
            set { borrowed = value; } 
        }
        public string Genres
        {   get { return genres; } 
            set { genres = value; } 
        }

        public Book(string _ISBN, string _Title, string _Author, string _Genres, int _Borrowed)
        {
            this.isbn = _ISBN;
            this.title = _Title;
            this.author = _Author;
            this.genres = _Genres;
            this.borrowed = _Borrowed;
        }
        public void UpdateBookDB()
        {
            try
            {
                // Check if the connection is properly initialized and not open already
                if (DataHandler.myconn == null)
                {
                    DataHandler.myconn = new SQLiteConnection("Data Source=LibraryData.sqlite;Version=3;");
                }

                // Open the connection only if it is closed
                if (DataHandler.myconn.State == System.Data.ConnectionState.Closed)
                {
                    DataHandler.myconn.Open();
                }

                // Insert book into the database
                //Book book = new Book(edtISBN.Text, edtBookName.Text, edtAuthor.Text, cmbGenre.Text, 1);
                string sql = "INSERT INTO tblBooks (isbn, title, author, borrowed) VALUES (@isbn, @title, @author, @borrowed)";
                SQLiteCommand cmd = new SQLiteCommand(sql, DataHandler.myconn);
                cmd.Parameters.AddWithValue("@isbn", ISBN);
                cmd.Parameters.AddWithValue("@title", Title);
                cmd.Parameters.AddWithValue("@author", Author);
                cmd.Parameters.AddWithValue("@borrowed", Borrowed);
                cmd.ExecuteNonQuery();
                
                //Just some testing to se if it works
                sql = "SELECT * FROM tblBooks WHERE author = @AuthorName";
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AuthorName", "Gideon");

                SQLiteDataReader reader = cmd.ExecuteReader();

                string result = "";
                while (reader.Read())
                {
                    result += $"Book ID: {reader["bookID"]}, ISBN: {reader["isbn"]}, Title: {reader["title"]}, Author: {reader["author"]}, Borrowed: {reader["borrowed"]}\n";
                }

                // Display results
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("No books found for the specified author.");
                }
                else
                {
                    MessageBox.Show(result);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Display the error
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Closing the conn string for coding standards
                if (DataHandler.myconn != null && DataHandler.myconn.State == System.Data.ConnectionState.Open)
                {
                    DataHandler.myconn.Close();
                }
            }
        }
    }
}
