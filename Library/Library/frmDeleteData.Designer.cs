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
            this.bntdeleteUser = new System.Windows.Forms.Button();
            this.edtDeleteData = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.pnlID = new System.Windows.Forms.Panel();
            this.btnGoMenu = new System.Windows.Forms.Button();
            this.pnlID.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntdeleteUser
            // 
            this.bntdeleteUser.Location = new System.Drawing.Point(401, 302);
            this.bntdeleteUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntdeleteUser.Name = "bntdeleteUser";
            this.bntdeleteUser.Size = new System.Drawing.Size(100, 28);
            this.bntdeleteUser.TabIndex = 0;
            this.bntdeleteUser.Text = "Delete User";
            this.bntdeleteUser.UseVisualStyleBackColor = true;
            this.bntdeleteUser.Click += new System.EventHandler(this.bntdeleteUser_Click);
            // 
            // edtDeleteData
            // 
            this.edtDeleteData.ForeColor = System.Drawing.Color.Silver;
            this.edtDeleteData.Location = new System.Drawing.Point(1, 1);
            this.edtDeleteData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtDeleteData.Name = "edtDeleteData";
            this.edtDeleteData.Size = new System.Drawing.Size(207, 22);
            this.edtDeleteData.TabIndex = 1;
            this.edtDeleteData.Text = "Insert BookID or Reader ID";
            this.edtDeleteData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtDeleteData.Enter += new System.EventHandler(this.edtDeleteData_Enter);
            this.edtDeleteData.Leave += new System.EventHandler(this.edtDeleteData_Leave);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(509, 302);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // pnlID
            // 
            this.pnlID.Controls.Add(this.edtDeleteData);
            this.pnlID.Location = new System.Drawing.Point(401, 246);
            this.pnlID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(211, 27);
            this.pnlID.TabIndex = 3;
            // 
            // btnGoMenu
            // 
            this.btnGoMenu.Location = new System.Drawing.Point(444, 389);
            this.btnGoMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoMenu.Name = "btnGoMenu";
            this.btnGoMenu.Size = new System.Drawing.Size(100, 28);
            this.btnGoMenu.TabIndex = 4;
            this.btnGoMenu.Text = "Go Back";
            this.btnGoMenu.UseVisualStyleBackColor = true;
            this.btnGoMenu.Click += new System.EventHandler(this.btnGoMenu_Click);
            // 
            // frmDeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGoMenu);
            this.Controls.Add(this.pnlID);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.bntdeleteUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDeleteData";
            this.Text = "frmDeleteData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeleteData_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeleteData_FormClosed);
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntdeleteUser;
        private System.Windows.Forms.TextBox edtDeleteData;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Button btnGoMenu;
    }
}