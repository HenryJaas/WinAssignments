using System;

namespace Assign2A
{
    class Program
    {
        static void Main(string[] args)
        {
            //8 Asiakasta, customerID, customerName, flightID
            Customer[] customers = new Customer[8];
            customers[0] = new Customer(10, " Pekka", 100);
            customers[1] = new Customer(20, " Heikki", 200);
            customers[2] = new Customer(30, " Emma", 300);
            customers[3] = new Customer(40, " Eetu", 100);
            customers[4] = new Customer(50, " Jetro", 300);
            customers[5] = new Customer(60, " Janne", 400);
            customers[6] = new Customer(70, " Julia", 400);
            customers[7] = new Customer(80, " Jesse", 100);

            //4 Lentoa, flightID, origin, destination, date
            Flight[] flights = new Flight[4];
            flights[0] = new Flight(100, " Oulu", "Helsinki", "31/01/2023");
            flights[1] = new Flight(200, " Helsinki", "Oulu", "30/01/2023");
            flights[2] = new Flight(300, " Rovaniemi", "Helsinki", "29/01/2023");
            flights[3] = new Flight(400, " Helsinki", "Rovaniemi", "11/02/2023");

            //Kysyy kummalla etsii
            Console.WriteLine("Enter 1 to search with Flight ID or 2 to search with Customer ID: ");
            int searchOption = int.Parse(Console.ReadLine());

            //Jos 1= niin etsii flightID:llä
            if (searchOption == 1)
            {
                Console.WriteLine("Enter the Flight ID to search: ");
                int searchID = int.Parse(Console.ReadLine());

                for (int i = 0; i < flights.Length; i++)
                {
                    if (flights[i]._flightID == searchID)
                    {
                        Console.WriteLine(flights[i].FlightInfo(flights[i]._flightID));
                        for (int j = 0; j < customers.Length; j++)
                        {
                            if (customers[j]._flightID == flights[i]._flightID)
                            {
                                Console.WriteLine(customers[j].CustomerInfo(customers[j]._customerID));
                            }
                        }
                    }
                }
            }
            //Jos 2 = niin etsii CustomerID:llä
            else if (searchOption == 2)
            {
                Console.WriteLine("Enter the Customer ID to search: ");
                int searchID = int.Parse(Console.ReadLine());

                for (int i = 0; i < customers.Length; i++)
                {
                    if (customers[i]._flightID == searchID || customers[i]._customerID == searchID)
                    {
                        Console.WriteLine(customers[i].CustomerInfo(customers[i]._customerID));
                        for (int j = 0; j < flights.Length; j++)
                        {
                            if (flights[j]._flightID == customers[i]._flightID)
                            {
                                Console.WriteLine(flights[j].FlightInfo(flights[j]._flightID));
                            }
                        }
                    }
                }
            }
        }
    }
}