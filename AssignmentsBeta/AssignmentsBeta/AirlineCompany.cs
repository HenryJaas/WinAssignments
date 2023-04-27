using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBeta
{
    public class AirlineCompany
    {
        //A field to store the name of the airline
        readonly string airlineName;
        //A sorted list to store the flights given by the airline
        SortedList<double, Flight> flights;

        public AirlineCompany(string airlineName)
        {
            this.airlineName = airlineName;
            this.flights = new SortedList<double, Flight>();
        }
             
        public Flight FindFlight(int id)
        {
            foreach (Flight flight in flights.Values)
            {
                //If ID matches return the flight
                if (flight.Id == id)
                {
                    return flight;
                }
            }
            return null;
        }
        public List<Flight> GetFlightsByPrice()
        {            
            return flights.Values.ToList();
        }

        public Flight GetCheapestFlight()
        {
            // List is sorted by price so[0] is the cheapest
            return flights.Values[0];
        }

        public Flight GetMostExpensiveFlight()
        {
            //List is sorted by price so _flights.Count - 1 =Last one of the list is the most expensive one
            return flights.Values[flights.Count - 1];
        }
        //Gets or sets a flight at a given index
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
    }
}
