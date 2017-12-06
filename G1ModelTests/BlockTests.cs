using Microsoft.VisualStudio.TestTools.UnitTesting;
using G1Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace G1Model.Tests
{
    [TestClass()]
    public class BlockTests
    {
        [TestMethod()]
        public void GetMatchTest()
        {
            Tournament g1 = TestData2017.Generate();

            for (int x = 0; x < g1.BlockSize; x++)
            {
                Wrestler w1 = g1.BlockA.Wrestlers[x];
                for (int y = 0; y < g1.BlockSize; y++)
                {
                    Wrestler w2 = g1.BlockA.Wrestlers[y];
                    Match m = g1.BlockA.GetMatch(w1, w2);
                    Assert.AreEqual(m, g1.BlockA.Matches[x, y]);
                }
            }

        }
    }
}