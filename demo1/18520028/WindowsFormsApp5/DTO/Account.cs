using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.dataClass
{
    public class Account
    {
        public Account(string userName, string displayName, int Type, string Password = null)
        {
            this.Username = userName;
            this.Displayname = displayName;
            this.Type = Type;
            this.Password = Password;
        }

        public Account(DataRow row)
        {
            this.Username = row["USERNAME"].ToString();
            this.Displayname = row["DISPLAYNAME"].ToString();
            this.Type = (int)row["TYPE"];
            this.Password = row["PASSWORD"].ToString();
        }

        private int type;
        private string displayname;
        private string password;
        private string username;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public int Type { get => type; set => type = value; }
    }
}
