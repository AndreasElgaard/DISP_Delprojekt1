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
using Frontend_Project.ClientHelper;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace Frontend_Project.Pages.Haandvaerker
{
    public class IndexModel : PageModel
    {
        public List<HaandvaerkerModel> LocalModels { get; set; }
        public HttpClient client { get; set; }
        public IndexModel(HttpClient client)
        {
            LocalModels = new List<HaandvaerkerModel>();
            this.client = client;
        }
        

        public async Task<IActionResult> OnGetAsync()
        {
        client.BaseAddress = new Uri("https://localhost:44376/");

        var response = await client.GetAsync("api/Haandvaerker");

        response.EnsureSuccessStatusCode();
        //LocalModels = client.GetFromJsonAsync<HaandvaerkerModel>("http://localhost:44376/api/Haandvaerker");

        if (response.IsSuccessStatusCode)
        {
            LocalModels = await response.Content.ReadFromJsonAsync<List<HaandvaerkerModel>>();
        }
        

        return Page();

        }

    }
}
