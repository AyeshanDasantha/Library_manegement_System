using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using OOP.DL;
using LMS.BL;


namespace LMS.UL
{
    public partial class borrowbook : Form
    {
        string conne = "Data Source=DESKTOP-F5CP93P;Initial Catalog=LMS;Integrated Security=True";
        public borrowbook()
        {
            InitializeComponent();
            DateTime getd = DateTime.Today;
            txttody.Text = getd.ToShortDateString();
            DateTime rdte = getd.AddDays(7);
            txtdeadline.Text = rdte.ToShortDateString();

        }

        private void borrowbook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.lMSDataSet1.Books);
            // TODO: This line of code loads data into the 'lMSDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.lMSDataSet.member);

        }

        private void bntSave_Click(object sender, EventArgs e)
        {
         DateTime getd = DateTime.Today;
         txttody.Text=getd.ToShortDateString();
         DateTime rdte=getd.AddDays(7);
        txtdeadline.Text=rdte.ToShortDateString();
       


        bbook bb = new bbook(Convert.ToInt32(cmdclient.Text),Convert.ToInt32(cmdbook.Text),getd,rdte,0,0.00,1);
            try
            {
                int onhand = addbook.getbookonhand(conne, Convert.ToInt32(cmdbook.Text));
                int new_onhand = onhand - 1;
                try
                {
                    addbook.updateonhand(conne, Convert.ToInt32(cmdbook.Text),new_onhand);
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
                
                bb.addborrwbooks(conne);
                
                MessageBox.Show("Save Successfully");



            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR..! not Save"+ex);

            }
            txtdeadline.Clear();
            txtfulname.Clear();
            txttody.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<bbook> addlist = bbook.getbrowbook(conne, Convert.ToInt32(cmdclient.Text), Convert.ToInt32(cmdbook.Text));
                foreach (bbook item in addlist)
                {
                    txtdeadline.Text = item.Rdate.ToShortDateString();
                    txttody.Text = item.getdate.ToShortDateString();
                    cmdclient.SelectedItem = item.mid;
                    cmdbook.SelectedItem = item.bid;
                    txtfulname.Text = cmdclient.SelectedValue.ToString();

                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not find this Member" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime getd = DateTime.Today;
            txttody.Text = getd.ToShortDateString();
            DateTime rdte = getd.AddDays(7);
            txtdeadline.Text = rdte.ToShortDateString();



            bbook bb = new bbook(Convert.ToInt32(cmdclient.Text), Convert.ToInt32(cmdbook.Text), getd, rdte, 0, 0.00, 1);
        
            try
            {
                bb.updateborrwbooks(conne, Convert.ToInt32(cmdbook.SelectedItem), Convert.ToInt32(cmdclient.SelectedItem));
                MessageBox.Show("Update Successfully");

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR..! Update"+ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdeadline.Clear();
            txtfulname.Clear();
            txttody.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bbook.Deleteborrowbook(conne, Convert.ToInt32(cmdbook.Text), Convert.ToInt32(cmdclient.Text));
                MessageBox.Show("delete Sucessfully");
                txtdeadline.Clear();
                txtfulname.Clear();
                txttody.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR...! Not Delete" + ex);
            }
        }

        private void cmdclient_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtfulname.Text = cmdclient.SelectedValue.ToString();
            
           

            
                    }

        private void cmdclient_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void cmdbook_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void cmdbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbookname.Text = cmdbook.SelectedValue.ToString();
            txtonhand.Text = addbook.getbookonhand(conne, Convert.ToInt32(cmdbook.Text)).ToString();
        }
    }
}
