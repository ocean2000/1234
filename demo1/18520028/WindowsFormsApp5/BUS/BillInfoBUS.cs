using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.data;

namespace WindowsFormsApp5.BUS
{
    class BillInfoBUS
    {
        public void insertBillinfo(int idbill, string iditem, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE ITEM SET TOTAL = TOTAL - " + count + " WHERE IDITEM = N'" + iditem + "'");
            DataProvider.Instance.ExecuteNonQuery("USP_INSERTBILLINFO @IDBILL , @IDITEM , @COUNT ", new object[] { idbill, iditem, count });
        }
        public void deleteBillinfo(int idbill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT IDITEM, COUNT FROM BILLINFO WHERE IDBILL = " + idbill);
            foreach (DataRow item in data.Rows)
            {
                int a = (int)item["COUNT"];
                string b = item["IDITEM"].ToString();
                DataProvider.Instance.ExecuteNonQuery("UPDATE ITEM SET TOTAL = TOTAL + " + a + " WHERE IDITEM =  N'" + b + "'");
            }
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM BILLINFO WHERE IDBILL = " + idbill);
        }

    }
}
