using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SWAPIHelper swapiHelper = new SWAPIHelper();

            string lukesName = swapiHelper.GetPersonNameByIDAsync(1).Result;

            Console.WriteLine(lukesName);

            Console.ReadKey();

            // Get people and starships by ID
        }
    }
}
