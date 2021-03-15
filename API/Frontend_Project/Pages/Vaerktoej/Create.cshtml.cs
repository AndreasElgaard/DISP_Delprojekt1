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
    public class CreateModel : PageModel
    {
        public VaerktoejModel LocalModel { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //Lav modellen om til en JSON string
            string jsonObjekt = JsonSerializer.Serialize(LocalModel);
            var content = new StringContent(jsonObjekt, Encoding.UTF8,"application/json");

            //Post modellen til API'et
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44376");


                var response = client.PutAsync("/Vaerktoej", content);

                if (response.Result.StatusCode != HttpStatusCode.OK)
                {
                    return Page();
                }
            }

            return RedirectToPage("/Index");
        }

    }
}
