using WebApplication3.DAL;
using WebApplication3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.BUS
{
    public class ItemBUS
    {
        ItemDAL itemDAL = new ItemDAL();
        public DataTable GetItemData()
        {
            return itemDAL.GetItem();
        }
        public bool PostItemData(ItemDTO item)
        {
            return itemDAL.PostItem(item);
        }
    }
}
