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
    public partial class Submitbooks : Form
    {
        string conne = "Data Source=DESKTOP-F5CP93P;Initial Catalog=LMS;Integrated Security=True";
        public Submitbooks()
        {
            InitializeComponent();
        }

        private void Submitbooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.lMSDataSet.member);
            // TODO: This line of code loads data into the 'lMSDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.lMSDataSet1.Books);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<bbook> addlist = bbook.getbrowbook(conne, Convert.ToInt32(cmdclient.Text),Convert.ToInt32(cmbbook.Text));
                foreach (bbook item in addlist)
                {
                    txtdeadline.Text = item.Rdate.ToShortDateString();
                                      

                }
                int bn = DateTime.Today.DayOfYear;
                DateTime dl = Convert.ToDateTime(txtdeadline.Text);
                int dl1 = dl.DayOfYear;
                int ladate = dl1 - bn;

              
                txttoday.Text = DateTime.Today.ToShortDateString();
                if (ladate < 0)
                {
                    int neladate = ladate * (-1);
                    int fin = neladate * 5;
                    txtldate.Text = neladate.ToString();
                    txtfine.Text = fin.ToString();

                }
                else
                {
                    txtldate.Text ="0";
                    txtfine.Text = "0.00";
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not find this Member" + ex);
            }
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            try
            {
                bbook.updatesubmitbooks(conne, Convert.ToInt32(cmdclient.Text), Convert.ToInt32(cmbbook.Text), Convert.ToInt32(txtfine.Text), 0, Convert.ToInt32(txtldate.Text));
                try
                {
                    int onhand = addbook.getbookonhand(conne, Convert.ToInt32(cmbbook.Text));
                    int newonhand = onhand + 1;
                    addbook.updateonhand(conne, Convert.ToInt32(cmbbook.Text), newonhand);
                }
                catch (Exception)
                {
                    
                    throw;
                }
                MessageBox.Show("Submit is successfuly");

            }
            catch (Exception)
            {
                MessageBox.Show("Submit is not successfuly save");
            }
        }

        private void cmdclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfulname.Text = cmdclient.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtldate.Clear();
            txtdeadline.Clear();
            
            txtfulname.Clear();
            txtfine.Clear();
           
        }
        }
    }

