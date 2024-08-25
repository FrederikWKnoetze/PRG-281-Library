namespace Library
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.btnSignIn = new System.Windows.Forms.Button();
            this.edtID = new System.Windows.Forms.TextBox();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignIn.Location = new System.Drawing.Point(411, 321);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(118, 40);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtID
            // 
            this.edtID.ForeColor = System.Drawing.Color.Silver;
            this.edtID.Location = new System.Drawing.Point(375, 170);
            this.edtID.Name = "edtID";
            this.edtID.Size = new System.Drawing.Size(190, 20);
            this.edtID.TabIndex = 1;
            this.edtID.Text = "ID";
            this.edtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtID.Enter += new System.EventHandler(this.textBox1_Enter);
            this.edtID.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // edtPassword
            // 
            this.edtPassword.ForeColor = System.Drawing.Color.Silver;
            this.edtPassword.Location = new System.Drawing.Point(375, 255);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Size = new System.Drawing.Size(190, 20);
            this.edtPassword.TabIndex = 2;
            this.edtPassword.Text = "Password";
            this.edtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtPassword.Enter += new System.EventHandler(this.textBox2_Enter);
            this.edtPassword.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(263, 250);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(263, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 437);
            this.panel1.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(24, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(216, 116);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designed by:\r\nPieter\r\nGideon\r\nFrederik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 156);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the\r\nLibrary\r\nManagement\r\nSystem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(306, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login to your Account";
            // 
            // btnSeePassword
            // 
            this.btnSeePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeePassword.BackgroundImage")));
            this.btnSeePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeePassword.Location = new System.Drawing.Point(571, 250);
            this.btnSeePassword.Name = "btnSeePassword";
            this.btnSeePassword.Size = new System.Drawing.Size(29, 32);
            this.btnSeePassword.TabIndex = 7;
            this.btnSeePassword.UseVisualStyleBackColor = true;
            this.btnSeePassword.Click += new System.EventHandler(this.btnSeePassword_Click);
            // 
            // frmSignIn
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 431);
            this.Controls.Add(this.btnSeePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.btnSignIn);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "frmSignIn";
            this.Text = "Sign in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSignIn_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSignIn_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSeePassword;
    }
}

