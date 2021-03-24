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

namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public VaerktoejsKasseModel localModel { get; set; }
        public HttpClient client { get; set; }

        public DeleteModel(HttpClient client)
        {
            this.client = client;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {

            client.BaseAddress = new Uri("http://swtdisp-grp10-backend-service:80/");

            string reqq = "api/Vaerktoejskasse/" + id.ToString();

            var response = await client.GetAsync(reqq);

            response.EnsureSuccessStatusCode();

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

        public async Task<IActionResult> OnPost()
        {

            client.BaseAddress = new Uri("http://swtdisp-grp10-backend-service:80/");

            string reqq = "api/Vaerktoejskasse/" + localModel.VTKId.ToString();

            var response = await client.DeleteAsync(reqq);

            response.EnsureSuccessStatusCode();

            return RedirectToPage("/VaerktoejsKasse/Index/");
        }
    }
}
