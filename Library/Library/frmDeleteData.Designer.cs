namespace Library
{
    partial class frmDeleteData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteData));
            this.bntdeleteUser = new System.Windows.Forms.Button();
            this.edtDeleteData = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.pnlID = new System.Windows.Forms.Panel();
            this.btnGoMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDeleteData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlID.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntdeleteUser
            // 
            this.bntdeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bntdeleteUser.Location = new System.Drawing.Point(262, 244);
            this.bntdeleteUser.Name = "bntdeleteUser";
            this.bntdeleteUser.Size = new System.Drawing.Size(123, 37);
            this.bntdeleteUser.TabIndex = 0;
            this.bntdeleteUser.Text = "Delete User";
            this.bntdeleteUser.UseVisualStyleBackColor = true;
            this.bntdeleteUser.Click += new System.EventHandler(this.bntdeleteUser_Click);
            // 
            // edtDeleteData
            // 
            this.edtDeleteData.ForeColor = System.Drawing.Color.Silver;
            this.edtDeleteData.Location = new System.Drawing.Point(1, 1);
            this.edtDeleteData.Name = "edtDeleteData";
            this.edtDeleteData.Size = new System.Drawing.Size(156, 20);
            this.edtDeleteData.TabIndex = 1;
            this.edtDeleteData.Text = "Insert BookID or Reader ID";
            this.edtDeleteData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtDeleteData.Enter += new System.EventHandler(this.edtDeleteData_Enter);
            this.edtDeleteData.Leave += new System.EventHandler(this.edtDeleteData_Leave);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteBook.Location = new System.Drawing.Point(416, 244);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(124, 37);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // pnlID
            // 
            this.pnlID.Controls.Add(this.edtDeleteData);
            this.pnlID.Location = new System.Drawing.Point(320, 200);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(158, 22);
            this.pnlID.TabIndex = 3;
            // 
            // btnGoMenu
            // 
            this.btnGoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGoMenu.Location = new System.Drawing.Point(347, 383);
            this.btnGoMenu.Name = "btnGoMenu";
            this.btnGoMenu.Size = new System.Drawing.Size(106, 37);
            this.btnGoMenu.TabIndex = 4;
            this.btnGoMenu.Text = "Go Back";
            this.btnGoMenu.UseVisualStyleBackColor = true;
            this.btnGoMenu.Click += new System.EventHandler(this.btnGoMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDeleteData);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 96);
            this.panel1.TabIndex = 8;
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
            // lblDeleteData
            // 
            this.lblDeleteData.AutoSize = true;
            this.lblDeleteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteData.ForeColor = System.Drawing.Color.White;
            this.lblDeleteData.Location = new System.Drawing.Point(303, 26);
            this.lblDeleteData.Name = "lblDeleteData";
            this.lblDeleteData.Size = new System.Drawing.Size(199, 39);
            this.lblDeleteData.TabIndex = 5;
            this.lblDeleteData.Text = "Delete Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGoMenu);
            this.Controls.Add(this.pnlID);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.bntdeleteUser);
            this.Name = "frmDeleteData";
            this.Text = "frmDeleteData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeleteData_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeleteData_FormClosed);
            this.Load += new System.EventHandler(this.frmDeleteData_Load);
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntdeleteUser;
        private System.Windows.Forms.TextBox edtDeleteData;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Button btnGoMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeleteData;
        private System.Windows.Forms.Timer timer1;
    }
}