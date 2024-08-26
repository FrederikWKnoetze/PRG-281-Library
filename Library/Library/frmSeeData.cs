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
    public partial class See_Data : Form
    {
        public See_Data()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void See_Data_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
        }

        private void See_Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void See_Data_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //sql = "select * from test";
        //mycmd = new SQLiteCommand(sql, myconn);
        //SQLiteDataAdapter adapter = new SQLiteDataAdapter(mycmd);
        //DataTable data = new DataTable();
        //adapter.Fill(data);
        private void btnBooks_Click(object sender, EventArgs e)
        {
            string sql = "";
            var myconn = DataHandler.myconn;
            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);
            sql = "SELECT * FROM tblBooks";
            mycmd= new SQLiteCommand(sql, myconn);
            SQLiteDataAdapter adapter= new SQLiteDataAdapter(mycmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvOutput.DataSource = data;
            
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            string sql = "";
            var myconn = DataHandler.myconn;
            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);
            sql = "SELECT * FROM tblReaders";
            mycmd = new SQLiteCommand(sql, myconn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(mycmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvOutput.DataSource = data;
        }

        private void btnBorrowed_Click(object sender, EventArgs e)
        {
            string sql = "";
            var myconn = DataHandler.myconn;
            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);
            sql = "SELECT firstname, lastname, title FROM tblBooks INNER JOIN tblReaderBooks ON tblBooks.bookID=tblReaderBooks.bookID INNER JOIN tblReaders ON tblReaderBooks.readerID=tblReaders.readerID group by firstname";// INNER JOIN tblReaders ON tblReaderBooks.readerID=tblReaders.readerID";
            mycmd = new SQLiteCommand(sql, myconn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(mycmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvOutput.DataSource = data;
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            string input = "";
            string sql = "";
            var myconn = DataHandler.myconn;
            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);
            input=edtReader.Text;
            sql = "SELECT * FROM tblReaders WHERE firstname like '%"+input+"%'";
            mycmd = new SQLiteCommand(sql, myconn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(mycmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvOutput.DataSource = data;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string sql = "";
            string input = "";
            var myconn = DataHandler.myconn;
            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);
            input=edtBook.Text;
            sql = "SELECT * FROM tblBooks WHERE title like '%" + input + "%'";
            mycmd = new SQLiteCommand(sql, myconn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(mycmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvOutput.DataSource = data;
        }

        private void edtReader_Enter(object sender, EventArgs e)
        {
            if (edtReader.Text=="Firstname")
            {
                edtReader.Text = "";
                edtReader.ForeColor = Color.Black;
            }

        }

        private void edtBook_Enter(object sender, EventArgs e)
        {
            if (edtBook.Text == "Title")
            {
                edtBook.Text = "";
                edtBook.ForeColor = Color.Black;
            }
        }

        private void edtReader_Leave(object sender, EventArgs e)
        {
            if (edtReader.Text == "")
            {
                edtReader.Text = "Firstname";
                edtReader.ForeColor = Color.Silver;
            }
            else
            {
                edtReader.ForeColor = Color.Black;
            }
        }

        private void edtBook_Leave(object sender, EventArgs e)
        {
            if (edtBook.Text == "")
            {
                edtBook.Text = "Firstname";
                edtBook.ForeColor = Color.Silver;
            }
            else
            {
                edtBook.ForeColor = Color.Black;
            }
        }
    }
}
