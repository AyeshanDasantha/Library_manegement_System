using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OOP.DL;

namespace LMS.BL
{
    class bbook
    {
         public int mid { get; set; }
        public int bid { get; set; }
        public DateTime getdate { get; set; }
        public DateTime Rdate { get; set; }
        public int ldays { get; set; }
        public double fine { get; set; }
        public int type { get; set; }

        public bbook(int mid1, int bid1, DateTime getdate1, DateTime Rdate1, int ldays1, double fine1, int type1)
        {

            mid = mid1;
            bid = bid1;
            getdate = getdate1;
            Rdate = Rdate1;
            ldays = ldays1;
            fine = fine1;
            type = type1;
        
        }
        //borrwbooks to tables
        public bool addborrwbooks(string connString)
        {
            try
            {
                string query = @"INSERT INTO borrow
                         (mid, bookID, getdate, Rdate, LateDate, fin, type)
                        VALUES        ('" + mid + "','" + bid + "','" + getdate + "','" + Rdate + "','" + ldays + "','" + fine + "','" + type + "')";
                if (DBhelper.nonQuery(query, connString) > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        // update borrwbooks list
        public bool updateborrwbooks(string connString, int mid1, int bid1)
        {
            try
            {
                string query = @"UPDATE       borrow
                            SET     mid ='" + mid + "', bookID ='" + bid + "', getdate ='" + getdate + "', Rdate ='" + Rdate + "', LateDate ='" + ldays + "', fin ='" + fine + "', type ='" + type + "' where mid ='" + mid1 + "' and  bookID='"+bid1+"'";

                if (DBhelper.nonQuery(query, connString) > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<bbook> getbrowbook(string connString, int mid1, int bid1)
        {
            try
            {
                string Query = @"SELECT    mid, bookID, getdate, Rdate, LateDate, fin, type
                                FROM   borrow where mid='" + mid1 + "' and bookID='" + bid1 + "' ";
                DataSet ds = DBhelper.GetDataSot(Query, connString);
                List<bbook> borrowlist = new List<bbook>();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    bbook reg = new bbook(Convert.ToInt32(r.ItemArray[0]), Convert.ToInt32(r.ItemArray[1]), Convert.ToDateTime(r.ItemArray[2]), Convert.ToDateTime(r.ItemArray[3]), Convert.ToInt32(r.ItemArray[4]), Convert.ToDouble(r.ItemArray[5]), Convert.ToInt32(r.ItemArray[5]));

                    borrowlist.Add(reg);

                }
                return borrowlist;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static bool Deleteborrowbook(string connString, int s,int m)
        {
            try
            {
                string query = @"DELETE FROM borrow where bookID ='" + s + "' and mid='"+m+"'";
                if (DBhelper.nonQuery(query, connString) > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public static bool updatesubmitbooks(string connString, int mid1, int bid1,double fin,int type,int dldate)
        {
            try
            {
                string query = @"UPDATE       borrow
                                SET     fin ='" + fin + "', type ='" + type + "', LateDate ='" + dldate + "' where mid ='" + mid1 + "' and  bookID='" + bid1 + "'";

                if (DBhelper.nonQuery(query, connString) > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}
