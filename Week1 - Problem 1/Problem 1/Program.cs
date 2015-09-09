using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Services;

namespace Week1___Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var service = new DiveFinderService();

            //List dives
            var beachDives = service.GetAvailableDives();
            Console.WriteLine("Beach Dives\n====================");
            foreach (var beachDive in beachDives)
            {
                var json = JsonConvert.SerializeObject(beachDive, Formatting.Indented);
                Console.WriteLine(json);
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
