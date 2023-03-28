using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestiKpl2
{
    public class Flight
    {
        int _id;
        string _origin;
        string _destination;
        DateTime _date;
        double _price;

        public Flight(int id, string origin, string destination, DateTime date, double price)
        {
            _id = id;
            _origin = origin;
            _destination = destination;
            _date = date;
            _price = price;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
