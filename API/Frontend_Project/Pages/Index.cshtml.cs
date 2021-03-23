using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace Frontend_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public HttpClient client { get; set; }
        
        public IndexModel(ILogger<IndexModel> logger,HttpClient client)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
