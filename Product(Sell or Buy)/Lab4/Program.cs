using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductType ob1 = new ProductType();
            ob1.typeDescription = "This is soap";
            ob1.typeName = "Universal";
            Product ob2 = new Product("Lux", 10.0, 38.0, ob1);

            Console.WriteLine("After Buying:\n\n");
            ob2.buy(5);
            ob2.print_Product();

            Console.WriteLine("After Selling : \n\n");
            ob2.sell(5);
            ob2.print_Product();

        }
    }
}
