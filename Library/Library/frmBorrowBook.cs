using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{

    public partial class Borrow_Book : Form
    {
        public static List<string> books = new List<string>();
        public Borrow_Book()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
        }

        private void Borrow_Book_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void edtISBN_Enter(object sender, EventArgs e)
        {
            if (edtISBN.Text == "ISBN")
            {
                edtISBN.Text = "";
                edtISBN.ForeColor = Color.Black;
            }
        }

        private void edtISBN_Leave(object sender, EventArgs e)
        {
            if (edtISBN.Text == "")
            {
                edtISBN.Text = "ISBN";
                edtISBN.ForeColor = Color.Silver;
            }
            else
            {
                edtISBN.ForeColor = Color.Black;
            }
        }

        private void edtReaderId_Enter(object sender, EventArgs e)
        {
            if (edtReaderId.Text == "Reader ID")
            {
                edtReaderId.Text = "";
                edtReaderId.ForeColor = Color.Black;
            }
        }

        private void edtReaderId_Leave(object sender, EventArgs e)
        {
            if (edtReaderId.Text == "")
            {
                edtReaderId.Text = "Reader ID";
                edtReaderId.ForeColor = Color.Silver;
            }
            else
            {
                edtReaderId.ForeColor = Color.Black;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            validUser();
        }
        public void ValidateISBN()
        {
            string TempISBN = edtISBN.Text;
            string nums = "0123456789";
            int countCorrectNums = 0;
            bool isbnCorrect = false;
            if (TempISBN.Length == 13)//loop to check if if all 13 characters is a number
            {
                for (int i = 0; i < TempISBN.Length; i++)
                {
                    if (nums.Contains(TempISBN[i]))
                    {
                        countCorrectNums += 1;
                    }
                }
                if (countCorrectNums == 13) // Check if all characters are digits
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


                        //Just some testing to se if it works
                        string sql = "SELECT * FROM tblBooks WHERE isbn = @ISBN";
                        SQLiteCommand cmd = new SQLiteCommand(sql, DataHandler.myconn);
                        cmd.CommandText = sql;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ISBN", edtISBN.Text);
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        string result = "";
                        bool isBorrowed = false;
                        while (reader.Read())
                        {
                            result += $"Book ID: {reader["bookID"]}, ISBN: {reader["isbn"]}, Title: {reader["title"]}, Author: {reader["author"]}, Borrowed: {reader["borrowed"]}\n";
                            if (reader["borrowed"].ToString() == "1")
                            {
                                isBorrowed = true;
                            }
                        }

                        // Display results
                        if (string.IsNullOrEmpty(result))
                        {
                            MessageBox.Show("This book does not exist");
                            pnlISBN.BackColor = Color.Red;
                        }
                        else if (isBorrowed == true)
                        {
                            MessageBox.Show("This book is already borrowed.");
                            pnlISBN.BackColor = Color.Red;
                        }
                        else
                        {
                            MessageBox.Show(result);
                            isbnCorrect = true;
                            pnlISBN.BackColor = Color.White;
                            richBookList.Visible = true;
                            richBookList.AppendText(edtISBN.Text + Environment.NewLine);
                            edtISBN.Text = "";
                            books.Add(edtISBN.Text);
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
            if (isbnCorrect == false)
            {
                pnlISBN.BackColor = Color.Red;
            }
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            ValidateISBN();
        }

        private void richBookList_VisibleChanged(object sender, EventArgs e)
        {
            richBookList.AppendText(Environment.NewLine);
        }
        public void markAsBorrowed()
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
                    foreach (var book in books)
                    {
                        string updateSql = "UPDATE tblBooks SET borrowed = 0 WHERE isbn = @ISBN";
                        SQLiteCommand updateCmd = new SQLiteCommand(updateSql, DataHandler.myconn);
                        updateCmd.Parameters.Clear();
                        updateCmd.Parameters.AddWithValue("@ISBN", book);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("The book has been successfully updated to borrowed.");
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
        public void validUser()
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

                // SQL query to check if the user exists
                string sql = "SELECT COUNT(*) FROM tblReaders WHERE readerID = @readerID";
                SQLiteCommand cmd = new SQLiteCommand(sql, DataHandler.myconn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@readerID", edtReaderId.Text);


                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                // If userCount is greater than 0, it means the user exists
                if (userCount > 0)
                {
                    MessageBox.Show("Valid user found.");
                    markAsBorrowed();
                }
                else
                {
                    MessageBox.Show("User is not found please make an Account");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Closing the connection for coding standards
                if (DataHandler.myconn != null && DataHandler.myconn.State == System.Data.ConnectionState.Open)
                {
                    DataHandler.myconn.Close();
                }
            }
        }


        //make sure program exists when form is closed
        private void Borrow_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Borrow_Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
