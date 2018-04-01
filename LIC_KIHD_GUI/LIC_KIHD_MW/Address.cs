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
        public Address(string theStreet, string theCity, string theState, string theZip)
        {
            street = theStreet;
            city = theCity;
            state = theState;
            zip = theZip;
        }
    }
}
