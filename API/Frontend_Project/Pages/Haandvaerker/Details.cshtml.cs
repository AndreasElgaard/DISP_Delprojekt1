using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using API.Controllers.Responses;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.Haandvaerker
{
    public class DetailsModel : PageModel
    {
        public HaandVaerkerResponse localModel { get; set; }
        public HttpClient client { get; set; }

        public DetailsModel(HttpClient client)
        {
            this.client = client;
        }
        public async Task<IActionResult> OnGet(int id)
        {
            
            //client.BaseAddress = new Uri("https://localhost:44376/");

            string reqq = "api/Haandvaerker/" + id.ToString();

            var response = await client.GetAsync(reqq);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                localModel = await response.Content.ReadFromJsonAsync<HaandVaerkerResponse>();
            }

            if (localModel == null)
            {
                return RedirectToPage("/Haandvaerker/Index");
            }

            return Page();

        }
    }
}
