using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Book: VirtualOrder,IOrder, ICommission
    {
        public string Name { get; set; }
        public string OrderID { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }

        public void FetchOrders()
        {            
            this.Name = "Book";
            this.OrderID = "B1";
            this.price = 500;
            this.quantity = 2;

        }

        public float GetCommission()
        {
            return 2;

        }

        public string ProcessOrders()
        {
            float com = GetCommission();
            FetchOrders();
            PrintOrders(this);
            return "Duplicate packing slip for the royalty department is generated and calculated commission as " + com+ " %";
        }
    }
}
