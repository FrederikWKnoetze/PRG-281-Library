using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmReturnBook : Form
    {

        private Thread splashThread;
        private frmSplashValid splashForm;
        private ManualResetEvent splashCloseEvent;

        public frmReturnBook()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            splashCloseEvent = new ManualResetEvent(false);
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
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

        //make sure thing closes
        private void frmReturnBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void frmReturnBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            splashThread = new Thread(new ThreadStart(frmSplashValid));
            splashThread.Start();

            Thread.Sleep(1500);

            splashCloseEvent.Set();

            splashThread.Join();

            string ibookid;

            ibookid = edtBookID.Text;

            var myconn = DataHandler.myconn;
            try
            {
                if (myconn != null)
                {
                    ReturnBook(ibookid);
                }
                else
                {
                    DataHandler.myconn = new SQLiteConnection(DataHandler.connectionstring);
                    ReturnBook(ibookid);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Connection not working");
                throw;
            }


            void ReturnBook(string bookid)
            {
                string sql = "";
                string sql1 = "";
                bool found=false;

                //var myconn = DataHandler.myconn;
                SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);
                SQLiteCommand mycmd1 = new SQLiteCommand(sql1, myconn);

                sql = "Select * from tblBooks";
                mycmd = new SQLiteCommand(sql, myconn);

                using (var reader = mycmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["bookID"].ToString() == bookid)
                        {
                            if (int.Parse(reader["borrowed"].ToString()) == 0)
                            {
                                MessageBox.Show("Book is already returned");
                                found = true;
                            }
                            else
                            {
                                sql1 = "UPDATE tblBooks set borrow=0 WHERE bookID=" + bookid + "";
                                mycmd1 = new SQLiteCommand(sql1, myconn);
                                mycmd1.ExecuteNonQuery();
                                sql = "DELETE * FROM tblReaderBooks WHERE bookiD=" + bookid + "";
                                mycmd1 = new SQLiteCommand(sql1, myconn);
                                mycmd1.ExecuteNonQuery();
                                MessageBox.Show("Succsess");
                                found = true;
                            }

                        }
                        // MessageBox.Show(reader["firstname"].ToString());
                    }
                }
                if (found==false)
                {
                    MessageBox.Show("Book not found");
                }

            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
        }
    }
}
