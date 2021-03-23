using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.Vaerktoej
{
    public class DeleteModel : PageModel
    {

        public VaerktoejModel localModel { get; set; }
        public HttpClient client { get; set; }

        public DeleteModel(HttpClient client)
        {
            this.client = client;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            
                //client.BaseAddress = new Uri("https://localhost:44376/api");

                string reqq = "/Vaerktoej/" + localModel.VTId.ToString();

                var response = client.GetAsync(reqq);

                var json = await response.Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<VaerktoejModel>(json);

                localModel = result;

                if (localModel == null)
                {
                    return RedirectToPage("/Vaerktoej/Index");
                }

            

            return Page();

        }

        public async Task<IActionResult> OnDelete()
        {
            
                //client.BaseAddress = new Uri("https://localhost:44376/api");

                string reqq = "/Vaerktoej/" + localModel.VTId.ToString();

                var response = client.DeleteAsync(reqq);

                var json = await response.Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<VaerktoejModel>(json);

                localModel = result;

                if (localModel == null)
                {
                    return RedirectToPage("/Vaerktoej/Index");
                }

            

            return Page();
        }
    }
}
