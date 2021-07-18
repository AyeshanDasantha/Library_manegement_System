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
    public partial class AddMember : Form
    {
        string conne = "Data Source=DESKTOP-F5CP93P;Initial Catalog=LMS;Integrated Security=True";
        public AddMember()
        {
            InitializeComponent();
            int max=addmember.gettidMax(conne)+1;
            txtcid.Text = max.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            addmember ad = new addmember(Convert.ToInt32(txtcid.Text), txtname.Text, txtaddress.Text, cmdtype.SelectedItem.ToString(), txtemail.Text, txtcontact.Text);
            try
            {
                ad.addmembers(conne);
                MessageBox.Show("Save Succesfuly");
                txtaddress.Clear();
                txtname.Clear();
                txtemail.Clear();
                txtcontact.Clear();
                int max = addmember.gettidMax(conne) + 1;
                txtcid.Text = max.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(" ERROR...! Not Save" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
            {
                List<addmember> addlist = addmember.getmember(conne, Convert.ToInt32(txtcid.Text));
                foreach (addmember item in addlist)
                {
                    txtcid.Text=item.mid.ToString();
                    txtaddress.Text=item.Address;
                    txtcontact.Text=item.contact;
                    txtemail.Text=item.email;
                    txtname.Text=item.Name;
                    cmdtype.SelectedItem=item.ltype;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not find this Member" + ex);
            }
        }



        

        private void button3_Click(object sender, EventArgs e)
        {
            addmember ad = new addmember(Convert.ToInt32(txtcid.Text), txtname.Text, txtaddress.Text, cmdtype.SelectedItem.ToString(), txtaddress.Text, txtcontact.Text);

            try
            {
                ad.updatemembers(conne, Convert.ToInt32(txtcid.Text));
                MessageBox.Show("Successfuly Updated");




            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR..! Not Updated"+ex);
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtaddress.Clear();
            txtname.Clear();
            txtemail.Clear();
            txtcontact.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               addmember.Deletemember(conne,Convert.ToInt32(txtcid.Text));
                MessageBox.Show("Delete Successfyly");
             txtaddress.Clear();
            txtname.Clear();
            txtemail.Clear();
            txtcontact.Clear();
             int max = addmember.gettidMax(conne) + 1;
             txtcid.Text = max.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR...! Not Delete"); 
            }
        }

 
    }
}
