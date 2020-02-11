using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            List<IProduct> cart = AddProductData();

            CustomerModel custo = new CustomerModel { 
                                                        Name="Siddhesh",
                                                        Address="Vikhroli",
                                                        mobileNo=8989765423
                                        
                                                         };

            foreach(IProduct prod in cart)
            {
                prod.ShipItem(custo);
            }

            Console.ReadKey();

        }

        private static List<IProduct> AddProductData()
        {
            List<IProduct> output = new List<IProduct>();
            output.Add(new PhysicalProduct {Title="Nike Football" });
            output.Add(new PhysicalProduct {Title="Colgate" });
            output.Add(new PhysicalProduct { Title = "Boat Rockerzz 255 Wireless Headphones" });
            output.Add(new PhysicalProduct { Title="Angular Book "});
            output.Add(new DigitalProduct {Title="Reward Points" });

            return output;
        }

    }
}
