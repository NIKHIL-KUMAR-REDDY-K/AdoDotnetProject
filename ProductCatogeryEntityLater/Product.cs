using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatogeryEntityLater
{
   public class Product
    {
        public string productId;
        public string productName;
        public double price;
        public int categoryId;
        
        public Product()
        {

        }

        public Product(string productId, string productName, double price, int categoryId)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.categoryId = categoryId;
        }
    }
}
