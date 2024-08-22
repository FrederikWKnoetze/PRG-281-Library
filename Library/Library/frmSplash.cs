using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Library
{
    public partial class frmSplash : Form
    {
        private static System.Windows.Forms.Timer timer;
        public frmSplash()
        {
            InitializeComponent();
            //start form in middle of screen
            StartPosition = FormStartPosition.CenterScreen;


            //show form for 1.5 secs then show sign in form
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1500;
            timer.Tick += ontimeout;
            timer.Start();
        }
        private void frmSplash_Load(object sender, EventArgs e)
        {


            
        }
        private void ontimeout(Object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();
            frmSignIn f = new frmSignIn();
            f.Show();
            
            
        }
    }
}
