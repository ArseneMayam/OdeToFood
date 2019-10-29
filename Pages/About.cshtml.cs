using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFood.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        private readonly IConfiguration config;

        public AboutModel(IConfiguration config) {
            this.config = config;
        }

        public void OnGet()
        {
            // Message = "Your application description page.";
            Message = config["Message"];
        }
    }
}
