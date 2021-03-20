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


namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public VaerktoejsKasseModel LocalModel { get; set; }
        public HttpClient client { get; set; }

        public CreateModel(HttpClient client)
        {
            this.client = client;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            //if (ModelState.IsValid == false)
            //{
            //    return Page();
            //}

            ////Lav modellen om til en JSON string
            //string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            //var content = new StringContent(jsonObjekt, Encoding.UTF8,"application/json");

            ////Post modellen til API'et
            
            //   client.BaseAddress = new Uri("https://localhost:44376/api");


            //    var response = client.PutAsync("/VaerktoejsKasse", content);

            //    if (response.Result.StatusCode != HttpStatusCode.OK)
            //    {
            //        return Page();
            //    }
            

            
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //if (localID != null)
            //{
            client.BaseAddress = new Uri("https://localhost:44376");

            //    string reqG = "/api/VaerktoejsKasse/" + localID.ToString();

            //    var responseVKT = await client.GetAsync(reqG);

            //    responseVKT.EnsureSuccessStatusCode();

            //    var locVTK = await responseVKT.Content.ReadFromJsonAsync<VaerktoejsKasseModel>();

            //    LocalModel.vaerktoejskasse = new HashSet<VaerktoejsKasseModel>();

            //    LocalModel.vaerktoejskasse.Add(locVTK);
            //}

            LocalModel.VTKId = 0;

            //Lav modellen om til en JSON string
            string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            var content = new StringContent(jsonObjekt, Encoding.UTF8, "application/json");


            //Post modellen til API'et
            var response = await client.PostAsJsonAsync("/api/Vaerktoejskasse", content);

            response.EnsureSuccessStatusCode();

            if (!response.IsSuccessStatusCode)
            {
                return Page();
            }

            var responseGet = await client.GetAsync("api/Vaerktoejskasse");

            response.EnsureSuccessStatusCode();

            var localList = new List<VaerktoejsKasseModel>();

            if (response.IsSuccessStatusCode)
            {
                localList = await responseGet.Content.ReadFromJsonAsync<List<VaerktoejsKasseModel>>();
            }

            LocalModel.VTKId = localList.Last().VTKId;

            string jsonObjektPut = JsonSerializer.Serialize(LocalModel);
            var contentPut = new StringContent(jsonObjektPut, Encoding.UTF8, "application/json");

            //Post modellen til API'et

            //client.BaseAddress = new Uri("https://localhost:44376/");

            string reqq = "api/Vaerktoejskasse/" + LocalModel.VTKId.ToString();

            var responsePut = await client.PutAsync(reqq, contentPut);

            responsePut.EnsureSuccessStatusCode();

            return RedirectToPage("/Vaerktoejskasse/Index");

        }

    }
}
