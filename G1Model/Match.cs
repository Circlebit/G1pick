using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1Model
{
    public class Match
    {
        public Wrestler[] Wrestlers { get; set; }
        public int[] Results { get; set; } // - Results in the same order as in Wrestlers would work, but is not defensive
                                           // other options:
                                           // - MatchResult Object that holds a link to the wrestler with the result
                                           // - or somehow add a property to the wrestler that corresponds to the Match-Object? Bad idea maybe?
                                           // - or save Winner / Looser and have a convetion that both being winner means draw (see comment below)
        //public Wrestler Winner { get; set; }
        //public Wrestler Looser { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Length { get; set; }

        public Match()
        {
            Wrestlers = new Wrestler[2];
            Length = new TimeSpan();
        }

        public Match(Wrestler wrestler1, Wrestler wrestler2)
        {
            Wrestlers = new Wrestler[] { wrestler1, wrestler2 };
        }
    }
}
