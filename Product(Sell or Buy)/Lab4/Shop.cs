using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Shop
    {
        Product[] productArray = new Product[1000];
        public Product this[string productName]
        {
            get
            {
                foreach(Product p in productArray)
                {
                    if(p.Name.Equals(productName))
                        return p;
                }
                return null;
            }
        }
        public void AddNewProduct(Product p)
        {
            int index = -1;
            for (int i = 0; i < 1000; i++)
                if (productArray[i] == null) { index = i; break; }
            if (index != -1) { productArray[index] = p; }
        }

        public Product SearchProduct(String name) { return this[name]; }

        public bool buy(string name, double quantity)
        {
            if (this[name] != null) { return this[name].buy(quantity); }
            else return false;
        }

        public bool sell(string name, double amount)
        {
            if (this[name] != null) { return this[name].sell(amount); }
            else return false;
        }

    }
}
