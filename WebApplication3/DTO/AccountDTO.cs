using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    namespace WebApplication3.DTO
    {
        public class AccountDTO
        {
        private int type;
        private string displayname;
        private string password;
        private string username;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public int Type { get => type; set => type = value; }
        public AccountDTO(string id, string name, string price, string total)
            {
                Username = username;
                Password = password;
                Displayname = displayname;
                Type = type;
            }
        }
    }