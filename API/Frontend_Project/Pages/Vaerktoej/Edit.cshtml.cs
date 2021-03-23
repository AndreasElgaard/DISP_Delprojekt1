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

namespace Frontend_Project.Pages.Vaerktoej
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public VaerktoejModel LocalModel { get; set; }
        public HttpClient client { get; set; }

        public EditModel(HttpClient client)
        {
            this.client = client;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            
            //client.BaseAddress = new Uri("https://localhost:44376/");

            string reqq = "api/Vearktoej/" + id.ToString();

            var response = await client.GetAsync(reqq);

            response.EnsureSuccessStatusCode();
            
            if (response.IsSuccessStatusCode)
            {
                LocalModel = await response.Content.ReadFromJsonAsync<VaerktoejModel>();
            }


            if (LocalModel == null)
            {
                return RedirectToPage("/Vearktoej/Index");
            }

            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //Lav modellen om til en JSON string
            string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            var content = new StringContent(jsonObjekt, Encoding.UTF8, "application/json");

            //Post modellen til API'et
            
                //client.BaseAddress = new Uri("https://localhost:44376/");

                string reqq = "api/Vearktoej/" + LocalModel.VTId.ToString();

                var response = await client.PutAsync(reqq, content);

                response.EnsureSuccessStatusCode();

                if (!response.IsSuccessStatusCode)
                {
                    return Page();
                }
            

            return RedirectToPage("/Vearktoej/Index");
        }
    }
}

