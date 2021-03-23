using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class IndexModel : PageModel
    {
        public List<VaerktoejsKasseModel> LocalModels { get; set; }
        public HttpClient client { get; set; }
        public IndexModel(HttpClient client)
        {
            this.client = client;
            LocalModels = new List<VaerktoejsKasseModel>();
        }
        

        public async Task<IActionResult> OnGet()
        {
            
            client.BaseAddress = new Uri("https://host.docker.internal:5000/");

            var response = await client.GetAsync("/api/VaerktoejsKasse");

            response.EnsureSuccessStatusCode();
            
            if (response.IsSuccessStatusCode)
            {
                LocalModels = await response.Content.ReadFromJsonAsync<List<VaerktoejsKasseModel>>();
            }
            return Page();
            
        }

    }
}
