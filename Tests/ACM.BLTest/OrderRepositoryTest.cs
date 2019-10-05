using ACM.BL;
using System;
using Xunit;
using FluentAssertions;


namespace ACM.BLTest
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();

            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            // Act
            var actual = orderRepository.Retrieve(1);

            actual.Should().BeEquivalentTo(expected);
        }

    }
}
