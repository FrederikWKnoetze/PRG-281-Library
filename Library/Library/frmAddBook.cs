using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmAdd_Book : Form
    {
        public frmAdd_Book()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }


        private void edtBookName_Enter(object sender, EventArgs e)
        {
            //skib
            if(edtBookName.Text == "Book Name")
            {
                edtBookName.Text = "";
                edtBookName.ForeColor = Color.Black;
            }
        }

        private void edtBookName_Leave(object sender, EventArgs e)
        {
            if (edtBookName.Text == "")
            {
                edtBookName.Text = "Book Name";
                edtBookName.ForeColor = Color.Silver;
            }
            else
            {
                edtBookName.ForeColor = Color.Black;
            }
        }

        private void edtAuthor_Enter(object sender, EventArgs e)
        {
            if (edtAuthor.Text == "Author")
            {
                edtAuthor.Text = "";
                edtAuthor.ForeColor = Color.Black;
            }
        }

        private void edtAuthor_Leave(object sender, EventArgs e)
        {

            if (edtAuthor.Text == "")
            {
                edtAuthor.Text = "Author";
                edtAuthor.ForeColor = Color.Silver;
            }
            else
            {
                edtAuthor.ForeColor = Color.Black;
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

        private void edtISBN_Enter(object sender, EventArgs e)
        {

            if (edtISBN.Text == "ISBN")
            {
                edtISBN.Text = "";
                edtISBN.ForeColor = Color.Black;
            }
        }

        private void cmbGenre_DropDown(object sender, EventArgs e)
        {
            this.cmbGenre.ForeColor = Color.Black;
            this.cmbGenre.Text = "";
        }
        private void lblMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_Book_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        { 
            Validate();
        }
        private void Validate()
        {
            bool nameCorrect = false;
            bool authorCorrect = false;
            bool isbnCorrect = false;
            bool genreCorrect = false;
            bool correctGenre = false;
            bool genreBlank = true;
            int countTrue = 0;
            string TempISBN = "";
            string nums = "0123456789";
            TempISBN = edtISBN.Text;
            int countCorrectNums = 0;
            
            if (edtBookName.Text != "Book Name")
            {
                nameCorrect = true;
                countTrue += 1;
            }
            if(edtAuthor.Text != "Author")
            {
                authorCorrect = true;
                countTrue += 1;
            }
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
                    isbnCorrect = true;
                    countTrue += 1;
                }
            }
            if (cmbGenre.Text != "")
            {
                genreBlank = false;
                countTrue += 1;
            }
            if(cmbGenre.Text != "Genre")
            {
                genreCorrect = true;
                countTrue += 1;
            }
            if (cmbGenre.Items.Contains(cmbGenre.Text)) 
            {
                countTrue += 1;
                correctGenre = true;
            }


            if (nameCorrect == false)
            {
                pnlBookName.BackColor = Color.Red;
            }
            if (authorCorrect == false)
            {
                pnlAuthor.BackColor = Color.Red;
            }
            if (isbnCorrect == false)
            {
                pnlISBN.BackColor = Color.Red;
            }
            if (genreBlank == true)
            {
                pnlGenre.BackColor = Color.Red;
            }
            if (genreCorrect == false) 
            {
                pnlGenre.BackColor = Color.Red;
            }
            if(correctGenre == false)
            {
                pnlGenre.BackColor= Color.Red;
            }

            if (countTrue == 6)
            {
                MessageBox.Show("Book Added");
                pnlBookName.BackColor = Color.White;
                pnlAuthor.BackColor = Color.White;
                pnlISBN.BackColor = Color.White;
                pnlGenre.BackColor = Color.White;
                Book book = new Book(edtISBN.Text, edtBookName.Text, edtAuthor.Text, cmbGenre.Text, 0);
                book.UpdateBookDB();

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmbGenre_Enter(object sender, EventArgs e)
        {
            if (cmbGenre.Text == "Genre")
            {
                cmbGenre.Text = "";
                cmbGenre.ForeColor = Color.Black;
            }
        }

        private void cmbGenre_Leave(object sender, EventArgs e)
        {
            if (cmbGenre.Text == "")
            {
                cmbGenre.Text = "Genre";
                cmbGenre.ForeColor = Color.Silver;
            }
            else
            {
                cmbGenre.ForeColor= Color.Black;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
        }

        public void InsertBook()
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
                Book book = new Book(edtISBN.Text, edtBookName.Text, edtAuthor.Text, cmbGenre.Text, 1);
                string sql = "INSERT INTO tblBooks (isbn, title, author, borrowed) VALUES (@isbn, @title, @author, @borrowed)";
                SQLiteCommand cmd = new SQLiteCommand(sql, DataHandler.myconn);
                cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@borrowed", book.Borrowed);
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

        //both of these to make sure that program exits when form is closed
        private void frmAdd_Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Add_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
