using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var concerts = new Dictionary<string, Concert>
            {
                {"Weekend Festival", new Concert("Weekend Festival", "Espoo, Vermo", new DateTime(2023, 6, 2),new TimeSpan(18, 30, 0), 108)},
                {"Ruisrock", new Concert("Ruisrock", "Turun satama", new DateTime(2023, 8, 11),new TimeSpan(12, 0, 0), 90)},
                {"Sziget", new Concert("Sziget", "Budapest", new DateTime(2023, 8, 8),new TimeSpan(14, 0, 0), 240)},
                {"Ultra", new Concert("Ultra", "Split", new DateTime(2023, 7, 9),new TimeSpan(12, 0, 0), 180)},
                {"Tomorrowland", new Concert("Tomorrowland", "Antwerp", new DateTime(2023, 7, 21),new TimeSpan(13, 0, 0), 450)},



            };

            foreach (var concert in concerts)
            {
                Console.WriteLine(concert.Value);
            }
            Console.WriteLine($"Is Weekend Festival more expensive than Ruisrock?{concerts["Weekend Festival"] > concerts["Ruisrock"]}");
        }
    }
}
