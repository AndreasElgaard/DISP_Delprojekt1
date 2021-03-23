using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public VaerktoejsKasseModel localModel { get; set; }
        public HttpClient client { get; set; }

        public DetailsModel(HttpClient client)
        {
            this.client = client;
        }
        public async Task<IActionResult> OnGet(int id)
        {
            
            //client.BaseAddress = new Uri("https://localhost:44376/");

            string reqq = "api/VaerktoejsKasse/" + id.ToString();

            var response = await client.GetAsync(reqq);

            response.EnsureSuccessStatusCode();
            //LocalModels = client.GetFromJsonAsync<HaandvaerkerModel>("http://localhost:44376/api/Haandvaerker");

            if (response.IsSuccessStatusCode)
            {
                localModel = await response.Content.ReadFromJsonAsync<VaerktoejsKasseModel>();
            }
            if (localModel == null)
             {
                 return RedirectToPage("/VaerktoejsKasse/Index");
             }

            

            return Page();

        }
    }
}
