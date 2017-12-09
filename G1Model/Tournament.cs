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

        public Tournament(int blocksize = 10)
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
                        Matches[x, y].MatchContenders = new MatchContender[] { new MatchContender(Wrestlers[x]), new MatchContender(Wrestlers[y])};
                    }
                    else // lower part of the table
                    {
                        Matches[x, y] = Matches[y, x];
                    }
                }
            }
        }

        /// <summary>
        /// Returns the Match object from Matches[] of the match of two given wrestlers of a Block
        /// </summary>
        /// <param name="wrestler1"></param>
        /// <param name="wrestler2"></param>
        /// <returns></returns>
        public Match GetMatch(Wrestler wrestler1, Wrestler wrestler2)
        {
            int x = 0;
            while (x < Blocksize)
            {
                if (Wrestlers[x] == wrestler1)
                {
                    break;
                }
                x++;
            }

            int y = 0;
            while (y < Blocksize)
            {
                if (Wrestlers[y] == wrestler2)
                {
                    break;
                }
                y++;
            }

            return Matches[x,y];
        }

        public int GetWrestlerPoints(Wrestler wrestler)
        {
            int points = 0;
            int x = 0;
            while (x < Blocksize)
            {
                if (Wrestlers[x] == wrestler)
                {
                    break;
                }
                x++;
            }

            for (int y = 0; y < Blocksize; y++)
            {
                if (Matches[x, y] != null)
                {
                    points += (int)Matches[x, y].MatchContenders[1].Result;
                }
            }
            return points;
        }

    }
}