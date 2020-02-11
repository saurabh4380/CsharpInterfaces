using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PhysicalProduct : IProduct
    {
        public string Title { get; set; }
        public bool isShipped { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            if (isShipped == false)
            {
                Console.WriteLine($"Simulating shipping {Title} to {customer.Name} at {customer.Address}");
                isShipped = true;
            }
           
        }
    }

  
}
