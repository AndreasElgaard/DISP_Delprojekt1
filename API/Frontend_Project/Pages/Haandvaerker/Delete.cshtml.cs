using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Project.Datamodels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend_Project.Pages.Haandvaerker
{
    public class DeleteModel : PageModel
    {

        public HaandvaerkerModel localModel { get; set; }
        public void OnGet()
        {
        }

        
    }
}
