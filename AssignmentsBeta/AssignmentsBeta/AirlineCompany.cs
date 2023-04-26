using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBeta
{
    public class AirlineCompany
    {

        readonly string airlineName;
        SortedList<double, Flight> flights;

        public AirlineCompany(string airlineName)
        {
            this.airlineName = airlineName;           
        }

        public void AddFlight(Flight flight)
        {
            flights.Add(flight.Price, flight);
        }

        public void DeleteFlight(Flight flight)
        {
            flights.Remove(flight);
        }

        public Flight FindFlight(int id)
        {
            foreach (Flight flight in flights.Keys)
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
            return flights.Keys[0];
        }

        public Flight GetMostExpensiveFlight()
        {
            return flights.Keys[flights.Count - 1];
        }

        public int Count
        {
            get { return flights.Count; }
        }

        public Flight this[int index]
        {
            get
            {
                foreach (Flight flight in flights.Values)
                {
                    if (flight.Id == index)
                    {
                        return flight;
                    }
                }
                return new Flight();
            }
            set
            {
                flights.Add(value.Price, value);
            }
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
