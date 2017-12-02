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
        public MatchContender[] MatchContenders { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Length { get; set; }

        public Match()
        {
            MatchContenders = new MatchContender[2];
            Length = new TimeSpan();
        }

        public Match(Wrestler wrestler1, Wrestler wrestler2)
        {
            MatchContenders = new MatchContender[] { new MatchContender(wrestler1), new MatchContender(wrestler2) };
        }
    }

    public class MatchContender
    {
        public Wrestler Wrestler { get; set; }
        public Result? Result { get; set; }

        public string Name
        {
            get { return Wrestler.Name; }
            set { Wrestler.Name = value; }
        }

        public MatchContender(Wrestler wrestler)
        {
            Wrestler = wrestler;
            Result = null;
        }
    }
}
