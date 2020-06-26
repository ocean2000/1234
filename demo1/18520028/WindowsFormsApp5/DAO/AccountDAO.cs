using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp5.dataClass;

namespace WindowsFormsApp5.data
{//1691
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccountDAO() { }
        
        public bool login(string username, string password)
        {
            string query = "USP_LOGIN @USERNAME , @PASSWORD";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT WHERE USERNAME = '" + username + "'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public int UpdateAccount(string username, string pass, string newpass, string dispalyname)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("USP_UPDATEACCOUNT @USERNAME , @DISPLAYNAME , @PASSWORD , @NEWPASSWORD", new object[] { username, dispalyname, pass, newpass });

            if (data > 0)
                return 1;
            else
                return 0;
        }

        public DataTable getListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT USERNAME, DISPLAYNAME, TYPE FROM ACCOUNT");

        }

        public int InsertAccount(string username, string displayname, string pass, int type)
        {
            string query = string.Format("INSERT ACCOUNT (USERNAME, DISPLAYNAME, PASSWORD, TYPE) VALUES ('{0}', N'{1}', '{2}', {3})", username, displayname, pass, type);

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            return data; // lớn hơn 0 là thành công
        }
        
        public int UpdateAccount(string username, int type)
        {
            string query = "UPDATE ACCOUNT SET TYPE = " + type + " WHERE USERNAME = '" + username + "'";
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data;
        }

        public int DeleteAccount(string fromUsername, string toUsername)
        {
            BillDAO.Instance.ChangeUsername(fromUsername, toUsername);
                
            string query = string.Format("DELETE FROM ACCOUNT WHERE USERNAME = '" + fromUsername + "'");

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            return data; // lớn hơn 0 là thành công
        }

        public int IsExistAcc(string username)
        {
            string query = "SELECT COUNT(*) FROM ACCOUNT WHERE USERNAME = '" + username + "'";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

    }
}
