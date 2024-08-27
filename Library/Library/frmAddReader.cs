using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Library
{
    public partial class Add_Reader : Form
    {
        private Thread splashThread;
        private frmSplashValid splashForm;
        private ManualResetEvent splashCloseEvent;
        public Add_Reader()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add_Reader_Load(object sender, EventArgs e)
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




        //both of these to make sure program closes when form is closed
        private void Add_Reader_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Add_Reader_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstname = "";
            string lastname = "";
            bool flag1 = false;
            bool flag2 = false;
            firstname = edtFirstname.Text;
            lastname = edtLastname.Text;

            splashCloseEvent.Reset();

            splashThread = new Thread(new ThreadStart(frmSplashValid));
            splashThread.Start();
            Thread.Sleep(500);
            splashCloseEvent.Set();  // Signal to close the splash screen
            splashThread.Join();

            if ((firstname != "Firstname") && (firstname != null) && (firstname != ""))
            {
                flag1 = true;
            } else
            {
                //maak fancy pls pieter
                MessageBox.Show("Invalid Firstname");
            }
            if ((lastname != "Lastname") && (lastname != null) && (lastname !=""))
            {
                flag2 = true;
            }
            else
            {
                //maak fancy pls pieter
                MessageBox.Show("Invalid Lastname");
            }
            //MessageBox.Show(firstname);
            //MessageBox.Show(lastname);
            var myconn = DataHandler.myconn;
            if (flag1==true&&flag2==true)
            {
                try
                {
                    if (myconn != null)
                    {
                        //MessageBox.Show("connection working");
                        addReader(firstname, lastname);
                    }
                    else
                    {
                        DataHandler.myconn = new SQLiteConnection(DataHandler.connectionstring);
                        //MessageBox.Show("connection working");
                        addReader(firstname, lastname);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection not working");
                    throw;
                }
            }
            

            
        }
        public void addReader(string _firstname, string _lastname)
        {
            string sql = "";

            var myconn = DataHandler.myconn;
            SQLiteCommand mycmd = new SQLiteCommand(sql, myconn);

            //sql = "Select * from tblBooks";
            // mycmd = new SQLiteCommand(sql, myconn);

            try
            {
                //INSERT INTO tblReaders(firstname, lastname) VALUES ('Sannie', 'Koen');
                sql = "INSERT INTO tblReaders (firstname,lastname) VALUES ('"+_firstname+"','"+_lastname+"')";
                mycmd = new SQLiteCommand(sql, myconn);
                mycmd.ExecuteNonQuery();
                MessageBox.Show("Succsess added: " + _firstname + " " + _lastname);
            }
            catch (Exception)
            {
                throw;
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
    }
}
