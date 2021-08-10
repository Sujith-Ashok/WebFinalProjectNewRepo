using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Invent_Fashion_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {

        List<OrderDetail> orderDetail = new List<OrderDetail>()
            {
            new OrderDetail(1,"Sujith", "Tshirt 10", "M","Red", DateTime.Today),
            new OrderDetail(2, "Ashok", "Pant 8", "s", "Blue", DateTime.Today),


            new OrderDetail(3, "Dhoni", "shirt 7", "L", "Yellow", DateTime.Today)

        };

        [HttpGet]
        public List<OrderDetail> Get()
        {



            return orderDetail;
        }

        [HttpGet("{orderID}", Name = "Get")]
        public OrderDetail Get(int orderID)
        {
            OrderDetail friend = orderDetail.Find(f => f.orderID == orderID);
            return friend;
        }
    }
}