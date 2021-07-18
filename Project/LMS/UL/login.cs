using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace LMS.UL
{
    public partial class login : Form
    {
        public login()
        {
            Thread tr = new Thread(new ThreadStart(splashscreen));
            tr.Start();
            Thread.Sleep(12000);
            InitializeComponent();
            tr.Abort();
        }
        public void splashscreen()
        {
            Application.Run(new splash());
        
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            txtpw.PasswordChar = '\0';
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtpw.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
