using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        public static void Main()
        {
            AirlineCompany airline = new AirlineCompany("Airline 1");
            airline[0] = new Flight(1, "New York", "London", DateTime.Now.AddDays(5), 500.0);
            airline[1] = new Flight(2, "London", "Paris", DateTime.Now.AddDays(10), 350.0);
            airline[2] = new Flight(3, "Paris", "New York", DateTime.Now.AddDays(15), 700.0);
            airline[3] = new Flight(4, "Los Angeles", "New York", DateTime.Now.AddDays(20), 900.0);

            Flight cheapest = airline.GetCheapestFlight();
            Console.WriteLine("Cheapest flight:");
            Console.WriteLine("ID: {0}, Origin: {1}, Destination: {2}, Date: {3}, Price: {4}",
                cheapest.Id, cheapest.Origin, cheapest.Destination, cheapest.Date, cheapest.Price);

            Flight mostExpensive = airline.GetMostExpensiveFlight();
            Console.WriteLine("Most expensive flight:");
            Console.WriteLine("ID: {0}, Origin: {1}, Destination: {2}, Date: {3}, Price: {4}",
                mostExpensive.Id, mostExpensive.Origin, mostExpensive.Destination, mostExpensive.Date, mostExpensive.Price);

            Flight flight = airline.FindFlight(2);
            Console.WriteLine("Flight with ID 2:");
            Console.WriteLine("ID: {0}, Origin: {1}, Destination: {2}, Date: {3}, Price: {4}",
                flight.Id, flight.Origin, flight.Destination, flight.Date, flight.Price);
        }
    }
}
