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
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Frontend_Project.Pages.Haandvaerker
{
    public class CreateModel : PageModel
    {
        
        public HttpClient client { get; set; }

        public CreateModel(HttpClient client)
        {
            this.client = client;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        
        [BindProperty]
        public HaandVaerkerRequest LocalModel { get; set; }

        public async Task<IActionResult> OnPost()
        {

            string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            var c = new StringContent(jsonObjekt, Encoding.UTF8,"application/json");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:44376/api/Haandvaerker"),
                Content = c
            };
            
            var response = await client.SendAsync(request);


            response.EnsureSuccessStatusCode();

            return RedirectToPage("/Haandvaerker/Index");
        }

    }
}
