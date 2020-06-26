using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.dataClass;

namespace WindowsFormsApp5.data
{
    public class ItemDAO
    {
        private static ItemDAO instance;

        public static ItemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemDAO();
                return ItemDAO.instance;
            }
            private set => instance = value;
        }
        private ItemDAO() { }
        public List<Item> getItem()
        {
            List<Item> list = new List<Item>();
            //string query = "SELECT IDITEM AS [Mã hàng], NAMEITEM AS [Tên hàng], PRICE AS [Đơn giá], TOTAL AS [Tồn kho] FROM ITEM";
            string query = "SELECT * FROM ITEM";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                 //Item item1 = new Item(item);
               // list.Add(item1);
            }
            return list;
        }

        public DataTable GetListIdItem()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IDITEM FROM ITEM");
        }

        public string getNameItemById(string id)
        {
            string nameItem = "";
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT NAMEITEM FROM ITEM WHERE IDITEM = @id ", new object[] { id });
            DataRow row = data.Rows[0];
            nameItem = row["NAMEITEM"].ToString();
            return nameItem;
        }

        public float getPriceItemById(string id)
        {
            float total = 0;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT PRICE FROM ITEM WHERE IDITEM = @id ", new object[] { id });
            DataRow row = data.Rows[0];
            total = (float) Convert.ToDouble(row["PRICE"]);
            return total;
        }

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

        public List<Item> SearchItemByName(string name)
        {
            List<Item> list = new List<Item>();
            
            // sử dụng hàm từ csdl, hàm này coppy của người ta :(
            // hàm này mục đích là chuyển đổi name và NAMEITEM của csdl thành Unsig hết
            // khi đồng bộ là Unsig thì so sánh tìm gần đúng với từ khóa LIKE của SQL
            string query = string.Format("SELECT * FROM ITEM WHERE DBO.fuConvertToUnsign1(NAMEITEM) LIKE N'%' + DBO.fuConvertToUnsign1(N'{0}') + N'%' UNION SELECT * FROM ITEM WHERE DBO.fuConvertToUnsign1(IDITEM) LIKE N'%' + DBO.fuConvertToUnsign1(N'{0}') + N'%' ", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
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
            string query = "SELECT IDITEM FROM ITEM WHERE IDITEM = N'"+ idItem +"'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                count++;
            }

            if (count > 0)
                return true;
            else
                return false;
        }

        internal DataTable GetListItem()
        {
            throw new NotImplementedException();
        }
    }
}
