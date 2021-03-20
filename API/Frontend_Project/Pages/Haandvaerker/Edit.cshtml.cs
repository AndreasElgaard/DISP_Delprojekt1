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
    public class EditModel : PageModel
    {
        [BindProperty]
        public HaandvaerkerModel localModel { get; set; }
        public HttpClient client { get; set; }

        public EditModel(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            
            client.BaseAddress = new Uri("https://localhost:44376/");

            string reqq = "api/Haandvaerker/" + id.ToString();

            var response = await client.GetAsync(reqq);

            response.EnsureSuccessStatusCode();
            //LocalModels = client.GetFromJsonAsync<HaandvaerkerModel>("http://localhost:44376/api/Haandvaerker");

            if (response.IsSuccessStatusCode)
            {
                localModel = await response.Content.ReadFromJsonAsync<HaandvaerkerModel>();
            }


            if (localModel == null)
            {
                return RedirectToPage("/Haandvaerker/Index");
            }

            return Page();

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //Lav modellen om til en JSON string
            string jsonObjekt = JsonSerializer.Serialize(localModel);
            var content = new StringContent(jsonObjekt, Encoding.UTF8, "application/json");

            //Post modellen til API'et
            
                client.BaseAddress = new Uri("https://localhost:44376/");

                string reqq = "api/Haandvaerker/" + localModel.haandvaerkerId.ToString();

                var response = await client.PutAsync(reqq, content);

                response.EnsureSuccessStatusCode();

                if (!response.IsSuccessStatusCode)
                {
                    return Page();
                }
            

            return RedirectToPage("/Haandvaerker/Index");
        }
    }
}

