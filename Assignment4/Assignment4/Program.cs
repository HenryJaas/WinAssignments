using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany airline = new AirlineCompany("MyAirline");

            Flight flight1 = new Flight(1, "New York", "Los Angeles", DateTime.Now.AddDays(10), 500);
            Flight flight2 = new Flight(2, "Chicago", "Dallas", DateTime.Now.AddDays(20), 400);
            Flight flight3 = new Flight(3, "Miami", "San Francisco", DateTime.Now.AddDays(30), 600);

            airline.AddFlight(flight1);
            airline.AddFlight(flight2);
            airline.AddFlight(flight3);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n------- MENU -------");
                Console.WriteLine("1. View all flights");
                Console.WriteLine("2. Add a new flight");
                Console.WriteLine("3. Edit a flight");
                Console.WriteLine("4. Delete a flight");
                Console.WriteLine("5. View cheapest flight");
                Console.WriteLine("6. View most expensive flight");
                Console.WriteLine("7. Search for a flight");
                Console.WriteLine("8. Exit");

                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n------- ALL FLIGHTS -------");
                        for (int i = 0; i < airline.Count; i++)
                        {
                            Flight currentFlight = airline[i];
                            Console.WriteLine($"Flight ID: {currentFlight.Id} | Origin: {currentFlight.Origin} | Destination: {currentFlight.Destination} | Date: {currentFlight.Date} | Price: {currentFlight.Price}");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n------- ADD NEW FLIGHT -------");
                        Console.Write("Enter flight ID: ");
                        int newId = int.Parse(Console.ReadLine());

                        Console.Write("Enter origin city: ");
                        string newOrigin = Console.ReadLine();

                        Console.Write("Enter destination city: ");
                        string newDestination = Console.ReadLine();

                        Console.Write("Enter flight date (in MM/DD/YYYY format): ");
                        DateTime newDate = DateTime.Parse(Console.ReadLine());

                        Console.Write("Enter flight price: ");
                        double newPrice = double.Parse(Console.ReadLine());

                        Flight newFlight = new Flight(newId, newOrigin, newDestination, newDate, newPrice);
                        airline.AddFlight(newFlight);

                        Console.WriteLine("New flight added successfully.");
                        break;

                    case "3":
                        Console.WriteLine("\n------- EDIT FLIGHT -------");
                        Console.Write("Enter flight ID to edit: ");
                        int editId = int.Parse(Console.ReadLine());

                        Flight editFlight = airline.FindFlight(editId);

                        if (editFlight == null)
                        {
                            Console.WriteLine("Flight not found.");
                            break;
                        }

                        Console.Write("Enter new price: ");
                        double newFlightPrice = double.Parse(Console.ReadLine());

                        airline.EditFlight(editFlight, newFlightPrice);

                        Console.WriteLine("Flight updated successfully.");
                        break;

                    case "4":
                        Console.WriteLine("\n------- DELETE FLIGHT -------");
                        Console.Write("Enter flight ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());

                        Flight deleteFlight = airline.FindFlight(deleteId);

                        if (deleteFlight == null)
                        {
                            Console.WriteLine("Flight not found.");
                            break;
                        }

                        airline.DeleteFlight(deleteFlight);

                        Console.WriteLine("Flight deleted successfully.");
                        break;

                    case "5":
                        Console.WriteLine("\n------- CHEAPEST FLIGHT -------");
                        Flight cheapestFlight = airline.GetCheapestFlight();
                        Console.WriteLine($"Cheapest Flight: Flight ID: {cheapestFlight.Id} | Origin: {cheapestFlight.Origin} | Destination: {cheapestFlight.Destination} | Date: {cheapestFlight.Date} | Price: {cheapestFlight.Price}");
                        break;

                    case "6":
                        Console.WriteLine("\n------- MOST EXPENSIVE FLIGHT -------");
                        Flight expensiveFlight = airline.GetMostExpensiveFlight();
                        Console.WriteLine($"Most Expensive Flight: Flight ID: {expensiveFlight.Id} | Origin: {expensiveFlight.Origin} | Destination: {expensiveFlight.Destination} | Date: {expensiveFlight.Date} | Price: {expensiveFlight.Price}");
                        break;

                    case "7":
                        Console.WriteLine("\n------- SEARCH FOR A FLIGHT -------");
                        Console.Write("Enter flight ID to edit: ");
                        int searchId = int.Parse(Console.ReadLine());

                        Flight searchFlight = airline.FindFlight(searchId);
                       
                        if (searchFlight == null)
                        {
                            Console.WriteLine("Flight not found.");
                            break;
                        }
                        Console.WriteLine($"Flight ID: {searchFlight.Id} | Origin: {searchFlight.Origin} | Destination: {searchFlight.Destination} | Date: {searchFlight.Date} | Price: {searchFlight.Price}");
                        break;

                    case "8":
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