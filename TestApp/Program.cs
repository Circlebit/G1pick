using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1Model;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Tournament();

            t.BlockA.Wrestlers[0] = new Wrestler("AAA");
            t.BlockA.Wrestlers[1] = new Wrestler("BBB");
            t.BlockA.Wrestlers[2] = new Wrestler("CCC");
            t.BlockA.Wrestlers[3] = new Wrestler("DDD");
            t.BlockA.Wrestlers[4] = new Wrestler("EEE");

            t.BlockA.GenerateMatches();

            t.BlockB.Wrestlers[0] = new Wrestler("111");
            t.BlockB.Wrestlers[1] = new Wrestler("222");
            t.BlockB.Wrestlers[2] = new Wrestler("333");
            t.BlockB.Wrestlers[3] = new Wrestler("444");
            t.BlockB.Wrestlers[4] = new Wrestler("555");

            t.BlockB.GenerateMatches();


            PrintMatchTable(t);

            t.BlockA.Matches[0, 1].MatchContenders[0].Name = "XXX";
            PrintMatchTable(t);

            var w = new Wrestler("ZZZ");
            t.BlockA.Wrestlers[1] = w;
            t.BlockA.GenerateMatches();
            PrintMatchTable(t);


            Console.ReadLine();
        }


        public static void PrintMatchTable(Tournament t)
        {
            Console.WriteLine();
            for (int x = 0; x < t.BlockSize; x++)
            {
                for (int y = 0; y < t.BlockSize; y++)
                {
                    try
                    {
                        Console.Write(" " + t.BlockA.Matches[x, y].MatchContenders[0].Name.ToString() + "vs" + t.BlockA.Matches[x, y].MatchContenders[1].Name.ToString() + " ");
                    }
                    catch
                    {
                        Console.Write("  ------  ");
                    }
                }
                Console.Write("\n");
            }
        }

    }

}
