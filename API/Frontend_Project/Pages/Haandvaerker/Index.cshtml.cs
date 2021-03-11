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

namespace Frontend_Project.Pages.Haandvaerker
{
    public class IndexModel : PageModel
    {
        public List<HaandvaerkerModel> LocalModels { get; set; }

        public IndexModel()
        {
            LocalModels = new List<HaandvaerkerModel>();
        }
        

        public async Task OnGet()
        {
            //var dd = new DateTime(2020, 09, 12);
            //var d1 = new DateTime(2020, 09, 11);
            //HaandvaerkerModel m1 = new HaandvaerkerModel()
            //{
            //    Ans�ttelsesdato = dd,
            //    Fornavn = "Mark",
            //    Efternavn = "Hansen",
            //    ID = 1234,
            //    Fagomr�de = "Igenei�r"
            //};
            //HaandvaerkerModel m2 = new HaandvaerkerModel()
            //{
            //    Ans�ttelsesdato = d1,
            //    Fornavn = "Dres",
            //    Efternavn = "Elgaard",
            //    ID = 1235,
            //    Fagomr�de = "Maler"
            //};
            //HaandvaerkerModel m3 = new HaandvaerkerModel()
            //{
            //    Ans�ttelsesdato = dd,
            //    Fornavn = "Mads",
            //    Efternavn = "J�rgenj�rgensen",
            //    ID = 1236,
            //    Fagomr�de = "Toiletrenser"
            //};
            //LocalModels.Add(m1);
            //LocalModels.Add(m2);
            //LocalModels.Add(m3);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000");

                var response = client.GetAsync("/Haandvaerker");

                if (response.Result.StatusCode != HttpStatusCode.OK)
                {

                }

                var json = await response.Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<HaandvaerkerModel>>(json);

                LocalModels = result;

            }
        }

    }
}
