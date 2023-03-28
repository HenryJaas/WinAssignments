using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class AirlineCompany
    {

        readonly string _airlineName;
        SortedList<Flight, double> _flights = new SortedList<Flight, double>(new FlightComparer());

        public AirlineCompany(string airlineName)
        {
            _airlineName = airlineName;
        }

        public void AddFlight(Flight flight)
        {
            _flights.Add(flight, flight.Price);
        }

        public void DeleteFlight(Flight flight)
        {
            _flights.Remove(flight);
        }

        public void EditFlight(Flight flight, double newPrice)
        {
            _flights.Remove(flight);
            flight.Price = newPrice;
            _flights.Add(flight, newPrice);
        }

        public Flight FindFlight(int id)
        {
            foreach (Flight flight in _flights.Keys)
            {
                if (flight.Id == id)
                {
                    return flight;
                }
            }

            return null;
        }

        public Flight GetCheapestFlight()
        {
            return _flights.Keys[0];
        }

        public Flight GetMostExpensiveFlight()
        {
            return _flights.Keys[_flights.Count - 1];
        }

        public int Count
        {
            get { return _flights.Count; }
        }

        public Flight this[int index]
        {
            get { return _flights.Keys[index]; }
            set { _flights.Keys[index] = value; }
        }

        private class FlightComparer : IComparer<Flight>
        {
            public int Compare(Flight x, Flight y)
            {
                return x.Price.CompareTo(y.Price);
            }
        }
    }
}
