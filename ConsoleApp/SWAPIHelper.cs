using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SWAPIHelper
    {
        private const string _baseURL = "https://swapi.dev/api/";
        private HttpClient httpClient = new HttpClient();
        public SWAPIHelper()
        {
            httpClient.BaseAddress = new Uri(_baseURL);
        }

        public async Task<SWAPIVehicleModel> GetVehicleByIDAsync(int id)
        {
            HttpResponseMessage vehicleRequest = await httpClient.GetAsync("vehicles/" + id);
            if (vehicleRequest.IsSuccessStatusCode)
            {
                string responseBody = await vehicleRequest.Content.ReadAsStringAsync();

                SWAPIVehicleModel requestedVehicle = JsonConvert.DeserializeObject<SWAPIVehicleModel>(responseBody);

                return requestedVehicle;
            }
            return new SWAPIVehicleModel();
        }

        public async Task<SWAPIPerson> GetPersonByIDAsync(int id)
        {
            HttpResponseMessage nameRequest = await httpClient.GetAsync("people/" + id);
            // https://swapi.dev/api/people/:id
            string responseBody = await nameRequest.Content.ReadAsStringAsync();

            SWAPIPerson requestedPerson = JsonConvert.DeserializeObject<SWAPIPerson>(responseBody);

            return requestedPerson;
        }
    }
}
