using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace G1Model
{

    public class Wrestler
    {
        public string Name { get; set; }

        public int Points
        {
            get { return CalcPoints(); }
        }

        public Collection<Match> Matches { get; set; }
        public Guid InstanceID { get; private set; }

        public Wrestler(string name)
        {
            Name = name;
            Matches = new Collection<Match>();
            InstanceID = Guid.NewGuid();
        }

        //public void EnterMatchResult(Match match, Result result)
        //{
        //    // does this belong here? - implement score system first!
        //}

        private int CalcPoints()
        {
            int points = 0;
            foreach (Match match in Matches)
            {
                points += (int)match.MatchContenders.Single(mc => mc.Wrestler == this).Result;
            }
            return points;
        }
    }
}
