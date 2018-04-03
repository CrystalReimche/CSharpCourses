using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainConstructors
{
    public class Product
    {
        // PROPERTIES
        public int ID { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }

        // CONSTRUCTORS
        public Product()
        {

        }

        public Product(int _id, string _productName, float _productPrice) : this()
        {
            ID = _id;
            ProductName = _productName;
            ProductPrice = _productPrice;
        }

        
    }
}
