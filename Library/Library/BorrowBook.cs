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
        public string bookISBN;
        public int borrow;
        public static List<BorrowBook> books = new List<BorrowBook>(); // List initialized once and shared by all instances

        public BorrowBook(string _bookISBN, int _borrow)
        {
            this.bookISBN = _bookISBN;
            this.borrow = _borrow;
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
                        string updateSql = "UPDATE tblBooks SET borrowed = 0 WHERE isbn = @ISBN";
                        SQLiteCommand updateCmd = new SQLiteCommand(updateSql, DataHandler.myconn);
                        updateCmd.Parameters.Clear();
                        updateCmd.Parameters.AddWithValue("@ISBN", book.bookISBN);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("The book has been successfully updated to borrowed.");
                    }
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
