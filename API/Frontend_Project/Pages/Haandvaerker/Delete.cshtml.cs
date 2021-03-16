using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.Haandvaerker
{
    public class DeleteModel : PageModel
    {
        public HttpClient client { get; set; }
        public DeleteModel(HttpClient client)
        {
            this.client = client;
        }
        public HaandvaerkerModel localModel { get; set; }
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

        public async Task<IActionResult> OnDelete()
        {
            
                client.BaseAddress = new Uri("http://localhost:44376/");

                string reqq = "api/Haandvaerker/" + localModel.HaandvaerkerId.ToString();

                var response = client.DeleteAsync(reqq);

                var json = await response.Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<HaandvaerkerModel>(json);

                localModel = result;

                if (localModel == null)
                {
                    return RedirectToPage("/Haandvaerker/Index");
                }

            

            return Page();
        }
    }
}
