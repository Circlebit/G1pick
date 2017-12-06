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

            //g1_2017.BlockA.Matches[0, 1].MatchContenders[0].Result = Result.Win;


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

            return g1_2017;
        }
    }
}
