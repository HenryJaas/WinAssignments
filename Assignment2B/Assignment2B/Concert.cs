using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2B
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
        public override string ToString()
        {
            return $"Concert: {Title}, location:{Location}, starting time: {Time}, date:{Date.ToShortDateString()}, Price: {Price}";
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
            return new Concert(c.Title, c.Location, c.Date, c.Time, c.Price);
        }
        public static Concert operator --(Concert c)
        {
            return new Concert(c.Title, c.Location, c.Date, c.Time, c.Price);
        }
    }
}
