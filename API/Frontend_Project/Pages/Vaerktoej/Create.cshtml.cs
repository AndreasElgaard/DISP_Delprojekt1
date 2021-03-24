using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using API.Controllers.Requests;
using API.Controllers.Responses;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Frontend_Project.Pages.Vaerktoej
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public VaerkToejRequest LocalModel { get; set; }
        [BindProperty]
        public string SerieNummer { get; set; }

        public VaerktoejsKasseResponse vaerktoejsKasseResponse { get; set; }

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
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            client.BaseAddress = new Uri("http://swtdisp-grp10-backend-service:80/");

            var reqq = "api/Vaerktoejskasse/GetBySerieNummer/" + SerieNummer;

            var response = await client.GetAsync(reqq);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                vaerktoejsKasseResponse = await response.Content.ReadFromJsonAsync<VaerktoejsKasseResponse>();
            }

            LocalModel.VaerktoejskasseId = vaerktoejsKasseResponse.VTKId;

            string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            var c = new StringContent(jsonObjekt, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://swtdisp-grp10-backend-service:80/api/Vaerktoej"),
                Content = c
            };

            var responsePost = await client.SendAsync(request);

            responsePost.EnsureSuccessStatusCode();

            return RedirectToPage("/Vaerktoej/Index");
        }
    }
}
