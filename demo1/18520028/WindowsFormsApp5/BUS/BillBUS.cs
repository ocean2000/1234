using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.BUS
{
    class BillBUS
    {
        public void insertBill(string username)
        {
            data.DataProvider.Instance.ExecuteNonQuery("USP_INSERTBILL @USERNAME", new object[] { username });
        }
        public void deleteBill(int idbill)
        {
            data.DataProvider.Instance.ExecuteNonQuery("DELETE FROM BILL WHERE IDBILL = " + idbill);
        }

    }
}
