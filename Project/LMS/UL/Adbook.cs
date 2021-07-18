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
    public partial class Adbook : Form
    {
        string conne = "Data Source=DESKTOP-AGH4CMU;Initial Catalog=LMS;Integrated Security=True";
        public Adbook()
        {

            InitializeComponent();
            int bid = BL.addbook.gettidMax(conne)+1;
            txtid.Text = bid.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Adbook_Load(object sender, EventArgs e)
        {

        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            BL.addbook addbook = new BL.addbook(Convert.ToInt32(txtid.Text), txtbname.Text, txtauthor.Text, cmdtype.SelectedItem.ToString(), Convert.ToInt32(txtonhan.Text), Convert.ToInt32(txtqty.Text));
            try
            {
                addbook.addbooks(conne);
                MessageBox.Show("Saved Successfuly");
                int bid = BL.addbook.gettidMax(conne) + 1;
                txtid.Text = bid.ToString();
                txtauthor.Clear();
                txtbname.Clear();
                txtonhan.Clear();
                txtqty.Clear();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Not Save Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<addbook> addlist = addbook.getbook(conne, Convert.ToInt32(txtid.Text));
                foreach (addbook item in addlist)
                {
                    txtbname.Text = item.bookName;
                    txtauthor.Text = item.Author;
                    txtqty.Text = item.qty.ToString();
                    txtonhan.Text = item.onhand.ToString();
                    cmdtype.SelectedItem= item.type;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not find this Book" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bid = BL.addbook.gettidMax(conne) + 1;
            txtid.Text = bid.ToString();
            txtauthor.Clear();
            txtbname.Clear();
            txtonhan.Clear();
            txtqty.Clear();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.addbook addbook = new BL.addbook(Convert.ToInt32(txtid.Text), txtbname.Text, txtauthor.Text, cmdtype.SelectedItem.ToString(), Convert.ToInt32(txtonhan.Text), Convert.ToInt32(txtqty.Text));
            try
            {
                addbook.updatebooks(conne, Convert.ToInt32(txtid.Text));
                MessageBox.Show("Updated Successfully");

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Updated not Completed" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                addbook.Deletebook(conne, Convert.ToInt32(txtid.Text));
                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Delete not Completed  "+ex);
            }
        }

       

       
    }
}
