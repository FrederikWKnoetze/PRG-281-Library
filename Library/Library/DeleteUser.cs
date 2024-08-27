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
                // First, retrieve the user information (Name, Surname) based on the provided ID
                string name = string.Empty;
                string surname = string.Empty;

                string selectUserSql = "SELECT firstname, lastname FROM tblReaders WHERE readerID = @readerID";
                using (SQLiteCommand selectUserCmd = new SQLiteCommand(selectUserSql, DataHandler.myconn))
                {
                    selectUserCmd.Parameters.AddWithValue("@readerID", ID);

                    using (SQLiteDataReader reader = selectUserCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader["firstname"].ToString();
                            surname = reader["lastname"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                            return; // Exit the method if user is not found
                        }
                    }
                }

                // Display confirmation dialog with user ID, Name, and Surname
                DialogResult dlgResult = MessageBox.Show($"Do you want to delete user: {ID}, {name} {surname}?", "Confirmation", MessageBoxButtons.YesNo);

                if (dlgResult == DialogResult.Yes)
                {
                    // Delete from tblReaderBooks based on readerID
                    string deleteReaderBooksSql = "DELETE FROM tblReaderBooks WHERE readerID = @readerID";
                    using (SQLiteCommand deleteReaderBooksCmd = new SQLiteCommand(deleteReaderBooksSql, DataHandler.myconn))
                    {
                        deleteReaderBooksCmd.Parameters.AddWithValue("@readerID", ID);
                        deleteReaderBooksCmd.ExecuteNonQuery();
                    }

                    // Delete from tblReaders based on readerID
                    string deleteReadersSql = "DELETE FROM tblReaders WHERE readerID = @readerID";
                    using (SQLiteCommand deleteReadersCmd = new SQLiteCommand(deleteReadersSql, DataHandler.myconn))
                    {
                        deleteReadersCmd.Parameters.AddWithValue("@readerID", ID);
                        deleteReadersCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User deleted successfully.");
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
