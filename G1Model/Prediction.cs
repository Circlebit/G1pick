using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1Model
{
    public class Prediction
    {
        Tournament Tournament { get; set; }
        MatchPrediction[,] MatchPredictionsBlockA { get; set; }
        MatchPrediction[,] MatchPredictionsBlockB { get; set; }


        public Prediction(Tournament tournament)
        {
            Tournament Tournament = tournament;
            MatchPredictionsBlockA = new MatchPrediction[Tournament.BlockSize, Tournament.BlockSize];
            MatchPredictionsBlockB = new MatchPrediction[Tournament.BlockSize, Tournament.BlockSize];
            SetupBlockMatchesForPredictions( MatchPredictionsBlockA, Tournament.BlockA );
            SetupBlockMatchesForPredictions( MatchPredictionsBlockB, Tournament.BlockB );
        }

        /// <summary>
        ///     copy matches from Tournament Block into Prediction Block
        /// </summary>
        /// <param name="blockPredicitons"></param>
        /// <param name="tournamentBlock"></param>
        private void SetupBlockMatchesForPredictions(MatchPrediction[,] blockPredicitons, Block tournamentBlock)
        {
            for (int x = 0; x < tournamentBlock.Blocksize; x++)
            {
                for (int y = 0; y < tournamentBlock.Blocksize; y++)
                {
                    blockPredicitons[x, y] = new MatchPrediction(tournamentBlock.Matches[x, y]);
                }
            }
        }
    }

    class MatchPrediction
    {

        public Match Match { get; set; }

        public Result?[] predictionResults;


        public MatchPrediction(Match match)
        {
            Match = match;
            predictionResults = new Result?[] { null, null };
        }

        public Wrestler GetPredictedWinner()
        {
            if (predictionResults[0] == Result.Win)
            {
                return Match.MatchContenders[0].Wrestler;
            }
            else if (predictionResults[1] == Result.Win)
            {
                return Match.MatchContenders[1].Wrestler;
            }
            else
            {
                return null;
            }
        }

        public Wrestler GetPredictedLoser()
        {
            if (predictionResults[0] == Result.Loss)
            {
                return Match.MatchContenders[0].Wrestler;
            }
            else if (predictionResults[1] == Result.Loss)
            {
                return Match.MatchContenders[1].Wrestler;
            }
            else
            {
                return null;
            }
        }

        public void PredictWinner(Wrestler winner)
        {
            if( Match.MatchContenders[0].Wrestler == winner )
            {
                Match.MatchContenders[0].Result = Result.Win;
                Match.MatchContenders[1].Result = Result.Loss;
            }
            else
            {
                Match.MatchContenders[1].Result = Result.Win;
                Match.MatchContenders[0].Result = Result.Loss;
            }
        }

        public void PredictDraw()
        {
            Match.MatchContenders[0].Result = Result.Draw;
            Match.MatchContenders[1].Result = Result.Draw;
        }

    }
}
