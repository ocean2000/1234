using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.BUS;
using WebApplication3.DTO;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        ItemBUS itemBUS = new ItemBUS();
        [HttpGet]
        public IActionResult Get()
        {
            DataTable data = new DataTable();
            data = itemBUS.GetItemData();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post([FromBody] ItemDTO item)
        {
            itemBUS.PostItemData(item);
            return Ok(item);
        }

    }
}