using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LMS.UL
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

      

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(1);
            if (progressBar2.Value == 100)
            {
                timer1.Stop();
            }
        }

        
    }
}
