using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.dataClass
{
    public class Billinfo
    {

        public Billinfo(int idbillinfo, int idbill,string iditem, int count)
        {
            this.IDBillInfo = IDBillInfo;
            this.IDBill = idbill;
            this.iDItem = iditem;
            this.Count = count;
        }

        public Billinfo(DataRow row)
        {
            this.iDBillInfo = (int)row["IDBILLINFO"];
            this.iDBill = (int)row["IDBILL"];
            this.iDItem = row["IDITEM"].ToString();
            this.Count = (int)row["COUNT"];
        }

        private int Count;
        private string iDItem;
        private int iDBill;
        private int iDBillInfo;

        public int IDBillInfo { get => iDBillInfo; set => iDBillInfo = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public string IDItem { get => iDItem; set => iDItem = value; }
        public int Count1 { get => Count; set => Count = value; }
    }
}
