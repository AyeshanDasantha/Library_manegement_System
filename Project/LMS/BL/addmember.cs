using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OOP.DL;

namespace LMS.BL
{
    class addmember
    {
        public int mid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ltype { get; set; }
        public string email { get; set; }
        public string contact { get; set; }

        public addmember(int mid1, string Name1, string Address1, string ltype1, string email1, string contact1)
        {
            mid = mid1;
            Name = Name1;
            Address = Address1;
            ltype = ltype1;
            email = email1;
            contact = contact1;

                  
        
        }

        public bool addmembers(string connString)
        {
            try
            {
                string query = @"INSERT INTO member
                         (mid, Name, addresses, Ltype, email, contact)
                        VALUES ('"+mid+"','"+Name+"','"+Address+"','"+ltype+"','"+email+"','"+contact+"')   ";
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
        public bool updatemembers(string connString, int s)
        {
            try
            {
                string query = @"UPDATE       member
                                SET  mid ='"+mid+"', Name ='"+Name+"', addresses ='"+Address+"', Ltype ='"+ltype+"', email ='"+email+"', contact ='"+contact+"' where mid='"+s+"'";

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
        public static List<addmember> getmember(string connString, int s)
        {
            try
            {
                string Query = @"SELECt mid, Name, addresses, Ltype, email, contact
                                FROM   member where mid='" + s + "'";
                DataSet ds = DBhelper.GetDataSot(Query, connString);
                List<addmember> Clienttlist = new List<addmember>();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    addmember reg = new addmember(Convert.ToInt32(r.ItemArray[0]), r.ItemArray[1].ToString(), r.ItemArray[2].ToString(), r.ItemArray[3].ToString(), r.ItemArray[4].ToString(), r.ItemArray[5].ToString());

                    Clienttlist.Add(reg);

                }
                return Clienttlist;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static bool Deletemember(string connString, int s)
        {
            try
            {
                string query = @"DELETE FROM member where mid ='" + s + "'";
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
                string query = "select MAX(mid)from member";
                int sid = (int)(DBhelper.GetScaler(query, connString));
                return sid;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        }


    }


