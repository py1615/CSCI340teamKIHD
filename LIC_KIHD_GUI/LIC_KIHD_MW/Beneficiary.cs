using System;
using System.Collections.Generic;
using System.Text;

namespace LIC_KIHD_MW
{
    class Beneficiary
    {
        private string firstName;
        private string lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public Beneficiary(string theFirstName, string theLastName)
        {
            FirstName = theFirstName;
            LastName = theLastName;
        }

        
    }
}
