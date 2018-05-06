using System;
using System.Collections.Generic;
using System.Text;

namespace LIC_KIHD_MW
{
    class Address
    {
        private string street;
        private string city;
        private string state;
        private string zip;

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }

        public Address(string theStreet, string theCity, string theState, string theZip)
        {
            Street = theStreet;
            City = theCity;
            State = theState;
            Zip = theZip;
        }

    }
}
