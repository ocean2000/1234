using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.data;

namespace WindowsFormsApp5.BUS

{
        public class ItemBUS
        {
        public int InsertItem(string iditem, string nameitem, int total, float price)
        {
            string query = string.Format("INSERT ITEM (IDITEM, NAMEITEM, TOTAL, PRICE) VALUES (N'{0}', N'{1}', {2}, {3})", iditem, nameitem, total, price);

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            return data; // lớn hơn 0 là thành công
        }


        public int UpdateItem(string iditem, string nameitem, int total, float price)
        {
            string query = string.Format("UPDATE ITEM SET NAMEITEM = N'{0}', TOTAL = {1}, PRICE = {2} WHERE IDITEM = N'{3}'", nameitem, total, price, iditem);

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            return data; // lớn hơn 0 là thành công
        }

        public int DeleteItem(string iditem)
        {
            BillInfoDAO.Instance.deleteBillinfoByIdItem(iditem);
            string query = string.Format("DELETE FROM ITEM WHERE IDITEM = N'" + iditem + "'");

            int data = DataProvider.Instance.ExecuteNonQuery(query);

            return data; // lớn hơn 0 là thành công
        }
    }
}

