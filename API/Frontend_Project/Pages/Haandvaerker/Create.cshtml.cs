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
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //Lav modellen om til en JSON string
            string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            var content = new StringContent(jsonObjekt, Encoding.UTF8,"application/json");

            //Post modellen til API'et
            
            client.BaseAddress = new Uri("https://localhost:44376");


            var response = await client.PostAsync("/api/Haandvaerker", content);

            response.EnsureSuccessStatusCode();

            if (!response.IsSuccessStatusCode)
            {
                return Page();
            }
              
            return RedirectToPage("/Haandvaerker/Index");
        }

    }
}
