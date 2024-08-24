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
using Newtonsoft.Json;
using BCrypt.Net;
using System.Security.Cryptography;
using System.Data.Entity;

namespace Library
{
    public partial class frmSignIn : Form
    {

        //variables and data things
        DataHandler handler = new DataHandler();
        private readonly string usersFilePath = "users.json";

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
            
            string username = edtID.Text;
            string password = edtPassword.Text;

            // to generate sal hash and password hash to have it
            //byte[] salt;
            //new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            //var pbkdf2 = new Rfc2898DeriveBytes("admin", salt, 100000);
            //byte[] hash = pbkdf2.GetBytes(20);

            //byte[] hashBytes = new byte[36];
            //Array.Copy(salt, 0, hashBytes, 0, 16);
            //Array.Copy(hash, 0, hashBytes, 16, 20);
            //string savedPasswordHash = Convert.ToBase64String(hashBytes);
            //string savedhas = Convert.ToBase64String(salt);
            //MessageBox.Show(savedhas);
            //Clipboard.SetText(savedhas);
            //MessageBox.Show(savedPasswordHash);
            //Clipboard.SetText(savedPasswordHash);

            if (ValidateCredentials(username, password))
            {
                MessageBox.Show("Sign in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

















            // Connection string (update with your database details)
            //string connectionString = "Data Source=admin.sqlite;Version=3;";

            //// SQL query with parameters
            //string query = "SELECT COUNT(*) FROM tblReadersTest WHERE ID = @EnteredID AND ReaderName = @EnteredPassword";

            //// Use SQLiteConnection instead of SqlConnection
            //using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            //using (SQLiteCommand command = new SQLiteCommand(query, connection))
            //{
            //    // Add parameters with the entered values
            //    command.Parameters.AddWithValue("@EnteredID", edtID.Text);
            //    command.Parameters.AddWithValue("@EnteredPassword", edtPassword.Text);

            //    try
            //    {
            //        connection.Open();
            //        int userCount = Convert.ToInt32(command.ExecuteScalar());

            //        // If count is greater than 0, the ID and name are correct
            //        // Implement your logic here, for example:
            //        if (userCount > 0)
            //        {
            //            // Authentication successful
            //            this.Hide();
            //            frmMainMenu menu = new frmMainMenu();
            //            menu.Show();
            //        }
            //        else
            //        {
            //            // Authentication failed
            //            MessageBox.Show("Invalid Password or Name.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        // Handle any errors that might have occurred
            //        MessageBox.Show("Error: " + ex.Message);
            //    }
            //}
        }

        private bool ValidateCredentials(string username, string password)
        {
            try
            {
                var users = LoadUsers();
                var user = users.Find(u => u.Username == username);

                if (user != null)
                {
                    // Hash the entered password with the stored salt
                    string enteredHash = BCrypt.Net.BCrypt.HashPassword(password, user.Salt);

                    // Compare the entered hash with the stored hash
                    return user.PasswordHash == enteredHash;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private List<User> LoadUsers()
        {
            if (File.Exists(usersFilePath))
            {
                string json = File.ReadAllText(usersFilePath);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
            return new List<User>();
        }


        public class User
        {
            public string Username { get; set; }
            public string PasswordHash { get; set; }
            public string Salt { get; set; }
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
