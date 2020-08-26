using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
   public class OrderFactory
    {
        public IOrder CreateOrderFactoryObjects(string selection)
        {
            IOrder yourSelection = null;
            try
            {                
                switch (selection)
                {
                    case "A":
                        yourSelection = new PhysicalProduct();
                        break;
                    case "B":
                        yourSelection = new Book();
                        break;
                    case "C":
                        yourSelection = new Membership();
                        break;
                    case "D":
                        yourSelection = new Upgrade();
                        break;
                    case "E":
                        yourSelection = new Video();
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;

                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("An exception occured {0}",ex);
            }          
            return yourSelection;
        }
    }
}
