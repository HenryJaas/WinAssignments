using System;

namespace Assignment3
{
    public class Flight
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public Flight(int id, string origin, string destination, DateTime date, double price)
        {
            this.Id = id;
            this.Origin = origin;
            this.Destination = destination;
            this.Date = date;
            this.Price = price;
        }
    }
}
    