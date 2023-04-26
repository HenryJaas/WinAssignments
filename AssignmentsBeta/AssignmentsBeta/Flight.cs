using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBeta
{
    public class Flight
    {
        int id;
        string origin;
        string destination;
        DateTime date;
        double price;

        public Flight(int id, string origin, string destination, DateTime date, double price)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.price = price;
        }

        public int Id
        {
            get { return id; }
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }        
    }
}
