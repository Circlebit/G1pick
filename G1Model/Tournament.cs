using System;

namespace G1Model
{
    public class Tournament
    {
        public int BlockSize { get; }


        public Tournament(int blocksize = 10)
        {
            BlockSize = blocksize;
            var BlockA = new Wrestler[BlockSize];
            var BlockB = new Wrestler[BlockSize];

        }

    }

    public class Block
    {
        public Match[] Matches { get; set; }

        public Block(int blocksize)
        {
            var Wrestlers = new Wrestler[blocksize];
        }
    }

}