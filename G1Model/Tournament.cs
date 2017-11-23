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

            BlockA.GenerateMatches();

            BlockB.Wrestlers[0] = new Wrestler("111");
            BlockB.Wrestlers[1] = new Wrestler("222");
            BlockB.Wrestlers[2] = new Wrestler("333");
            BlockB.Wrestlers[3] = new Wrestler("444");
            BlockB.Wrestlers[4] = new Wrestler("555");


        }

    }


    public class Block
    {
        public int Blocksize { get; }
        public Wrestler[] Wrestlers { get; set; }
        public Match[,] Matches { get; set; }
                

        public Block(int blocksize)
        {
            Blocksize = blocksize;
            Wrestlers = new Wrestler[blocksize];
            Matches = new Match[blocksize,blocksize];

            for (int x = 0; x < Blocksize; x++)
            {
                for (int y = 0; y < Blocksize; y++)
                {
                    Matches[x, y] = new Match();
                }
            }
        }

        public void GenerateMatches()
        {
            for (int x = 0; x < Blocksize; x++)
            {
                for (int y = 0; y < Blocksize; y++)
                {
                    if (x == y)
                    {
                        //Console.WriteLine(x.ToString() + "," + y.ToString());
                        Matches[x, y] = null;
                    }
                    else if( x > y )
                    {
                        
                        // Matches[x, y] = new Match(Wrestlers[x], Wrestlers[y]);
                        Matches[x, y].Wrestlers[0] = Wrestlers[x];
                        Matches[x, y].Wrestlers[1] = Wrestlers[y];

                    }
                    else
                    {
                        Console.WriteLine(x.ToString() + "," + y.ToString());
                        Matches[x, y] = Matches[y, x];
                    }
                }
            }
        }

    }

}