using System;
using System.Collections.Generic;
using System.Text;

namespace LIC_KIHD_MW
{
    class Payment
    {
        private double amount;
        private DateTime date;
        private string paymentType;
        public Payment(double theAmount, string type)
        {
            amount = theAmount;
            date = DateTime.Now;
            paymentType = type;
        }
    }
}
