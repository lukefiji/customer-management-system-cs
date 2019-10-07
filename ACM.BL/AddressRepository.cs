using System;
using System.Collections;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public AddressRepository()
        {

        }

        /// <summary>
        /// Retrieve one address.
        /// </summary>
        /// <param name="addressId">The address id.</param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        { 
            Address address = new Address(addressId);

            // Code that retrieves the defined address

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144;";
            }

            return address;
        }

        // An IEnumerable is the reccommended way to return
        // a sequence of data, because the results are more
        // flexible for the callers of the method
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <param name="address">An Address.</param>
        /// <returns></returns>
        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
