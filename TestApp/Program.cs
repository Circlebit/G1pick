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
            PrintMatchTable(t);

            t.BlockA.Matches[0, 1].Wrestlers[0].Name = "XXX";
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
                        Console.Write(" " + t.BlockA.Matches[x, y].Wrestlers[0].Name.ToString() + "vs" + t.BlockA.Matches[x, y].Wrestlers[1].Name.ToString() + " ");
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
