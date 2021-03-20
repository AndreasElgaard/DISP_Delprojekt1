using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Frontend_Project.Pages.Haandvaerker
{
    public class CreateModel : PageModel
    {
        
        public HttpClient client { get; set; }
        [BindProperty]
        public int localID { get; set; }
        public CreateModel(HttpClient client)
        {
            this.client = client;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        
        [BindProperty]
        public HaandvaerkerModel LocalModel { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            if (localID != null)
            {
                client.BaseAddress = new Uri("https://localhost:44376");

                string reqG = "/api/VaerktoejsKasse/" + localID.ToString();

                var responseVKT = await client.GetAsync(reqG);

                responseVKT.EnsureSuccessStatusCode();

                var locVTK = await responseVKT.Content.ReadFromJsonAsync<VaerktoejsKasseModel>();
                
                LocalModel.vaerktoejskasse = new HashSet<VaerktoejsKasseModel>();
                
                LocalModel.vaerktoejskasse.Add(locVTK);
            }

            LocalModel.haandvaerkerId = 0;

            //Lav modellen om til en JSON string
            string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            var content = new StringContent(jsonObjekt, Encoding.UTF8,"application/json");


            //Post modellen til API'et
            var response = await client.PostAsJsonAsync("/api/Haandvaerker", content);

            response.EnsureSuccessStatusCode();

            if (!response.IsSuccessStatusCode)
            {
                return Page();
            }

            var responseGet = await client.GetAsync("api/Haandvaerker");

            response.EnsureSuccessStatusCode();
            //LocalModels = client.GetFromJsonAsync<HaandvaerkerModel>("http://localhost:44376/api/Haandvaerker");

            var localList = new List<HaandvaerkerModel>();

            if (response.IsSuccessStatusCode)
            {
                localList = await responseGet.Content.ReadFromJsonAsync<List<HaandvaerkerModel>>();
            }

            LocalModel.haandvaerkerId = localList.Last().haandvaerkerId;

            string jsonObjektPut = JsonSerializer.Serialize(LocalModel);
            var contentPut = new StringContent(jsonObjektPut, Encoding.UTF8, "application/json");

            //Post modellen til API'et

            //client.BaseAddress = new Uri("https://localhost:44376/");

            string reqq = "api/Haandvaerker/" + LocalModel.haandvaerkerId.ToString();

            var responsePut = await client.PutAsync(reqq, contentPut);

            responsePut.EnsureSuccessStatusCode();

            return RedirectToPage("/Haandvaerker/Index");
        }

    }
}
