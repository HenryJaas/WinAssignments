using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Concert concert1 = new Concert("Beethoven", "Pori", new DateTime(2023, 6, 2), new TimeSpan(18, 30, 0), 108);
            Concert concert2 = new Concert("Mozart", "Turun satama", new DateTime(2023, 8, 11), new TimeSpan(12, 0, 0), 90);
            Concert concert3 = new Concert("Tchaikovsky", "Budapest", new DateTime(2023, 8, 8), new TimeSpan(14, 0, 0), 240);
            Concert concert4 = new Concert("Vivaldi", "Split", new DateTime(2023, 7, 9), new TimeSpan(12, 0, 0), 108);
            Concert concert5 = new Concert("Sebastian Bach", "Antwerp", new DateTime(2023, 7, 21), new TimeSpan(13, 0, 0), 450);

            List<Concert> concertList = new List<Concert>();

            concertList.Add(concert1);
            concertList.Add(concert2);
            concertList.Add(concert3);
            concertList.Add(concert4);
            concertList.Add(concert5);

            //saa "€" näkyviin 
            Console.OutputEncoding = Encoding.UTF8;

            foreach (Concert concert in concertList)
            {
                Console.WriteLine(concert.GetConcertInfo());
            }

           Console.WriteLine("");

            concertList.Sort((x, y) => x.Price.CompareTo(y.Price));

            foreach (Concert concert in concertList)
            {
                Console.WriteLine(concert.GetConcertInfo());
            }
            //Increase the price of the first concert by 5
            Concert increasedPrice1 = ++concert1;
            Console.WriteLine("\n" + "The increased price of the first concert is: {0:C}" + "\n", increasedPrice1.Price);

            //Decrease the price of the third concert by 5
            Concert decreasedPrice3 = --concert3;
            Console.WriteLine("The decreased price of the third concert is: {0:C}" + "\n", decreasedPrice3.Price);

            //Check if the first and second concerts are equal
            Console.WriteLine("Are the first and second concerts equal? {0}" + "\n", concert1 == concert2);

            //Check if the fourth concert is smaller than the fifth
            Console.WriteLine("Is the fourth concert smaller than the fifth? {0}" + "\n", concert4 < concert5);
        }
    }
}
