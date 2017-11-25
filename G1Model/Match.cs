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
        public DateTime Date { get; set; }
        //public Wrestler Winner { get; set; }
        //public Wrestler Looser { get; set; }
        // wie das ergebnis gut implementieren. Gut verständlich und sinnvoll weiterverarbeitbar
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
