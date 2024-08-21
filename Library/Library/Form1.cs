using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int TempID = random.Next(10000,99999);
                Reader Test = new Reader(TempID.ToString(),"Test");
                
            }
            Reader Gideon = new Reader("12345", "Gideon");
            foreach (Reader reader in Reader.AllReaders)
            {
                string testID = textBox1.Text;
                string testName = textBox2.Text;

                if (testID == reader.ID && testName == reader.Name)
                {

                    MessageBox.Show($"ID: {reader.ID}, Name: {reader.Name}");
                }
            }
        }
    }
}
