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

        public async Task<IActionResult> OnGet()
        {

        //client.BaseAddress = new Uri("https://localhost:44376/");


        var response = await client.GetAsync("api/Vaerktoej");

        response.EnsureSuccessStatusCode();
        
        if (response.IsSuccessStatusCode)
        {
            LocalModels = await response.Content.ReadFromJsonAsync<List<VaerktoejModel>>();
        }

        return Page();

        }

    }
}
