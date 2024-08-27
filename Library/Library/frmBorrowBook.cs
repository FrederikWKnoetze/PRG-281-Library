using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{

    public partial class Borrow_Book : Form
    {

        private Thread splashThread;
        private frmSplashValid splashForm;
        private ManualResetEvent splashCloseEvent;
        public delegate void CheckOutHandler();
        public event CheckOutHandler OnCheckOut;

        public Borrow_Book()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            splashCloseEvent = new ManualResetEvent(false);
            OnCheckOut += ValidUserEventHandler;
        }
        private void ValidUserEventHandler()
        {
            validUser();
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

        private void frmSplashValid()
        {
            splashForm = new frmSplashValid();
            splashForm.Show();
            while (!splashCloseEvent.WaitOne(100))
            {
                Application.DoEvents();
            }

            splashForm.Invoke(new Action(() => splashForm.Close()));
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            splashCloseEvent.Reset();

            splashThread = new Thread(new ThreadStart(frmSplashValid));
            splashThread.Start();

            Thread.Sleep(500);

            splashCloseEvent.Set();  // Signal to close the splash screen

            splashThread.Join();

            Validate();

            OnCheckOut?.Invoke();
            richBookList.Visible = false;
            richBookList.Text = "Book List:";
        }

        public void ValidateBookID()
        {
            string TempReader = edtReaderId.Text;
            string TempID = edtBookID.Text;
            string nums = "0123456789";
            int countCorrectNums = 0;
            int countCorrectNumsReader = 0;
            bool isbnCorrect = false;
                for (int i = 0; i < TempID.Length; i++)
                {
                    if (nums.Contains(TempID[i]))
                    {
                        countCorrectNums += 1;
                    }
                }
                if (countCorrectNums == TempID.Length) // Check if all characters are digits
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

                    string sql = "SELECT * FROM tblBooks WHERE bookID = @bookID";
                    SQLiteCommand cmd = new SQLiteCommand(sql, DataHandler.myconn);
                    cmd.CommandText = sql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@bookID", int.Parse(edtBookID.Text));
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
                        pnlBookID.BackColor = Color.Red;
                    }
                    else if (isBorrowed == true)
                    {
                        MessageBox.Show("This book is already borrowed.");
                        pnlBookID.BackColor = Color.Red;
                    }
                    else
                    {
                        if (edtReaderId.Text == "Reader ID" || edtReaderId.Text == "")
                        {
                            pnlReaderID.BackColor = Color.Red;
                            MessageBox.Show("Please enter a user ID");

                        }
                        else
                        {
                            for (int i = 0; i < TempReader.Length; i++)
                            {
                                if (nums.Contains(TempReader[i]))
                                {
                                    countCorrectNumsReader += 1;
                                }
                            }
                            bool isDuplicate = false;
                            foreach (BorrowBook book in BorrowBook.books)
                            {
                                // Check if the current book has the same BookID as the one being added
                                if (book.bookID == int.Parse(edtBookID.Text))
                                {
                                    isDuplicate = true;
                                    break; // Exit the loop as we found a duplicate
                                }
                            }

                            if (isDuplicate)
                            {
                                // Notify the user that a duplicate was found
                                MessageBox.Show("This book has selected.", "Duplicate BookID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                edtBookID.Text = ""; // Clear the input if needed
                            }
                            else
                            {
                                // Proceed only if there is no duplicate
                                if (countCorrectNumsReader == TempReader.Length)
                                {
                                    int tempReaderID = int.Parse(edtReaderId.Text);
                                    isbnCorrect = true;
                                    pnlBookID.BackColor = Color.White;
                                    pnlReaderID.BackColor = Color.White;
                                    richBookList.Visible = true;
                                    richBookList.AppendText(edtBookID.Text + Environment.NewLine);

                                    // Add new book borrowing record
                                    BorrowBook test = new BorrowBook(int.Parse(edtBookID.Text), 1, tempReaderID);
                                    BorrowBook.books.Add(test); // Add to the list

                                    edtBookID.Text = ""; // Clear the text field
                                }
                            }
                        }
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
            if (isbnCorrect == false)
            {
                pnlBookID.BackColor = Color.Red;
            }
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            ValidateBookID();
        }

        private void richBookList_VisibleChanged(object sender, EventArgs e)
        {
            richBookList.AppendText(Environment.NewLine);
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
                    BorrowBook test = new BorrowBook(1,1,1);//inteface thing cannot be static so best option is that make a "temp" object to method can be called
                    test.UpdateBookDB();
                    richBookList.Text = "Book List:" + Environment.NewLine;
                    edtReaderId.Text = "";
                    edtReaderId.Focus();
                    edtReaderId.Focus();
                    edtBookID.Focus();
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

        private void edtBookID_Enter(object sender, EventArgs e)
        {
            if (edtBookID.Text == "Book ID")
            {
                edtBookID.Text = "";
                edtBookID.ForeColor = Color.Black;
            }
        }

        private void edtBookID_Leave(object sender, EventArgs e)
        {
            if (edtBookID.Text == "")
            {
                edtBookID.Text = "Book ID";
                edtBookID.ForeColor = Color.Silver;
            }
            else
            {
                edtBookID.ForeColor = Color.Black;
            }
        }
    }
}
