using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class UnitTest1
    {
        [Fact]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // Act
            string actual = customer.FullName;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            // Act
            string actual = customer.FullName;

            Assert.Equal(actual, expected);
        }


        [Fact]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            // Act
            string actual = customer.FullName;

            Assert.Equal(actual, expected);
        }
    }
}
