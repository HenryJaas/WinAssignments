using System;
using System.Collections.Generic;

namespace Testit
{
    class Concert
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public double Price { get; set; }

        public Concert(string title, string location, DateTime date, TimeSpan time, double price)
        {
            Title = title;
            Location = location;
            Date = date;
            Time = time;
            Price = price;
        }
        public string GetConcertInfo()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4:C}",
                                 Title, Location, Date, Time, Price);
        }

        public override string ToString()
        {
            return $"Concert: {Title}, located at {Location}, will start at {Time} on {Date.ToShortDateString()}. Price: {Price}";
        }
        public static bool operator ==(Concert x, Concert y)
        {
            return x.Price == y.Price;
        }
        public static bool operator !=(Concert x, Concert y)
        {
            return x.Price != y.Price;
        }
        public static bool operator <(Concert x, Concert y)
        {
            return x.Price < y.Price;
        }
        public static bool operator >(Concert x, Concert y)
        {
            return x.Price > y.Price;
        }

        public static Concert operator ++(Concert c)
        {
            return new Concert(c.Title, c.Location, c.Date, c.Time, c.Price + 5);
        }

        public static Concert operator --(Concert c)
        {
            return new Concert(c.Title, c.Location, c.Date, c.Time, c.Price - 5);
        }
    }
}