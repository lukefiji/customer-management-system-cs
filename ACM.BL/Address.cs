using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public string AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        
        /// <summary>
        /// Validates the address data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
