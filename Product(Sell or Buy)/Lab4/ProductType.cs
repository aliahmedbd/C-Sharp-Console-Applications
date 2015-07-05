using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ProductType
    {
        private string name, description;
        public string typeName 
        {
            get 
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string typeDescription
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

    }
}
