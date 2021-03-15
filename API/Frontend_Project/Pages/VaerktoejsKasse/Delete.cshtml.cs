using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class DeleteModel : PageModel
    {

        public VaerktoejsKasseModel localModel { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000");

                string reqq = "/VaerktoejsKasse/" + localModel.id.ToString();

                var response = client.GetAsync(reqq);

                var json = await response.Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<VaerktoejsKasseModel>(json);

                localModel = result;

                if (localModel == null)
                {
                    return RedirectToPage("/Index");
                }

            }

            return Page();

        }

        public async Task<IActionResult> OnDelete()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44376");

                string reqq = "/VaerktoejsKasse" + localModel.id.ToString();

                var response = client.DeleteAsync(reqq);

                var json = await response.Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<VaerktoejsKasseModel>(json);

                localModel = result;

                if (localModel == null)
                {
                    return RedirectToPage("/Index");
                }

            }

            return Page();
        }
    }
}
