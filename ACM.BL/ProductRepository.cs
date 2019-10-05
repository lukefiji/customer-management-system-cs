using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieves one product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted-size set of 4 brith yellow mini sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        /// <summary>
        /// Retrieves one customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the defined product
            return true;
        }
    }
}
