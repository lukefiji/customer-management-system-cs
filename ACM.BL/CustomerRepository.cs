using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieves one customer.
        /// </summary>
        /// <param name="customerId">The customer ID</param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Create an instance of the Customer class
            // Pass in requested ID
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined custoemr

            // Temporary hard-coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbitmail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}
