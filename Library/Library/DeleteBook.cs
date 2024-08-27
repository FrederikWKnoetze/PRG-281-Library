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
            // First, retrieve the user information (Name, Surname) based on the provided ID
            string title = string.Empty;
            string author = string.Empty;
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
                DialogResult dlgResult = MessageBox.Show($"Do you want to delete Book: {ID}, {title}, {author}?", "Confirmation", MessageBoxButtons.YesNo);
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
                    // Query to select all records from tblReaders
                    string selectSql = "SELECT * FROM tblBooks";
                    using (SQLiteCommand selectCmd = new SQLiteCommand(selectSql, DataHandler.myconn))
                    {
                        using (SQLiteDataReader reader = selectCmd.ExecuteReader())
                        {
                            string result = "";
                            while (reader.Read())
                            {
                                // Replace index numbers with appropriate indexes of your columns
                                string readerInfo = "Reader Book ID: " + reader.GetValue(0).ToString() + "\n" +
                                                    "bookID: " + reader.GetValue(1).ToString() + "\n" +
                                                    "Reader ID: " + reader.GetValue(2).ToString() + "\n\n";

                                result += readerInfo;
                            }
                            MessageBox.Show(result);
                        }
                    }
                }
            }   
        }
    }
}
