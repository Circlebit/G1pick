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
            G1 = new Tournament(10);

            G1.BlockA.Wrestlers = new Wrestler[] {
                new Wrestler("AAA"),
                new Wrestler("BBB"),
                new Wrestler("CCC"),
                new Wrestler("DDD"),
                new Wrestler("EEE"),
                new Wrestler("FFF"),
                new Wrestler("GGG"),
                new Wrestler("HHH"),
                new Wrestler("III"),
                new Wrestler("JJJ")
            };
            G1.BlockA.GenerateMatches();


            //G1.BlockB.Wrestlers = new Wrestler[] { new Wrestler("QQQ"), new Wrestler("WWW"), new Wrestler("XXX"), new Wrestler("YYY"), new Wrestler("ZZZ") };
            //G1.BlockB.GenerateMatches();
        }
    }
}
