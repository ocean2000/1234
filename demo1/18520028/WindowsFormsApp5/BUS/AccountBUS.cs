using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.data;

namespace WindowsFormsApp5.BUS
{
    class AccountBUS
    {
        public int InsertAccount(string username, string displayname, string pass, int type)
        {
            string query = string.Format("INSERT ACCOUNT (USERNAME, DISPLAYNAME, PASSWORD, TYPE) VALUES ('{0}', N'{1}', '{2}', {3})", username, displayname, pass, type);

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            return data; 
        }
        public int UpdateAccount(string username, string pass, string newpass, string dispalyname)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("USP_UPDATEACCOUNT @USERNAME , @DISPLAYNAME , @PASSWORD , @NEWPASSWORD", new object[] { username, dispalyname, pass, newpass });

            if (data > 0)
                return 1;
            else
                return 0;
        }
        public int DeleteAccount(string fromUsername, string toUsername)
        {
            BillDAO.Instance.ChangeUsername(fromUsername, toUsername);

            string query = string.Format("DELETE FROM ACCOUNT WHERE USERNAME = '" + fromUsername + "'");

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            return data; 
        }



    }

}
