using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class AirlineCompany
    {
        public readonly string AirlineName;
        private SortedList<Flight, double> flights;

        public AirlineCompany(string name)
        {
            AirlineName = name;
            flights = new SortedList<Flight, double>();
        }

        public void AddFlight(Flight flight, double price)
        {
            flights.Add(flight, price);
        }

        public Flight FindFlight(int id)
        {
            foreach (var flight in flights)
            {
                if (flight.Key.Id == id)
                {
                    return flight.Key;
                }
            }
            return null;
        }

        public Flight GetCheapestFlight()
        {
            return flights.Keys[0];
        }

        public Flight GetMostExpensiveFlight()
        {
            return flights.Keys[flights.Count - 1];
        }

        public SortedList<Flight, double> this[int index]
        {
            get { return flights; }
            set { flights = value; }
        }
    }
}
