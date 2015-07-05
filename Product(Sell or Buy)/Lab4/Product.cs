using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product;

namespace Lab4
{
    class Product
    {
        private string name, id;
        private double quantity, unitPrice;
        private ProductType type;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public ProductType Type
        {
            get { return type; }
            set { type = value; }
        }

        public Product(string name, double quantity, double unitPrice, ProductType type)
        {
            this.name = name;
            this.id = IDGENERATOR.generator();
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.type = type;
        }

        public bool buy(double quantity) 
        {
            this.Quantity += quantity;
            return true;
        }

        public bool sell(double amount)
        {
            if (this.Quantity - amount >= 0)
            {
                this.Quantity -= amount;
                return true;
            }
            else return false;
        }
        public void print_Product()
        {
            Console.WriteLine("Product name:" + Name);
            Console.WriteLine("Product ID:" + Id);
            Console.WriteLine("Quantity=" + Quantity);
            Console.WriteLine("Unit Price=" + UnitPrice);
            Console.WriteLine("Product Type:" + Type.typeName);
            Console.WriteLine("Product Description:" + Type.typeDescription);
            Console.WriteLine();
        }

    }
}
