using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace G1Model
{
    public class Tournament
    {
        public int BlockSize { get; }
        public Block BlockA { get; set; }
        public Block BlockB { get; set; }


        public Tournament(int blocksize = 5)
        {
            BlockSize = blocksize;
            BlockA = new Block(blocksize);
            BlockB = new Block(blocksize);

            BlockA.Wrestlers[0] = new Wrestler("AAA");
            BlockA.Wrestlers[1] = new Wrestler("BBB");
            BlockA.Wrestlers[2] = new Wrestler("CCC");
            BlockA.Wrestlers[3] = new Wrestler("DDD");
            BlockA.Wrestlers[4] = new Wrestler("EEE");

            BlockB.Wrestlers[0] = new Wrestler("111");
            BlockB.Wrestlers[1] = new Wrestler("222");
            BlockB.Wrestlers[2] = new Wrestler("333");
            BlockB.Wrestlers[3] = new Wrestler("444");
            BlockB.Wrestlers[4] = new Wrestler("555");


        }

    }


    public class Block
    {
        public Wrestler[] Wrestlers { get; set; }
        public Match[,] Matches { get; set; }
        

        public Block(int blocksize)
        {
            Wrestlers = new Wrestler[blocksize];
            Matches = new Match[blocksize,blocksize];

            foreach (var wrestler in Wrestlers)
            {
                Debug.WriteLine(wrestler.Name);
            }
        }

        public void GenerateMatches()
        {

        }

    }

}