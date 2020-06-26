using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.data
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            private set => instance = value;
        }
        private BillDAO() { }

        public void insertBill(string username)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_INSERTBILL @USERNAME", new object[] { username });
        }

        public DataTable GetBillListByDate(DateTime fromdate, DateTime todate, string account, string iditem)
        {
            if(account != "Tất cả") // nếu có chọn acc
            {
                if(iditem != "Tất cả") // nếu có acc, có  item
                    return DataProvider.Instance.ExecuteQuery("USP_GETLISTBILLBYDATEANDITEMANDACCOUNT @FROMDATE , @TODATE , @IDITEM , @ACCOUNT", new object[] { fromdate, todate, iditem, account });
                else // có acc, ko có item
                    return DataProvider.Instance.ExecuteQuery("USP_GETLISTBILLBYDATEANDACCOUNT @FROMDATE , @TODATE , @ACCOUNT", new object[] { fromdate, todate, account });

            }
            else // ko chọn acc
            {
                if(iditem != "Tất cả") // ko acc, có chọn item
                    return DataProvider.Instance.ExecuteQuery("USP_GETLISTBILLBYDATEANDITEM @FROMDATE , @TODATE , @IDITEM", new object[] { fromdate, todate, iditem });
                else // ko acc, ko chọn item
                    return DataProvider.Instance.ExecuteQuery("USP_GETLISTBILLBYDATE @FROMDATE , @TODATE", new object[] { fromdate, todate });


            }
        }

        public DataTable GetBillDetail(int idbill)
        {
            string query = "SELECT A.USERNAME AS [NGƯỜI BÁN], B.IDBILL AS [SỐ HÓA ĐƠN], BI.IDITEM AS [MÃ SẢN PHẨM], BI.COUNT AS [SỐ LƯỢNG], I.PRICE AS [GIÁ], BI.COUNT * I.PRICE AS [TỔNG CỘNG], B.DATE AS [NGÀY TẠO] FROM BILLINFO BI, ITEM I, BILL B, ACCOUNT A WHERE BI.IDBILL = " + idbill + " AND BI.IDBILL = B.IDBILL AND BI.IDITEM = I.IDITEM AND A.USERNAME = B.USERNAME";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        public int GetMaxBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(IDBILL) FROM BILL");
            }
            catch
            {
                return -1;
            }
        }

        public void PayBill(int id, int discount, float totalPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE BILL SET STATUS = 1, " + "DISCOUNT = " +discount+", TOTALPRICE = "+totalPrice+ " WHERE IDBILL = " + id);
        }

        public void deleteBill(int idbill)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE FROM BILL WHERE IDBILL = " + idbill);
        }

        public void ChangeUsername(string fromUsername, string toUsername) // ĐỔI USERNAME SANG 1 USER MẶC ĐỊNH
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE BILL SET USERNAME = '"+ toUsername +"' WHERE USERNAME = '"+ fromUsername +"'");
        }

        public DataTable Report2()
        {
            return DataProvider.Instance.ExecuteQuery("USP_REPORT2");
        }

        public DataTable Report1()
        {
            return DataProvider.Instance.ExecuteQuery("USP_REPORT1");
        }

        public DataTable Report3()
        {
            return DataProvider.Instance.ExecuteQuery("USP_REPORT3");
        }

        public int Report4()
        {
            return Convert.ToInt32((float)Convert.ToDouble(DataProvider.Instance.ExecuteScalar("SELECT SUM(TOTALPRICE) FROM BILL WHERE YEAR(DATE) = YEAR(GETDATE()) AND MONTH(DATE) = MONTH(GETDATE())").ToString()));
        }
    }
}
