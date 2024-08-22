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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_Book));
            this.btnAddBook = new System.Windows.Forms.Button();
            this.edtBookName = new System.Windows.Forms.TextBox();
            this.edtAuthor = new System.Windows.Forms.TextBox();
            this.edtISBN = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAdded = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddBook.Location = new System.Drawing.Point(326, 318);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(121, 37);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // edtBookName
            // 
            this.edtBookName.ForeColor = System.Drawing.Color.Silver;
            this.edtBookName.Location = new System.Drawing.Point(326, 137);
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
            this.edtAuthor.Location = new System.Drawing.Point(326, 181);
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
            this.edtISBN.Location = new System.Drawing.Point(326, 272);
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
            this.cmbGenre.Location = new System.Drawing.Point(326, 226);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbGenre.TabIndex = 4;
            this.cmbGenre.DropDown += new System.EventHandler(this.cmbGenre_DropDown);
            this.cmbGenre.SelectedValueChanged += new System.EventHandler(this.cmbGenre_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMainMenu);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 92);
            this.panel1.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 47);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 29);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 29);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(649, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.White;
            this.lblMainMenu.Location = new System.Drawing.Point(310, 27);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(166, 39);
            this.lblMainMenu.TabIndex = 5;
            this.lblMainMenu.Text = "Add Book";
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(326, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAdded.Location = new System.Drawing.Point(343, 371);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(0, 16);
            this.lblAdded.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAdd_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdded);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.edtISBN);
            this.Controls.Add(this.edtAuthor);
            this.Controls.Add(this.edtBookName);
            this.Controls.Add(this.btnAddBook);
            this.Name = "frmAdd_Book";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAdd_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox edtBookName;
        private System.Windows.Forms.TextBox edtAuthor;
        private System.Windows.Forms.TextBox edtISBN;
        private System.Windows.Forms.ComboBox cmbGenre;
        private Panel panel1;
        private Label lblTime;
        private Label lblDate;
        private PictureBox pictureBox1;
        private Label lblMainMenu;
        private Button btnBack;
        private Label lblAdded;
        private Timer timer1;
    }
}