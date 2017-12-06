using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1Model
{
    public static class TestData2017
    {
        public static Tournament Generate()
        {
            Tournament g1_2017 = new Tournament(10);
            g1_2017.BlockA.Wrestlers = new Wrestler[] {
                new Wrestler("Fale"),
                new Wrestler("Goto"),
                new Wrestler("Ibushi"),
                new Wrestler("Ishii"),
                new Wrestler("Makabe"),
                new Wrestler("Nagata"),
                new Wrestler("Naito"),
                new Wrestler("Sabre"),
                new Wrestler("Tanahashi"),
                new Wrestler("Yoshi-Hashi")};
            g1_2017.BlockA.GenerateMatches();

            g1_2017.BlockB.Wrestlers = new Wrestler[] {
                new Wrestler("Elgin"),
                new Wrestler("Evil"),
                new Wrestler("Kojima"),
                new Wrestler("Okada"),
                new Wrestler("Omega"),
                new Wrestler("Robinson"),
                new Wrestler("Sanada"),
                new Wrestler("Suzuki"),
                new Wrestler("Tonga"),
                new Wrestler("Yano")};
            g1_2017.BlockB.GenerateMatches();

            EnterResults2017(g1_2017);

            return g1_2017;
        }

        private static void EnterResults2017(Tournament g1_2017)
        {
            // Row 0 - Fale
            g1_2017.BlockA.Matches[0, 1].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[0, 2].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[0, 3].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[0, 4].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[0, 5].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[0, 6].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[0, 7].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[0, 8].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[0, 9].MatchContenders[1].Result = Result.Loss;

            // Row 1 - Goto
            g1_2017.BlockA.Matches[1, 2].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[1, 3].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[1, 4].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[1, 5].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[1, 6].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[1, 7].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[1, 8].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[1, 9].MatchContenders[1].Result = Result.Win;

            // Row 2 - Ibushi
            g1_2017.BlockA.Matches[2, 3].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[2, 4].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[2, 5].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[2, 6].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[2, 7].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[2, 8].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[2, 9].MatchContenders[1].Result = Result.Win;

            // Row 3 - Ishii
            g1_2017.BlockA.Matches[3, 4].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[3, 5].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[3, 6].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[3, 7].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[3, 8].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[3, 9].MatchContenders[1].Result = Result.Win;

            // Row 4 - Makabe
            g1_2017.BlockA.Matches[4, 5].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[4, 6].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[4, 7].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[4, 8].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[4, 9].MatchContenders[1].Result = Result.Win;

            // Row 5 - Nagata
            g1_2017.BlockA.Matches[5, 6].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[5, 7].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[5, 8].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[5, 9].MatchContenders[1].Result = Result.Loss;

            // Row 6 - Naito
            g1_2017.BlockA.Matches[6, 7].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[6, 8].MatchContenders[1].Result = Result.Loss;
            g1_2017.BlockA.Matches[6, 9].MatchContenders[1].Result = Result.Loss;

            // Row 7 - Sabre
            g1_2017.BlockA.Matches[7, 8].MatchContenders[1].Result = Result.Win;
            g1_2017.BlockA.Matches[7, 9].MatchContenders[1].Result = Result.Win;

            // Row 8 - Tanahashi
            g1_2017.BlockA.Matches[8, 9].MatchContenders[1].Result = Result.Win;

            EnterResultForOtherContender(g1_2017);
        }

        private static void EnterResultForOtherContender(Tournament t)
        {
            foreach (Block block in new Block[] { t.BlockA, t.BlockB })
            {
                for (int x = 0; x < t.BlockSize; x++)
                {
                    for (int y = 0; y < t.BlockSize; y++)
                    {
                        if(block.Matches[x, y] != null)
                        {
                            if(block.Matches[x, y].MatchContenders[0].Result == Result.Win)
                            {
                                block.Matches[x, y].MatchContenders[1].Result = Result.Loss;
                            }
                            else if (block.Matches[x, y].MatchContenders[0].Result == Result.Loss)
                            {
                                block.Matches[x, y].MatchContenders[1].Result = Result.Win;
                            }
                            else if (block.Matches[x, y].MatchContenders[0].Result == Result.Draw)
                            {
                                block.Matches[x, y].MatchContenders[1].Result = Result.Draw;
                            }
                            else if (block.Matches[x, y].MatchContenders[1].Result == Result.Win)
                            {
                                block.Matches[x, y].MatchContenders[0].Result = Result.Loss;
                            }
                            else if (block.Matches[x, y].MatchContenders[1].Result == Result.Loss)
                            {
                                block.Matches[x, y].MatchContenders[0].Result = Result.Win;
                            }
                            else if (block.Matches[x, y].MatchContenders[1].Result == Result.Draw)
                            {
                                block.Matches[x, y].MatchContenders[0].Result = Result.Draw;
                            }
                        }
                        
                    }
                }
            }
        }

    }
}
