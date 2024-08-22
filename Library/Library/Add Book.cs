using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.cmbGenre.Items.Clear();
            this.cmbGenre.Items.AddRange(new object[] {
            "Fantasy",
            "Science Fiction",
            "Mystery",
            "Romance",
            "Thriller",
            "Historical Fiction",
            "Horror",
            "Biography/Autobiography",
            "Self-Help",
            "History",
            "Memoir",
            "True Crime",
            "Children’s Literature",
            "Graphic Novels/Comics",
            "Poetry"});
        }

        private void cmbGenre_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbGenre.ForeColor = Color.Black;
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
            if (edtBookName.Text != "Book Name" && edtAuthor.Text != "Author" && edtISBN.Text != "ISBN" && cmbGenre.Text != "Genre")
            {
                lblAdded.Text = "Book Added!";
            }
            else
            {
                lblAdded.Text = "Please fill in all the fields";
            }
        }
    }
}
