using ACM.BL;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CustomerTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
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

            Assert.AreEqual(actual, expected);
        }

        [Test]
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

            Assert.AreEqual(actual, expected);
        }


        [Test]
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

            Assert.AreEqual(actual, expected);
        }
    }
}