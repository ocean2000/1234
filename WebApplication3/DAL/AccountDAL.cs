using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DAL
{
    public class AccountDAL
    {
        public System.Data.DataTable GetAccount()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM ";
            data = DBConnect.Instance.ExecuteQuery(query);
            return data;
        }
        public bool login(string username, string password)
        {
            string query = "USP_LOGIN @USERNAME , @PASSWORD";
            DataTable result = DBConnect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        //public Account GetAccountByUsername(string username)
        //{
        //    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT WHERE USERNAME = '" + username + "'");
        //    foreach (DataRow item in data.Rows)
        //    {
        //        return new Account(item);
        //    }

        //    return null;
        //}

        //public int UpdateAccount(string username, string pass, string newpass, string dispalyname)
        //{
        //    int data = DataProvider.Instance.ExecuteNonQuery("USP_UPDATEACCOUNT @USERNAME , @DISPLAYNAME , @PASSWORD , @NEWPASSWORD", new object[] { username, dispalyname, pass, newpass });

        //    if (data > 0)
        //        return 1;
        //    else
        //        return 0;
        //}

        public DataTable getListAccount()
        {
            return DBConnect.Instance.ExecuteQuery("SELECT USERNAME, DISPLAYNAME, TYPE FROM ACCOUNT");

        }

        public int InsertAccount(string username, string displayname, string pass, int type)
        {
            string query = string.Format("INSERT ACCOUNT (USERNAME, DISPLAYNAME, PASSWORD, TYPE) VALUES ('{0}', N'{1}', '{2}', {3})", username, displayname, pass, type);

            int data = DBConnect.Instance.ExecuteNonQuery(query);

            return data; // lớn hơn 0 là thành công
        }

        public int UpdateAccount(string username, int type)
        {
            string query = "UPDATE ACCOUNT SET TYPE = " + type + " WHERE USERNAME = '" + username + "'";
            int data = DBConnect.Instance.ExecuteNonQuery(query);
            return data;
        }

        //public int DeleteAccount(string fromUsername, string toUsername)
        //{
        //    BillDAO.Instance.ChangeUsername(fromUsername, toUsername);

        //    string query = string.Format("DELETE FROM ACCOUNT WHERE USERNAME = '" + fromUsername + "'");

        //    int data = DataProvider.Instance.ExecuteNonQuery(query);

        //    return data; // lớn hơn 0 là thành công
        //}

        //public int IsExistAcc(string username)
        //{
        //    string query = "SELECT COUNT(*) FROM ACCOUNT WHERE USERNAME = '" + username + "'";
        //    return (int)DBConnect.Instance.ExecuteScalar(query);
        //}
    }
}
