using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        // Not automatically created if there are
        // overloaded constructors defined
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; set; }
        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            // Last name & email address are required
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
