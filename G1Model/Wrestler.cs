using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace G1Model
{

    public class Wrestler
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public Collection<Match> Matches { get; set; }

        
        public Wrestler(string name)
        {
            Name = name;
            Points = 0;
        }

        public void EnterMatchResult(Match match, Result result)
        {
            // does this belong here? - implement score system first!
        }

        public void CalcPoints()
        {
             // go through each match in Matches
             // get points
             // return sum
        }

    }
}
