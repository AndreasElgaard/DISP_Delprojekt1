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

namespace Frontend_Project.Pages.VaerktoejsKasse
{
    public class EditModel : PageModel
    {
        public VaerktoejsKasseModel LocalModel { get; set; }
        public HttpClient client { get; set; }

        public EditModel(HttpClient client)
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

                LocalModel = result;

                if (LocalModel == null)
                {
                    return RedirectToPage("/VaerktoejsKasse/Index");
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
            
                client.BaseAddress = new Uri("https://localhost:44376");

                string reqq = "/api/VaerktoejsKasse/" + LocalModel.VTKId.ToString();

                var response = client.PutAsync(reqq, content);

                if (response.Result.StatusCode != HttpStatusCode.OK)
                {
                    return Page();
                }
            

            return RedirectToPage("/VaerktoejsKasse/Index");
        }
    }
}

