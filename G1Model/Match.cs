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
        public Collection<Wrestler> Wrestlers { get; set; }
        public DateTime Date { get; set; }
        public Wrestler Winner { get; set; }
        public Wrestler Looser { get; set; }

        public Match()
        {
            Wrestlers = new Collection<Wrestler>();
        }
    }
}
