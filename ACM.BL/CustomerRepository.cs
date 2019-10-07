using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public AddressRepository addressRepository { get; set; }

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
                // A collaborative relationship between CustomerRepository and AddressRepository
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
