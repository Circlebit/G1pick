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

        public int Points { get; private set; }
        //{
        //    get { return CalcPoints(); } // when the input of match results is implemented
        //}                                // this should be changed so that the Points are only calculated when results are changed

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

        public void CalcPoints()
        {
            if (Matches != null)
            {
                int points = 0;
                foreach (Match match in Matches)
                {
                    points += (int)(match.MatchContenders.Single(mc => mc.Wrestler == this).Result ?? 0);
                }
                Points = points;
            }
            //return points;
        }
    }
}
