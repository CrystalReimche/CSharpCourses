using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainConstructors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const float PUYALLUP_SALES_TAX = 6.5f;
            
            // CREATE PRODUCT OBJECTS
            Product Product1 = new Product()
            {
                ID = 5042,
                ProductName = "6' Leash, Black",
                ProductPrice = (PUYALLUP_SALES_TAX / 9.99f) + 9.99f,
            };

            Product Product2 = new Product()
            {
                ID = 4795,
                ProductName = "Padded Harness, Black, XL",
                ProductPrice = (PUYALLUP_SALES_TAX / 24.99f) + 24.99f
            };

            Product Product3 = new Product()
            {
                ID = 8472,
                ProductName = "Military Adjustable Dog Collar w/ Buckle, Ranger Green, L",
                ProductPrice = (PUYALLUP_SALES_TAX / 5.99f) + 5.99f
            };

            Product Product4 = new Product()
            {
                ID = 2483,
                ProductName = "Power Chewer Dog Bone, Bacon Flavor, Giant",
                ProductPrice = (PUYALLUP_SALES_TAX / 9.99f) + 9.99f
            };

            // ADD PRODUCTS TO DICTIONARY
            Dictionary<int, Product> dictionaryProducts = new Dictionary<int, Product>
            {
                { Product1.ID, Product1 },
                { Product2.ID, Product2 },
                { Product3.ID, Product3 },
                { Product4.ID, Product4 }
            };


            foreach (KeyValuePair<int, Product> productKVP in dictionaryProducts)
            {
                Console.WriteLine($"Key: {productKVP.Key}");
                var prod = productKVP.Value;
                Console.WriteLine($"ID: {prod.ID}, Product Name: {prod.ProductName}, Product Price (including tax): {prod.ProductPrice,0:C02}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }

            










            Console.ReadKey();
        }
    }

    
}
