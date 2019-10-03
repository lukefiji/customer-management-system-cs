using System;
namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        // ? - denotes a nullable type
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        /// <summary>
        /// Retrieves one product.
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Code that retrieve the defined product

            return new Product();
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }


        /// <summary>
        /// Saves the product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined product

            return true;
        }
    }
}
