using System;
using System.Collections;

namespace Assignment3
{
    using System;
    using System.Collections;

    public class AirlineCompany
    {
        public readonly string AirlineName;
        private SortedList flights;

        public AirlineCompany(string airlineName)
        {
            this.AirlineName = airlineName;
            flights = new SortedList();
        }

        // Indexer to get and set Flight objects
        public Flight this[int index]
        {
            get { return (Flight)flights.GetByIndex(index); }
            set { flights.Add(value.Price, value); }
        }

        // Method that returns the Flight object if the flight id is provided
        public Flight FindFlight(int id)
        {
            foreach (DictionaryEntry entry in flights)
            {
                Flight f = (Flight)entry.Value;
                if (f.Id == id)
                {
                    return f;
                }
            }
            return null;
        }

        // Method that returns the Flight object with the lowest price
        public Flight GetCheapestFlight()
        {
            Flight f = (Flight)flights.GetByIndex(0);
            return f;
        }

        // Method that returns the Flight object with the highest price
        public Flight GetMostExpensiveFlight()
        {
            Flight f = (Flight)flights.GetByIndex(flights.Count - 1);
            return f;
        }
    }

}
