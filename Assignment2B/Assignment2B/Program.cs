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

            concertList.Sort();

            foreach (Concert concert in concertList)
            {
                Console.WriteLine(concert.GetConcertInfo());
            }         
        }
    }
}
