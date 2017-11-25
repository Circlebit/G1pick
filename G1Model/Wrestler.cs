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

        public void EnterMatchResult(Match, Result result)
        {
            
        }

        public void CalcPoints()
        {
             
        }

    }
}
