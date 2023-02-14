using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany airline = new AirlineCompany("Airline");

            Flight flight1 = new Flight(1, "London", "New York", new DateTime(2020, 10, 15), 500);
            Flight flight2 = new Flight(2, "Berlin", "Beijing", new DateTime(2020, 11, 05), 1000);
            Flight flight3 = new Flight(3, "Moscow", "Paris", new DateTime(2020, 12, 25), 1500);

            airline.AddFlight(flight1, 500);
            airline.AddFlight(flight2, 1000);
            airline.AddFlight(flight3, 1500);

            Console.WriteLine("Flight with id 1: ");
            Flight f1 = airline.FindFlight(1);
            Console.WriteLine("Id: {0}, Origin: {1}, Destination: {2}, Date: {3}, Price: {4}",
                f1.Id, f1.Origin, f1.Destination, f1.Date, f1.Price);

            Console.WriteLine("Cheapest flight: ");
            Flight cheapest = airline.GetCheapestFlight();
            Console.WriteLine("Id: {0}, Origin: {1}, Destination: {2}, Date: {3}, Price: {4}",
                cheapest.Id, cheapest.Origin, cheapest.Destination, cheapest.Date, cheapest.Price);

            Console.WriteLine("Most expensive flight: ");
            Flight mostExpensive = airline.GetMostExpensiveFlight();
            Console.WriteLine("Id: {0}, Origin: {1}, Destination: {2}, Date: {3}, Price: {4}",
                mostExpensive.Id, mostExpensive.Origin, mostExpensive.Destination, mostExpensive.Date, mostExpensive.Price);
        }
    }
}
