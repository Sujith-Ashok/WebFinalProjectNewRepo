using System;
namespace Invent_Fashion_API
{
    public class OrderDetail
    {
        public int orderID { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        
        public DateTime dateOfHire { get; set; }

        public OrderDetail(int orderID, string name, string model, string size, string color, DateTime dateOfHire)
        {
            this.orderID = orderID;
            this.name = name;
            this.model = model;
            this.size = size;
            this.color = color;
            this.dateOfHire = dateOfHire;
        }

      
    }
}
