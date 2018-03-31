using System;
using System.Collections.Generic;
using System.Text;

namespace LIC_KIHD_MW
{
    class PolicyHolder
    {
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        private Address address;
        public PolicyHolder(string theFirstName, string theLastName, DateTime theBirthdate, Address theAddress)
        {
            firstName = theFirstName;
            lastName = theLastName;
            birthdate = theBirthdate;
            address = theAddress;
        }
    }
}
