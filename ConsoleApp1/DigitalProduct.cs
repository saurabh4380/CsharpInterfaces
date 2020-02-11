using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DigitalProduct:IProduct
    {
       public  String Title { get; set; }
       public  Boolean isShipped { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            if (isShipped == false)
            {
                Console.WriteLine($"Emailing order details for  {Title} to {customer.Name} ");
            }
        }


    }
}
