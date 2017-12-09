using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1Model
{
    public class Match
    {
        private MatchContender[] _matchContenders;
        public MatchContender[] MatchContenders
        {
            get { return _matchContenders; }
            set
            {
                _matchContenders = value;

                foreach (MatchContender mc in value)
                {
                    if (mc != null)
                    {
                        if (!mc.Wrestler.Matches.Contains<Match>(this))
                        {
                            mc.Wrestler.Matches.Add(this);
                            Debug.WriteLine($"{mc.Name}'s Matchlist adds:\t {this.MatchContenders[0].Name} VS. {this.MatchContenders[1].Name}");
                        }
                    }
                }
            }
        }

        public DateTime Date { get; set; }

        public TimeSpan Length { get; set; }

        // Constructor
        public Match()
        {
            MatchContenders = new MatchContender[2];
            Length = new TimeSpan();
        }

        public Match(Wrestler wrestler1, Wrestler wrestler2)
        {
            MatchContenders = new MatchContender[] { new MatchContender(wrestler1), new MatchContender(wrestler2) };
            wrestler1.Matches.Add(this);
            wrestler2.Matches.Add(this);
        }

        public MatchContender GetWinner()
        {
            if (MatchContenders[0].Result == Result.Win)
            {
                return MatchContenders[0];
            }
            else if (MatchContenders[1].Result == Result.Win)
            {
                return MatchContenders[1];
            }
            else
            {
                return null;
            }
        }

        public MatchContender GetLoser()
        {
            if (MatchContenders[0].Result == Result.Loss)
            {
                return MatchContenders[0];
            }
            else if (MatchContenders[1].Result == Result.Loss)
            {
                return MatchContenders[1];
            }
            else
            {
                return null;
            }
        }
    }

    public class MatchContender
    {
        public Wrestler Wrestler { get; set; }

        //public Result? Result { get; set; }

        private Result? _result;
        public Result? Result
        {
            get { return _result; }
            set
            {
                _result = value;
                Wrestler.CalcPoints();
            }
        }

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
