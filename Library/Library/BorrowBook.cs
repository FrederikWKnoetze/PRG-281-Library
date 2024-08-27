using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal class BorrowBook : IUpdateBookDB
    {
        public int bookID;
        public int borrow;
        public int readerID;
        public static List<BorrowBook> books = new List<BorrowBook>(); // List initialized once and shared by all instances

        public BorrowBook(int _bookID, int _borrow, int _readerID)
        {
            this.bookID = _bookID;
            this.borrow = _borrow;
            this.readerID = _readerID;
            // Add the current book object to the books list
            books.Add(this);
        }

        public void UpdateBookDB()
        {
            if (books.Count >= 1)
            {
                try
                {
                    if (DataHandler.myconn == null)
                    {
                        DataHandler.myconn = new SQLiteConnection("Data Source=LibraryData.sqlite;Version=3;");
                    }

                    if (DataHandler.myconn.State == System.Data.ConnectionState.Closed)
                    {
                        DataHandler.myconn.Open();
                    }
                    for (int i = 0; i < books.Count-1; i++)
                    {
                        BorrowBook book = books[i]; // Access the current book by index
                        string updateSql = "UPDATE tblBooks SET borrowed = 1 WHERE bookID = @bookID";
                        SQLiteCommand updateCmd = new SQLiteCommand(updateSql, DataHandler.myconn);
                        updateCmd.Parameters.Clear();
                        updateCmd.Parameters.AddWithValue("@bookID", book.bookID);
                        updateCmd.ExecuteNonQuery();

                        // Insert the book and reader information into tblReaderBooks
                        string insertSql = "INSERT INTO tblReaderBooks (bookID, readerID) VALUES (@bookID, @readerID)";
                        updateCmd = new SQLiteCommand(insertSql, DataHandler.myconn);
                        updateCmd.Parameters.AddWithValue("@bookID", book.bookID);
                        updateCmd.Parameters.AddWithValue("@readerID", book.readerID);
                        updateCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("The Book/books has been set to Borrowed");
                    books.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (DataHandler.myconn != null && DataHandler.myconn.State == System.Data.ConnectionState.Open)
                    {
                        DataHandler.myconn.Close();
                    }
                }
            }
        }
    }
}
