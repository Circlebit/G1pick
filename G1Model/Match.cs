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
        public Wrestler Winner { get; set; }
        public Wrestler Looser { get; set; }

        public Match()
        {
            Wrestlers = new Wrestler[2];
            Wrestlers[0] = new Wrestler("NoName");
            Wrestlers[1] = new Wrestler("NoName");
        }
        public Match(Wrestler wrestler1, Wrestler wrestler2)
        {
            Wrestlers = new Wrestler[] { wrestler1, wrestler2 };
        }
    }
}
