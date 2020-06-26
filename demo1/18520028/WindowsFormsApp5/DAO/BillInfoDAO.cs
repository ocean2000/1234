using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.dataClass;

namespace WindowsFormsApp5.data
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        { get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
          private set => instance = value;
        }

        private BillInfoDAO() { }

        public List<Billinfo> getListBillInfo(int id)
        {
            List<Billinfo> list = new List<Billinfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT A.* FROM BILL AS B, BILLINFO AS A WHERE B.IDBILL = "+id+" AND B.STATUS = 0 AND A.IDBILL = B.IDBILL" );

            foreach(DataRow item in data.Rows)
            {
                Billinfo bill = new Billinfo(item);
                list.Add(bill);
            }
            return list;
        }

        public void insertBillinfo(int idbill, string iditem, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE ITEM SET TOTAL = TOTAL - " + count + " WHERE IDITEM = N'" + iditem + "'");
            DataProvider.Instance.ExecuteNonQuery("USP_INSERTBILLINFO @IDBILL , @IDITEM , @COUNT ", new object[] { idbill, iditem, count });
        }

        public void deleteBillinfo(int idbill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT IDITEM, COUNT FROM BILLINFO WHERE IDBILL = " + idbill);
            foreach(DataRow item in data.Rows)
            {
                int a = (int)item["COUNT"];
                string b = item["IDITEM"].ToString();
                DataProvider.Instance.ExecuteNonQuery("UPDATE ITEM SET TOTAL = TOTAL + "+ a +" WHERE IDITEM =  N'"+ b +"'");
            }
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM BILLINFO WHERE IDBILL = " + idbill);
        }

        public int deleteBillinfoByIdItem(string iditem)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM BILLINFO WHERE IDITEM = N'" + iditem +"'");
        }

        public void deleteBillInfoByIdBillAndIdItem(int idbill, string iditem)
        {
            int count = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT FROM BILLINFO WHERE IDBILL = " + idbill + " AND IDITEM = N'" + iditem + "'");
            DataProvider.Instance.ExecuteNonQuery("UPDATE ITEM SET TOTAL = TOTAL + " + count + " WHERE IDITEM =  N'" + iditem + "'");
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM BILLINFO WHERE IDBILL = " + idbill + " AND IDITEM = N'" + iditem + "'");

        }
    }
}
