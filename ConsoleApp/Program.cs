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
            //SWAPIHelper swapiHelper = new SWAPIHelper();
            //// SWAPI
            //// Create a method in SWAPI Helper that gets a vehicle's name, mass, and cost by ID
            //SWAPIVehicleModel sandCrawler = swapiHelper.GetVehicleByIDAsync(4).Result;

            //Console.WriteLine(sandCrawler.Name);
            //Console.WriteLine(sandCrawler.Model);
            //Console.WriteLine(sandCrawler.Cost_In_Credits);




            // PokeAPI
            // Create a PokeAPIHelper class that can get a pokemon's name, weight, and height by it's name
            PokeAPIHelper pokeAPIHelper = new PokeAPIHelper();

            PokeAPIPokemon empoleon = pokeAPIHelper.GetPokemonByNameAsync("empoleon").Result;

            Console.WriteLine(empoleon.Name);
            Console.WriteLine(empoleon.Height);
            Console.WriteLine(empoleon.Weight);





            //SWAPIPerson lukeSkywalker = swapiHelper.GetPersonByIDAsync(1).Result;

            //Console.WriteLine("Name: " + lukeSkywalker.Name);
            //Console.WriteLine("Height: " + lukeSkywalker.Height);
            //Console.WriteLine("Mass: " + lukeSkywalker.Mass);

            //Console.ReadKey();

            // Get people and starships by ID
            Console.ReadKey();

        }
    }
}
