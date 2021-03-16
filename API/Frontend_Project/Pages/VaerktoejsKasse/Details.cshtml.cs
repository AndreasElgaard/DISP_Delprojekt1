using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class DetailsModel : PageModel
    {
        public VaerktoejsKasseModel localModel { get; set; }
        public HttpClient client { get; set; }

        public DetailsModel(HttpClient client)
        {
            this.client = client;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            
            client.BaseAddress = new Uri("https://localhost:44376");

            string reqq = "/api/VaerktoejsKasse/" + id.ToString();

            var response = client.GetAsync(reqq);

             var json = await response.Result.Content.ReadAsStringAsync();

             var result = JsonSerializer.Deserialize<VaerktoejsKasseModel>(json);

             localModel = result;

             if (localModel == null)
             {
                 return RedirectToPage("/VaerktoejsKasse/Index");
             }

            

            return Page();

        }
    }
}
