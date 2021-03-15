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

namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class IndexModel : PageModel
    {
        public List<VaerktoejsKasseModel> LocalModels { get; set; }

        public IndexModel()
        {
            LocalModels = new List<VaerktoejsKasseModel>();
        }
        

        public async Task<IActionResult> OnGet()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44376");

                var response = await client.GetAsync("/VaerktoejsKasse");

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    
                }

                var json = await response.Content.ReadAsStringAsync();
                    //Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<VaerktoejsKasseModel>>(json);

                LocalModels = result;
                return Page();
            }
        }

    }
}
