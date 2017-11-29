using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace G1Model
{
    public enum Result { Win = 2, Draw = 1, Loss = 0 }


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

        /// <summary>
        /// populates the Match objects in the 2d-array Matches with the wrestlers from the array Wrestlers.
        /// </summary>
        public void GenerateMatches()
        {
            for (int x = 0; x < Blocksize; x++)
            {
                for (int y = 0; y < Blocksize; y++)
                {
                    if (x == y) // diagonale
                    {
                        Matches[x, y] = null;
                    }
                    else if( x > y ) // upper part of the table
                    {
                        Matches[x, y].Wrestlers[0] = Wrestlers[x];
                        Matches[x, y].Wrestlers[1] = Wrestlers[y];
                    }
                    else // lower part of the table
                    {
                        Matches[x, y] = Matches[y, x];
                    }
                }
            }
        }

    }
}