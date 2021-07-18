using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Collections;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace LMS.UL
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        public void buttonclicksound()
        {
            SoundPlayer s = new SoundPlayer("");
            s.Play();
        }
        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bntaddbokks_Click(object sender, EventArgs e)
        {
            Adbook ab = new Adbook();
            ab.Show();
        }

        private void bntaddmember_Click(object sender, EventArgs e)
        {
            AddMember ab = new AddMember();
            ab.Show();
        }

        private void bntborow_Click(object sender, EventArgs e)
        {

            borrowbook ab = new borrowbook();
            ab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Submitbooks ab = new Submitbooks();
            ab.Show();
        }

 
       

  

     
    }
}
