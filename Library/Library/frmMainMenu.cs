using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdd_Book frmAdd_Book = new frmAdd_Book();
            frmAdd_Book.Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrow_Book frmBorrowBook = new Borrow_Book();
            frmBorrowBook.Show();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            this.Hide();
            See_Data frmSeeData = new See_Data();
            frmSeeData.Show();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Reader frmAddReader = new Add_Reader();
            frmAddReader.Show();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnBook frmReturnBook = new frmReturnBook();
            frmReturnBook.Show();
        }
    }
}
