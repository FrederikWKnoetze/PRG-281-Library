﻿using System.Drawing;

namespace Library
{
    partial class Borrow_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrow_Book));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBorrowBook = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.edtBookID = new System.Windows.Forms.TextBox();
            this.btnAddtoList = new System.Windows.Forms.Button();
            this.edtReaderId = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pnlBookID = new System.Windows.Forms.Panel();
            this.pnlReaderID = new System.Windows.Forms.Panel();
            this.richBookList = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBookID.SuspendLayout();
            this.pnlReaderID.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblBorrowBook);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 118);
            this.panel1.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(16, 58);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 36);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(16, 11);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 36);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(865, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblBorrowBook
            // 
            this.lblBorrowBook.AutoSize = true;
            this.lblBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowBook.ForeColor = System.Drawing.Color.White;
            this.lblBorrowBook.Location = new System.Drawing.Point(395, 33);
            this.lblBorrowBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowBook.Name = "lblBorrowBook";
            this.lblBorrowBook.Size = new System.Drawing.Size(272, 52);
            this.lblBorrowBook.TabIndex = 5;
            this.lblBorrowBook.Text = "Borrow Book";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(449, 494);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 46);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // edtBookID
            // 
            this.edtBookID.ForeColor = System.Drawing.Color.Silver;
            this.edtBookID.Location = new System.Drawing.Point(1, 1);
            this.edtBookID.Margin = new System.Windows.Forms.Padding(4);
            this.edtBookID.Name = "edtBookID";
            this.edtBookID.Size = new System.Drawing.Size(160, 22);
            this.edtBookID.TabIndex = 9;
            this.edtBookID.Text = "Book ID";
            this.edtBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtBookID.Enter += new System.EventHandler(this.edtBookID_Enter);
            this.edtBookID.Leave += new System.EventHandler(this.edtBookID_Leave);
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddtoList.Location = new System.Drawing.Point(452, 258);
            this.btnAddtoList.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(164, 39);
            this.btnAddtoList.TabIndex = 10;
            this.btnAddtoList.Text = "Add Book To List";
            this.btnAddtoList.UseVisualStyleBackColor = true;
            this.btnAddtoList.Click += new System.EventHandler(this.btnAddtoList_Click);
            // 
            // edtReaderId
            // 
            this.edtReaderId.ForeColor = System.Drawing.Color.Silver;
            this.edtReaderId.Location = new System.Drawing.Point(1, 1);
            this.edtReaderId.Margin = new System.Windows.Forms.Padding(4);
            this.edtReaderId.Name = "edtReaderId";
            this.edtReaderId.Size = new System.Drawing.Size(160, 22);
            this.edtReaderId.TabIndex = 11;
            this.edtReaderId.Text = "Reader ID";
            this.edtReaderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtReaderId.Enter += new System.EventHandler(this.edtReaderId_Enter);
            this.edtReaderId.Leave += new System.EventHandler(this.edtReaderId_Leave);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckOut.Location = new System.Drawing.Point(449, 356);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(167, 46);
            this.btnCheckOut.TabIndex = 12;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // pnlBookID
            // 
            this.pnlBookID.Controls.Add(this.edtBookID);
            this.pnlBookID.Location = new System.Drawing.Point(452, 223);
            this.pnlBookID.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBookID.Name = "pnlBookID";
            this.pnlBookID.Size = new System.Drawing.Size(164, 27);
            this.pnlBookID.TabIndex = 13;
            // 
            // pnlReaderID
            // 
            this.pnlReaderID.Controls.Add(this.edtReaderId);
            this.pnlReaderID.Location = new System.Drawing.Point(452, 314);
            this.pnlReaderID.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReaderID.Name = "pnlReaderID";
            this.pnlReaderID.Size = new System.Drawing.Size(164, 27);
            this.pnlReaderID.TabIndex = 14;
            // 
            // richBookList
            // 
            this.richBookList.Location = new System.Drawing.Point(685, 223);
            this.richBookList.Margin = new System.Windows.Forms.Padding(4);
            this.richBookList.Name = "richBookList";
            this.richBookList.Size = new System.Drawing.Size(165, 176);
            this.richBookList.TabIndex = 15;
            this.richBookList.Text = "Book List: ";
            this.richBookList.Visible = false;
            this.richBookList.VisibleChanged += new System.EventHandler(this.richBookList_VisibleChanged);
            // 
            // Borrow_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.richBookList);
            this.Controls.Add(this.btnAddtoList);
            this.Controls.Add(this.pnlReaderID);
            this.Controls.Add(this.pnlBookID);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Borrow_Book";
            this.Text = "Borrow_Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Borrow_Book_FormClosed);
            this.Load += new System.EventHandler(this.Borrow_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBookID.ResumeLayout(false);
            this.pnlBookID.PerformLayout();
            this.pnlReaderID.ResumeLayout(false);
            this.pnlReaderID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBorrowBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox edtBookID;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.TextBox edtReaderId;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel pnlBookID;
        private System.Windows.Forms.Panel pnlReaderID;
        private System.Windows.Forms.RichTextBox richBookList;
    }
}