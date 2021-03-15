using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public VaerktoejModel LocalModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44376");

                string reqq = "/Vaerktoej" + LocalModel.id.ToString();

                var response = client.GetAsync(reqq);

                var json = await response.Result.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<VaerktoejModel>(json);

                LocalModel = result;

                if (LocalModel == null)
                {
                    return RedirectToPage("/Index");
                }

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
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3000");

                string reqq = "/Vaerktoej/" + LocalModel.id.ToString();

                var response = client.PutAsync(reqq, content);

                if (response.Result.StatusCode != HttpStatusCode.OK)
                {
                    return Page();
                }
            }

            return RedirectToPage("/Index");
        }
    }
}
