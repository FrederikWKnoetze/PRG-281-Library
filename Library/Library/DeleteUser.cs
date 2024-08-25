using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal class DeleteUser : DeleteData
    {
        public DeleteUser(int _Id) : base(_Id)
        {
        }
        public override void DeleteSelectedData()
        {
            // Define SQL query to delete from tblReaderBooks based on readerID
            string deleteReaderBooksSql = "DELETE FROM tblReaderBooks WHERE readerID = @readerID";
            using (SQLiteCommand deleteReaderBooksCmd = new SQLiteCommand(deleteReaderBooksSql, DataHandler.myconn))
            {
                deleteReaderBooksCmd.Parameters.AddWithValue("@readerID", ID);
                deleteReaderBooksCmd.ExecuteNonQuery();
            }

            // Define SQL query to delete from tblReaders based on readerID
            string deleteReadersSql = "DELETE FROM tblReaders WHERE readerID = @readerID";
            using (SQLiteCommand deleteReadersCmd = new SQLiteCommand(deleteReadersSql, DataHandler.myconn))
            {
                deleteReadersCmd.Parameters.AddWithValue("@readerID", ID);
                deleteReadersCmd.ExecuteNonQuery();
            }

            // Query to select all records from tblReaders
            string selectSql = "SELECT * FROM tblReaderBooks";
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
