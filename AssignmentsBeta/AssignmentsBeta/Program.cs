using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBeta
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany airline = new AirlineCompany("MyAirline");

            //Flights("DateTime.Now.AddDays(10/20/30)= Adds 10/20/30 days from this day on)

            airline[0] = new Flight(1, "Vaasa", "Lahti", DateTime.Now.AddDays(10), 500);
            airline[1] = new Flight(2, "Helsinki", "Kuusamo", DateTime.Now.AddDays(20), 400);
            airline[2] = new Flight(3, "Kouvola", "Rovaniemi", DateTime.Now.AddDays(30), 600);
            airline[3] = new Flight(4, "Savonlinna", "Porvoo", DateTime.Now.AddDays(40), 150);
            airline[4] = new Flight(5, "Lapua", "Kuopio", DateTime.Now.AddDays(50), 900);

            //Switch case menu

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n------- MENU -------");
                Console.WriteLine("1. View all flights");             
                Console.WriteLine("2. View cheapest flight");
                Console.WriteLine("3. View most expensive flight");
                Console.WriteLine("4. Search for a flight");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n------- ALL FLIGHTS -------");
                        foreach (Flight currentFlight in airline.GetFlightsByPrice())
                        {
                            Console.WriteLine($"Flight ID: {currentFlight.Id} | Origin: {currentFlight.Origin} | Destination: {currentFlight.Destination} | Date: {currentFlight.Date} | Price: {currentFlight.Price}");
                        }
                        break;
                   
                    case "2":
                        Console.WriteLine("\n------- CHEAPEST FLIGHT -------");
                        Flight cheapestFlight = airline.GetCheapestFlight();
                        Console.WriteLine($"Cheapest Flight: Flight ID: {cheapestFlight.Id} | Origin: {cheapestFlight.Origin} | Destination: {cheapestFlight.Destination} | Date: {cheapestFlight.Date} | Price: {cheapestFlight.Price}");
                        break;

                    case "3":
                        Console.WriteLine("\n------- MOST EXPENSIVE FLIGHT -------");
                        Flight expensiveFlight = airline.GetMostExpensiveFlight();
                        Console.WriteLine($"Most Expensive Flight: Flight ID: {expensiveFlight.Id} | Origin: {expensiveFlight.Origin} | Destination: {expensiveFlight.Destination} | Date: {expensiveFlight.Date} | Price: {expensiveFlight.Price}");
                        break;

                    case "4":
                        Console.WriteLine("\n------- SEARCH FOR A FLIGHT -------");
                        Console.Write("Enter flight ID : ");
                        int searchId = int.Parse(Console.ReadLine());

                        Flight searchFlight = airline.FindFlight(searchId);

                        if (searchFlight == null)
                        {
                            Console.WriteLine("Flight not found.");
                            break;
                        }
                        Console.WriteLine($"Flight ID: {searchFlight.Id} | Origin: {searchFlight.Origin} | Destination: {searchFlight.Destination} | Date: {searchFlight.Date} | Price: {searchFlight.Price}");
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("\nGoodbye!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}