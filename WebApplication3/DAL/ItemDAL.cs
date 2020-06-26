using WebApplication3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DAL
{
    public class ItemDAL
    {
        public DataTable GetItem()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM ITEM";
            data = DBConnect.Instance.ExecuteQuery(query);
            return data;
        }
        public List<Item> getItem()
        {
            List<Item> list = new List<Item>();
            //string query = "SELECT IDITEM AS [Mã hàng], NAMEITEM AS [Tên hàng], PRICE AS [Đơn giá], TOTAL AS [Tồn kho] FROM ITEM";
            string query = "SELECT * FROM ITEM";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                //Item item1 = new Item(item);
                // list.Add(item1);
            }
            return list;
        }
        public string getNameItemById(string id)
        {
            string nameItem = "";
            string query = "SELECT NAMEITEM FROM ITEM WHERE IDITEM = @id";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            DataRow row = data.Rows[0];
            nameItem = row["NAMEITEM"].ToString();
            return nameItem;
        }
        public float getPriceItemById(string id)
        {
            float total = 0;
            string query = "SELECT PRICE FROM ITEM WHERE IDITEM = @id ";
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            DataRow row = data.Rows[0];
            total = (float)Convert.ToDouble(row["PRICE"]);
            return total;
        }

        public bool PostItem(ItemDTO item)
        {

            string query = "INSERT INTO ITEM(IDITEM,NAMEITEM,PRICE,TOTAL) VALUES('" + item.Id1 + "','" + item.Name1 + "','" + item.Price1 + "','" + item.Total1 + "')";
            try
            {
                DBConnect.Instance.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public int InsertItem(string iditem, string nameitem, int total, float price)
        {
            string query = string.Format("INSERT ITEM (IDITEM, NAMEITEM, TOTAL, PRICE) VALUES (N'{0}', N'{1}', {2}, {3})", iditem, nameitem, total, price);

            int data = DBConnect.Instance.ExecuteNonQuery(query);

            return data;
        }


        public int UpdateItem(string iditem, string nameitem, int total, float price)
        {
            string query = string.Format("UPDATE ITEM SET NAMEITEM = N'{0}', TOTAL = {1}, PRICE = {2} WHERE IDITEM = N'{3}'", nameitem, total, price, iditem);

            int data = DBConnect.Instance.ExecuteNonQuery(query);

            return data; // lớn hơn 0 là thành công
        }

        //public int DeleteItem(string iditem)
        //{
        //    BillInfoDAO.Instance.deleteBillinfoByIdItem(iditem);
        //    string query = string.Format("DELETE FROM ITEM WHERE IDITEM = N'" + iditem + "'");

        //    int data = DataProvider.Instance.ExecuteNonQuery(query);

        //    return data; // lớn hơn 0 là thành công
        //}

        public List<Item> SearchItemByName(string name)
        {
            List<Item> list = new List<Item>();


            string query = string.Format("SELECT * FROM ITEM WHERE DBO.fuConvertToUnsign1(NAMEITEM) LIKE N'%' + DBO.fuConvertToUnsign1(N'{0}') + N'%' UNION SELECT * FROM ITEM WHERE DBO.fuConvertToUnsign1(IDITEM) LIKE N'%' + DBO.fuConvertToUnsign1(N'{0}') + N'%' ", name);
            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                //Item item1 = new Item(item);
                //list.Add(item1);
            }
            return list;
        }

        public bool isExistIdItem(string idItem)
        {
            int count = 0;
            string query = "SELECT IDITEM FROM ITEM WHERE IDITEM = N'" + idItem + "'";

            DataTable data = DBConnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                count++;
            }

            if (count > 0)
                return true;
            else
                return false;
        }

    }

    public class Item
    {
    }
}

namespace WebApplication3
{
    class DataProvider
    {
    }
}