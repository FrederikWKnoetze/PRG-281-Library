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
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.pnlBookName = new System.Windows.Forms.Panel();
            this.pnlGenre = new System.Windows.Forms.Panel();
            this.pnlISBN = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAuthor.SuspendLayout();
            this.pnlBookName.SuspendLayout();
            this.pnlGenre.SuspendLayout();
            this.pnlISBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddBook.Location = new System.Drawing.Point(343, 318);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(121, 37);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // edtBookName
            // 
            this.edtBookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edtBookName.ForeColor = System.Drawing.Color.Silver;
            this.edtBookName.Location = new System.Drawing.Point(1, 1);
            this.edtBookName.Margin = new System.Windows.Forms.Padding(1);
            this.edtBookName.Name = "edtBookName";
            this.edtBookName.Size = new System.Drawing.Size(121, 20);
            this.edtBookName.TabIndex = 1;
            this.edtBookName.Text = "Book Name";
            this.edtBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtBookName.Enter += new System.EventHandler(this.edtBookName_Enter);
            this.edtBookName.Leave += new System.EventHandler(this.edtBookName_Leave);
            // 
            // edtAuthor
            // 
            this.edtAuthor.ForeColor = System.Drawing.Color.Silver;
            this.edtAuthor.Location = new System.Drawing.Point(1, 1);
            this.edtAuthor.Name = "edtAuthor";
            this.edtAuthor.Size = new System.Drawing.Size(121, 20);
            this.edtAuthor.TabIndex = 2;
            this.edtAuthor.Text = "Author";
            this.edtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtAuthor.Enter += new System.EventHandler(this.edtAuthor_Enter);
            this.edtAuthor.Leave += new System.EventHandler(this.edtAuthor_Leave);
            // 
            // edtISBN
            // 
            this.edtISBN.ForeColor = System.Drawing.Color.Silver;
            this.edtISBN.Location = new System.Drawing.Point(1, 1);
            this.edtISBN.Name = "edtISBN";
            this.edtISBN.Size = new System.Drawing.Size(121, 20);
            this.edtISBN.TabIndex = 3;
            this.edtISBN.Text = "ISBN";
            this.edtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtISBN.Enter += new System.EventHandler(this.edtISBN_Enter);
            this.edtISBN.Leave += new System.EventHandler(this.edtISBN_Leave);
            // 
            // cmbGenre
            // 
            this.cmbGenre.ForeColor = System.Drawing.Color.Silver;
            this.cmbGenre.FormattingEnabled = true;
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
            this.cmbGenre.Location = new System.Drawing.Point(1, 1);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbGenre.TabIndex = 4;
            this.cmbGenre.Text = "Genre";
            this.cmbGenre.DropDown += new System.EventHandler(this.cmbGenre_DropDown);
            this.cmbGenre.Enter += new System.EventHandler(this.cmbGenre_Enter);
            this.cmbGenre.Leave += new System.EventHandler(this.cmbGenre_Leave);
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
            this.lblMainMenu.Location = new System.Drawing.Point(324, 28);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(166, 39);
            this.lblMainMenu.TabIndex = 5;
            this.lblMainMenu.Text = "Add Book";
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(343, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAdded.Location = new System.Drawing.Point(360, 371);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(0, 16);
            this.lblAdded.TabIndex = 7;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAuthor.Controls.Add(this.edtAuthor);
            this.pnlAuthor.Location = new System.Drawing.Point(344, 234);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(123, 22);
            this.pnlAuthor.TabIndex = 8;
            // 
            // pnlBookName
            // 
            this.pnlBookName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBookName.Controls.Add(this.edtBookName);
            this.pnlBookName.Location = new System.Drawing.Point(344, 206);
            this.pnlBookName.Name = "pnlBookName";
            this.pnlBookName.Size = new System.Drawing.Size(123, 22);
            this.pnlBookName.TabIndex = 9;
            // 
            // pnlGenre
            // 
            this.pnlGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGenre.Controls.Add(this.cmbGenre);
            this.pnlGenre.Location = new System.Drawing.Point(343, 262);
            this.pnlGenre.Name = "pnlGenre";
            this.pnlGenre.Size = new System.Drawing.Size(123, 23);
            this.pnlGenre.TabIndex = 9;
            // 
            // pnlISBN
            // 
            this.pnlISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlISBN.Controls.Add(this.edtISBN);
            this.pnlISBN.Location = new System.Drawing.Point(343, 290);
            this.pnlISBN.Name = "pnlISBN";
            this.pnlISBN.Size = new System.Drawing.Size(123, 22);
            this.pnlISBN.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAdd_Book
            // 
            this.AcceptButton = this.btnAddBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBookName);
            this.Controls.Add(this.pnlGenre);
            this.Controls.Add(this.pnlISBN);
            this.Controls.Add(this.pnlAuthor);
            this.Controls.Add(this.lblAdded);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddBook);
            this.Name = "frmAdd_Book";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdd_Book_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdd_Book_FormClosed_1);
            this.Load += new System.EventHandler(this.frmAdd_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAuthor.ResumeLayout(false);
            this.pnlAuthor.PerformLayout();
            this.pnlBookName.ResumeLayout(false);
            this.pnlBookName.PerformLayout();
            this.pnlGenre.ResumeLayout(false);
            this.pnlISBN.ResumeLayout(false);
            this.pnlISBN.PerformLayout();
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
        private Panel pnlAuthor;
        private Panel pnlBookName;
        private Panel pnlGenre;
        private Panel pnlISBN;
        private Timer timer1;
    }
}