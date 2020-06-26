using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.dataClass
{
    public class Bill
    {
        public Bill(int idbill, string username, int status, DateTime? datetime, int discount1 = 0)
        {
            this.IDBill = idbill;
            this.Username = username;
            this.Date = datetime;
            this.Status = status;
            this.Discount = discount1;
        }

        public Bill(DataRow row)
        {
            this.iDBill = (int)row["IDBILL"];
            this.Username = row["USERNAME"].ToString();
            this.Date = (DateTime?)row["DATE"];
            this.Status = (int)row["STATUS"];
            this.Discount = (int)row["DISCOUNT"];
        }

        private int discount;
        private int status;
        private DateTime? Date; //  question mark cho phép có thể null
        private string username;
        private int iDBill;

        public int IDBill { get => iDBill; set => iDBill = value; }
        public DateTime? Date1 { get => Date; set => Date = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Status { get => status; set => status = value; }
        public string Username { get => username; set => username = value; }
    }
}
