using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmDeleteData : Form
    {
        public frmDeleteData()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void edtDeleteData_Enter(object sender, EventArgs e)
        {
            if (edtDeleteData.Text == "Insert BookID or Reader ID")
            {
                edtDeleteData.Text = "";
                edtDeleteData.ForeColor = Color.Black;
            }
        }

        private void edtDeleteData_Leave(object sender, EventArgs e)
        {
            if (edtDeleteData.Text == "")
            {
                edtDeleteData.Text = "Insert BookID or Reader ID";
                edtDeleteData.ForeColor= Color.Silver;
            }
            else
            {
                edtDeleteData.ForeColor = Color.Black;
            }
        }

        private void bntdeleteUser_Click(object sender, EventArgs e)
        {
            string testNums = "0123456789";
            string tempId = edtDeleteData.Text;
            bool onlyNums = true;
            for (int i = 0; i < tempId.Length; i++)
            {
                if (testNums.Contains(tempId[i]) == false)
                {
                    MessageBox.Show("Only Numbers please");
                    onlyNums = false;
                }
                if (onlyNums == false)
                {
                    pnlID.BackColor = Color.Red;
                    break;
                }
            }
            if (onlyNums == true)
            {
                DeleteUser user = new DeleteUser(int.Parse(tempId));
                user.DeleteSelectedData();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string testNums = "0123456789";
            string tempId = edtDeleteData.Text;
            bool onlyNums = true;
            for (int i = 0; i < tempId.Length; i++)
            {
                if (testNums.Contains(tempId[i]) == false)
                {
                    MessageBox.Show("Only Numbers please");
                    onlyNums = false;
                }
                if (onlyNums == false)
                {
                    pnlID.BackColor = Color.Red;
                    break;
                }
            }
            if (onlyNums == true)
            {
                DeleteBook book = new DeleteBook(int.Parse(tempId));
                book.DeleteSelectedData();
            }
        }

        //make sure application closes on close
        private void frmDeleteData_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void frmDeleteData_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void btnGoMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
        }


        private void frmDeleteData_Load(object sender, EventArgs e)
        {

        }
    }
}
