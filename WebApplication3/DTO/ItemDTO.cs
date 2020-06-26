using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DTO
{
    public class ItemDTO
    {
        private string Id;
        private string Name;
        private string Price;
        private string Total;

        public string Total1 { get => Total; set => Total = value; }
        public string Id1 { get => Id; set => Id = value; }
        public string Price1 { get => Price; set => Price = value; }
        public string Name1 { get => Name; set => Name = value; }
        public ItemDTO(string id, string name, string price, string total)
        {
            Id = id;
            Name = name;
            Price = price;
            Total = total;
        }
    }
}
