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

        public IndexModel()
        {
            LocalModels = new List<VaerktoejModel>();
        }
        

        public async Task OnGet()
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44376");

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
}
