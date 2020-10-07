using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PokeAPIHelper
    {
        public async Task<PokeAPIPokemon> GetPokemonByNameAsync(string name)
        {
            HttpClient http = new HttpClient();

            HttpResponseMessage pokemonByNameReq = await http.GetAsync("https://pokeapi.co/api/v2/pokemon/" + name);
            if (pokemonByNameReq.IsSuccessStatusCode)
            {
                string resBody = await pokemonByNameReq.Content.ReadAsStringAsync();

                PokeAPIPokemon requestedPokemon = JsonConvert.DeserializeObject<PokeAPIPokemon>(resBody);

                return requestedPokemon;
            }
            return new PokeAPIPokemon();
        }
    }
}
