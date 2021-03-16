using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;

namespace Frontend_Project.ClientHelper
{
    public class HttpClientHelper
    {
        public HttpClient client { get; set; }
        public HttpClientHelper()
        {
            
            client.BaseAddress = new Uri("http://localhost:44376");
        }

        public async Task<List<HaandvaerkerModel>> OnGet()
        {
            var response = await client.GetAsync("/api/Haandvaerker");

            response.EnsureSuccessStatusCode();
            //LocalModels = client.GetFromJsonAsync<HaandvaerkerModel>("http://localhost:44376/api/Haandvaerker");

            if (response.IsSuccessStatusCode)
            {
                var LocalModels = await response.Content.ReadFromJsonAsync<List<HaandvaerkerModel>>();

                return LocalModels;
            }

            return null;

        }
    }
}
