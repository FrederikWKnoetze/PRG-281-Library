namespace Library
{
    partial class Add_Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Reader));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddReader = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.edtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLastname = new System.Windows.Forms.Label();
            this.edtLastname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblAddReader);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 96);
            this.panel1.TabIndex = 6;
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
            // lblAddReader
            // 
            this.lblAddReader.AutoSize = true;
            this.lblAddReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddReader.ForeColor = System.Drawing.Color.White;
            this.lblAddReader.Location = new System.Drawing.Point(305, 27);
            this.lblAddReader.Name = "lblAddReader";
            this.lblAddReader.Size = new System.Drawing.Size(200, 39);
            this.lblAddReader.TabIndex = 5;
            this.lblAddReader.Text = "Add Reader";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(335, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 37);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // edtFirstname
            // 
            this.edtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFirstname.Location = new System.Drawing.Point(312, 150);
            this.edtFirstname.Multiline = true;
            this.edtFirstname.Name = "edtFirstname";
            this.edtFirstname.Size = new System.Drawing.Size(170, 32);
            this.edtFirstname.TabIndex = 8;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFirstname.Location = new System.Drawing.Point(350, 123);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(93, 24);
            this.lblFirstname.TabIndex = 9;
            this.lblFirstname.Text = "Firstname";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.Location = new System.Drawing.Point(335, 318);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 37);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLastname.Location = new System.Drawing.Point(350, 226);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(91, 24);
            this.lblLastname.TabIndex = 11;
            this.lblLastname.Text = "Lastname";
            // 
            // edtLastname
            // 
            this.edtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtLastname.Location = new System.Drawing.Point(312, 253);
            this.edtLastname.Multiline = true;
            this.edtLastname.Name = "edtLastname";
            this.edtLastname.Size = new System.Drawing.Size(170, 32);
            this.edtLastname.TabIndex = 12;
            // 
            // Add_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edtLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.edtFirstname);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Reader";
            this.Text = "Add_Reader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Reader_FormClosed);
            this.Load += new System.EventHandler(this.Add_Reader_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddReader;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox edtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox edtLastname;
    }
}