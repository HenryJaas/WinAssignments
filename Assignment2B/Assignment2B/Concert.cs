using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2B
{
    internal class Concert
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
            return string.Format("{0}, {1}, {2:yyyy-MM-dd}, {3}, {4:C}",
                                 Title, Location, Date, Time, Price);
        }
        public override string ToString()
        {
            return $"Concert: {Title}, located at {Location}, will start at {Time} on {Date.ToString("yyyy-MM-dd")}. Price: {Price}";
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
        //Checks if the 
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Concert c = (Concert)obj;
            return Title == c.Title && Location == c.Location && Date == c.Date && Time == c.Time && Price == c.Price;
        }
    }
}