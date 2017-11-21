using System;
using System.Collections.ObjectModel;

namespace G1Model
{
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
        public Collection<Wrestler> Wrestlers { get; set; }
        public Match[] Matches { get; set; }
        

        public Block(int blocksize)
        {
            Wrestlers = new Collection<Wrestler>();
            for (int i = 0; i < blocksize; i++)
            {
                Wrestlers.Add(new Wrestler(null));
            }
        }

    }

}