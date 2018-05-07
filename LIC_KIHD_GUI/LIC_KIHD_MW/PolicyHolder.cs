using System;
using System.Collections.Generic;
using System.Text;

namespace LIC_KIHD_MW
{
    class PolicyHolder
    {
        private string firstName;
        private string lastName;
        private string birthdate;
        private Address address;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        internal Address Address { get => address; set => address = value; }

        public PolicyHolder(string theFirstName, string theLastName, string theBirthdate, Address theAddress)
        {
            FirstName = theFirstName;
            LastName = theLastName;
            Birthdate = theBirthdate;
            Address = theAddress;
        }

    }
}
