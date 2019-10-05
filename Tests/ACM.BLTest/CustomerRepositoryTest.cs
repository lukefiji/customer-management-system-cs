using ACM.BL;
using System;
using Xunit;
using FluentAssertions;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbitmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

    }
}
