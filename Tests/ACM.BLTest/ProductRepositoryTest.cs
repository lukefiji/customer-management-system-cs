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

    }
}
