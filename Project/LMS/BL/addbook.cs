using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OOP.DL;

namespace LMS.BL
{
    class addbook
    {
        public int bookid { get; set; }
        public string bookName { get; set; }
        public string Author { get; set; }
        public string type { get; set; }
        public int qty { get; set; }
        public int onhand { get; set; }

        public addbook(int bookid1, string bookName1, string Author1, string type1, int qty1, int onhand1)
        {
            bookid=bookid1;
            bookName=bookName1;
            Author=Author1;
            type=type1;
            qty=qty1;
            onhand = onhand1;
                   
        
        }
        //addbokks to tables
        public bool addbooks(string connString)
        {
            try
            {
                string query = @"INSERT INTO Books
                         (bookID, book_name, Author, types, qty, onhand)
                          VALUES        ('" + bookid + "','" + bookName + "','" + Author + "','" + type + "','" + qty + "','" + onhand + "')";
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
        // update book list
        public bool updatebooks(string connString, int s)
        {
            try
            {
                string query = @"UPDATE     Books
                                SET  bookID ='" + bookid + "', book_name ='" + bookName + "', Author ='" + Author + "', types ='" + type + "', qty ='" + qty + "', onhand ='" + onhand + "' where bookID='"+s+"' ";

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
        public static List<addbook> getbook(string connString, int s)
        {
            try
            {
                string Query = @"SELECT        bookID, book_name, Author, types, qty, onhand
                                FROM  Books where bookID ='" + s + "'";
                DataSet ds = DBhelper.GetDataSot(Query, connString);
                List<addbook> Clienttlist = new List<addbook>();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    addbook reg = new addbook(Convert.ToInt32(r.ItemArray[0]), r.ItemArray[1].ToString(), r.ItemArray[2].ToString(), r.ItemArray[3].ToString(), Convert.ToInt32(r.ItemArray[4]), Convert.ToInt32(r.ItemArray[5]));

                    Clienttlist.Add(reg);

                }
                return Clienttlist;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static bool Deletebook(string connString, int s)
        {
            try
            {
                string query = @"DELETE FROM Books where bookID ='" + s + "'";
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
        public static int gettidMax(string connString)
        {
            try
            {
                string query = "select MAX(bookID)from Books";
                int sid = (int)(DBhelper.GetScaler(query, connString));
                return sid;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int getbookonhand(string connString,int s)
        {
            try
            {
                string query = "select onhand from Books where bookID='"+s+"' ";
                int sid = (int)(DBhelper.GetScaler(query, connString));
                return sid;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool updateonhand(string connString, int bid,int onh)
        {
       
            try
            {
                string query = @"UPDATE       Books
                                SET        onhand ='" + onh + "' where bookID='" + bid + "' ";

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
