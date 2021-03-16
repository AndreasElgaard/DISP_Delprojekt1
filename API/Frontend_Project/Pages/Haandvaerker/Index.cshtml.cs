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

            //var dd = new DateTime(2020, 09, 12);
            //var d1 = new DateTime(2020, 09, 11);
            //HaandvaerkerModel m1 = new HaandvaerkerModel()
            //{
            //    Ansættelsesdato = dd,
            //    Fornavn = "Mark",
            //    Efternavn = "Hansen",
            //    ID = 1234,
            //    Fagområde = "Igeneiør"
            //};
            //HaandvaerkerModel m2 = new HaandvaerkerModel()
            //{
            //    Ansættelsesdato = d1,
            //    Fornavn = "Dres",
            //    Efternavn = "Elgaard",
            //    ID = 1235,
            //    Fagområde = "Maler"
            //};
            //HaandvaerkerModel m3 = new HaandvaerkerModel()
            //{
            //    Ansættelsesdato = dd,
            //    Fornavn = "Mads",
            //    Efternavn = "Jørgenjørgensen",
            //    ID = 1236,
            //    Fagområde = "Toiletrenser"
            //};
            //LocalModels.Add(m1);
            //LocalModels.Add(m2);
            //LocalModels.Add(m3);


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
