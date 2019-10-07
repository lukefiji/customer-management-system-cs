using ACM.BL;
using System;
using Xunit;
using FluentAssertions;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted-size set of 4 brith yellow mini sunflowers",
                CurrentPrice = 15.96M
            };

            // Act
            var actual = productRepository.Retrieve(1);

            // Assert
            actual.Should().BeEquivalentTo(expected);

        }

        [Fact]
        public void SaveTestValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted-size set of 4 brith yellow mini sunflowers",
                CurrentPrice = 18M,
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.Equal(true, actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted-size set of 4 brith yellow mini sunflowers",
                CurrentPrice = null,
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.Equal(false, actual);
        }

    }
}
