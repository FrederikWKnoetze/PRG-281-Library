using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal class DeleteBook : DeleteData
    {
        public DeleteBook(int _Id) : base(_Id)
        {
        }
        public override void DeleteSelectedData()
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
                string title = string.Empty;
                string author = string.Empty;
                // First, retrieve the user information (Name, Surname) based on the provided ID
                string selectBookSql = "SELECT title, author FROM tblBooks WHERE bookID = @bookID";
                using (SQLiteCommand selectBook = new SQLiteCommand(selectBookSql, DataHandler.myconn))
                {
                    selectBook.Parameters.AddWithValue("@bookID", ID);

                    using (SQLiteDataReader reader = selectBook.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            title = reader["title"].ToString();
                            author = reader["author"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Book not found.");
                            return; // Exit the method if user is not found
                        }
                    }
                    // Display confirmation dialog with user ID, Name, and Surname
                    DialogResult dlgResult = MessageBox.Show($"Do you want to delete Book: {title} by {author}?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dlgResult == DialogResult.Yes)
                    {
                        // Define SQL query to delete from tblReaderBooks based on readerID
                        string deleteReaderBooksSql = "DELETE FROM tblReaderBooks WHERE bookId = @bookId";
                        using (SQLiteCommand deleteReaderBooksCmd = new SQLiteCommand(deleteReaderBooksSql, DataHandler.myconn))
                        {
                            deleteReaderBooksCmd.Parameters.AddWithValue("@bookId", ID);
                            deleteReaderBooksCmd.ExecuteNonQuery();
                        }

                        // Define SQL query to delete from tblReaders based on readerID
                        string deleteReadersSql = "DELETE FROM tblBooks WHERE bookId = @bookId";
                        using (SQLiteCommand deleteReadersCmd = new SQLiteCommand(deleteReadersSql, DataHandler.myconn))
                        {
                            deleteReadersCmd.Parameters.AddWithValue("@bookId", ID);
                            deleteReadersCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Book has succesfully been deleted");
                    }
                }
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
