using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2A
{
    class Customer
    {
        public int _customerID;
        public string _customerName;
        public int _flightID;

        public Customer(int customerID, string customerName, int flightID)
        {
            _customerID = customerID;
            _customerName = customerName;
            _flightID = flightID;
        }

        public string CustomerInfo(int customerID)
        {
            if (customerID == _customerID)
            {
                return "Customer ID: " + _customerID + " Name: " + _customerName + " Flight ID: " + _flightID;
            }
            else
            {
                return "Invalid Customer ID";
            }
        }
    }
}