using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IProduct
    {
        String Title { get; set; }
        Boolean isShipped { get; set; }

        void ShipItem(CustomerModel customer);
        
    }
}
