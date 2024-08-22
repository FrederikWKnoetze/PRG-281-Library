using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    partial class frmAdd_Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddBook = new System.Windows.Forms.Button();
            this.edtBookName = new System.Windows.Forms.TextBox();
            this.edtAuthor = new System.Windows.Forms.TextBox();
            this.edtISBN = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(316, 305);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(121, 23);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // edtBookName
            // 
            this.edtBookName.ForeColor = System.Drawing.Color.Silver;
            this.edtBookName.Location = new System.Drawing.Point(316, 163);
            this.edtBookName.Name = "edtBookName";
            this.edtBookName.Size = new System.Drawing.Size(121, 20);
            this.edtBookName.TabIndex = 1;
            this.edtBookName.Text = "Book Name";
            this.edtBookName.Enter += new System.EventHandler(this.edtBookName_Enter);
            this.edtBookName.Leave += new System.EventHandler(this.edtBookName_Leave);
            // 
            // edtAuthor
            // 
            this.edtAuthor.ForeColor = System.Drawing.Color.Silver;
            this.edtAuthor.Location = new System.Drawing.Point(316, 198);
            this.edtAuthor.Name = "edtAuthor";
            this.edtAuthor.Size = new System.Drawing.Size(121, 20);
            this.edtAuthor.TabIndex = 2;
            this.edtAuthor.Text = "Author";
            this.edtAuthor.Enter += new System.EventHandler(this.edtAuthor_Enter);
            this.edtAuthor.Leave += new System.EventHandler(this.edtAuthor_Leave);
            // 
            // edtISBN
            // 
            this.edtISBN.ForeColor = System.Drawing.Color.Silver;
            this.edtISBN.Location = new System.Drawing.Point(316, 270);
            this.edtISBN.Name = "edtISBN";
            this.edtISBN.Size = new System.Drawing.Size(121, 20);
            this.edtISBN.TabIndex = 3;
            this.edtISBN.Text = "ISBN";
            this.edtISBN.Enter += new System.EventHandler(this.edtISBN_Enter);
            this.edtISBN.Leave += new System.EventHandler(this.edtISBN_Leave);
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.ForeColor = System.Drawing.Color.Silver;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Genre",
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
            this.cmbGenre.SelectedIndex = 0;
            this.cmbGenre.ForeColor = Color.Silver;
            this.cmbGenre.Location = new System.Drawing.Point(316, 233);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbGenre.TabIndex = 4;
            this.cmbGenre.DropDown += new System.EventHandler(this.cmbGenre_DropDown);
            this.cmbGenre.SelectedValueChanged += new System.EventHandler(this.cmbGenre_SelectedValueChanged);
            // 
            // frmAdd_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.edtISBN);
            this.Controls.Add(this.edtAuthor);
            this.Controls.Add(this.edtBookName);
            this.Controls.Add(this.btnAddBook);
            this.Name = "frmAdd_Book";
            this.Text = "Add_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox edtBookName;
        private System.Windows.Forms.TextBox edtAuthor;
        private System.Windows.Forms.TextBox edtISBN;
        private System.Windows.Forms.ComboBox cmbGenre;
    }
}