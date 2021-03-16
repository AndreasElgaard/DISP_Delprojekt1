using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.Vaerktoej
{
    public class IndexModel : PageModel
    {
        public List<VaerktoejModel> LocalModels { get; set; }
        public HttpClient client { get; set; }
        public IndexModel(HttpClient client)
        {
            this.client = client;
            LocalModels = new List<VaerktoejModel>();
        }
        

        public async Task OnGet()
        {
            
            
                client.BaseAddress = new Uri("https://localhost:44376/api");

                var response = client.GetAsync("/Vaerktoej");

                if (response.Result.StatusCode != HttpStatusCode.OK)
                {

                }

                var json = await response.Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<VaerktoejModel>>(json);

                LocalModels = result;

            
        }

    }
}
