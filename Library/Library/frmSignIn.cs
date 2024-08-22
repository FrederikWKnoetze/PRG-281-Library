using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Net.NetworkInformation;
using System.Data.SqlClient;

namespace Library
{
    public partial class frmSignIn : Form
    {
         DataHandler handler = new DataHandler();
        public frmSignIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            handler.CreateDatabase();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            // Connection string (update with your database details)
            string connectionString = "Data Source=admin.sqlite;Version=3;";

            // SQL query with parameters
            string query = "SELECT COUNT(*) FROM tblReadersTest WHERE ID = @EnteredID AND ReaderName = @EnteredPassword";

            // Use SQLiteConnection instead of SqlConnection
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Add parameters with the entered values
                command.Parameters.AddWithValue("@EnteredID", edtID.Text);
                command.Parameters.AddWithValue("@EnteredPassword", edtPassword.Text);

                try
                {
                    connection.Open();
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    // If count is greater than 0, the ID and name are correct
                    // Implement your logic here, for example:
                    if (userCount > 0)
                    {
                        // Authentication successful
                        MessageBox.Show("ID and Password are correct.");
                    }
                    else
                    {
                        // Authentication failed
                        MessageBox.Show("Invalid Password or Name.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that might have occurred
                    MessageBox.Show("Error: " + ex.Message);
                }
            }




        }
        
        //textbox edtID
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (edtID.Text == "ID")
            {
                edtID.Text = "";
                edtID.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (edtID.Text == "")
            {
                edtID.Text = "ID";
                edtID.ForeColor = Color.Silver;
            }
            else
            {
                edtID.ForeColor = Color.Black;
            }
        }

        //textbox password
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (edtPassword.Text == "Password")
            {
                edtPassword.Text = "";
                edtPassword.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (edtPassword.Text == "")
            {
                edtPassword.Text = "Password";
                edtPassword.ForeColor = Color.Silver;
            }
            else
            {
                edtPassword.ForeColor = Color.Black;
            }
        }

        private void frmSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
} 
