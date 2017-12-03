using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using G1Model;

namespace G1Web1.Pages
{
    public class IndexModel : PageModel
    {
        public Tournament G1 { get; set; }

        public void OnGet()
        {
            G1 = TestData2017.Generate();
        }
    }
}
