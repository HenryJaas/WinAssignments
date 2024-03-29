﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class AirlineCompany
    {

        readonly string airlineName;
        SortedList<Flight, double> flights = new SortedList<Flight, double>(new FlightComparer());

        public AirlineCompany(string airlineName)
        {
            airlineName = airlineName;
        }

        public void AddFlight(Flight flight)
        {
            flights.Add(flight, flight.Price);
        }

        public void DeleteFlight(Flight flight)
        {
            flights.Remove(flight);
        }

        public void EditFlight(Flight flight, double newPrice)
        {
            flights.Remove(flight);
            flight.Price = newPrice;
            flights.Add(flight, newPrice);
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
            get { return flights.Keys[index]; }
            set { flights.Keys[index] = value; }
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
