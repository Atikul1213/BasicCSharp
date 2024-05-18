using Null_Operator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.Name = "Laptop";
            product.Price = 34223;
            product.ProductType = "Electronics";
            product.Unit = "pcs";


            List<Product> products = new List<Product>()
            {
                new Product()
                {
                     Id = 2,
                    Name = "Mouse",
                    Price = 3233,
                    ProductType = "Computer Equipment",
                    Unit = "Tk"
                },

                new Product()
                {
                    //  Id = 3,
                    Name = "Monitor",
                    Price = 32333,
                    ProductType = "Computer Equipment",
                    Unit = "Tk"
                },
                product
            };


            foreach(Product prd in products)
            {
                Console.WriteLine("Id: "+prd.Id+" Name: "+prd.Name+" Price"+prd.Price+ " product Tye: "+prd.ProductType);

            }


            // Null handle
            Console.WriteLine(product?.RelatedProduct?.Name?? "N/A");


            product.RelatedProduct = product;
            Console.WriteLine(product.RelatedProduct.Name);

        }
    }
}
