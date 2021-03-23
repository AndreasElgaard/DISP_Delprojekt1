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


namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public VaerktoejsKasseRequest LocalModel { get; set; }
        public HttpClient client { get; set; }
        [BindProperty]
        public string HaandvaerkerNavn { get; set; }
        public HaandVaerkerResponse haandvaerker { get; set; }

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

            //client.BaseAddress = new Uri("https://localhost:44376/");

            var reqq = "api/Haandvaerker/GetByName/" + HaandvaerkerNavn;

            var response = await client.GetAsync(reqq);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                haandvaerker = await response.Content.ReadFromJsonAsync<HaandVaerkerResponse>();
            }

            //var localList = new List<VaerktoejModel>();
            var haandvaerkerRequest = new HaandVaerkerRequest
            {
                HVAnsaettelsedato = haandvaerker.HVAnsaettelsedato,
                HVEfternavn = haandvaerker.HVEfternavn,
                HVFagomraade = haandvaerker.HVFagomraade,
                HVFornavn = haandvaerker.HVFornavn,
            };

            LocalModel.Haandvaerker = haandvaerkerRequest;
            LocalModel.HaandvaerkerId = haandvaerker.HaandvaerkerId;
            //LocalModel.Vaerktoej = localList;

            string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            var c = new StringContent(jsonObjekt, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:44376/api/Vaerktoejskasse"),
                Content = c
            };

            var responsePost = await client.SendAsync(request);

            responsePost.EnsureSuccessStatusCode();

            return RedirectToPage("/Vaerktoejskasse/Index");
        }
    }
}
