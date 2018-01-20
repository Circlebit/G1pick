using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1Model;
using System.Collections.ObjectModel;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournament g1 = TestData2017.Generate();

            Console.WriteLine($"{g1.BlockA.Wrestlers[0].Name}: {g1.BlockA.Wrestlers[0].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[1].Name}: {g1.BlockA.Wrestlers[1].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[2].Name}: {g1.BlockA.Wrestlers[2].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[3].Name}: {g1.BlockA.Wrestlers[3].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[4].Name}: {g1.BlockA.Wrestlers[4].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[5].Name}: {g1.BlockA.Wrestlers[5].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[6].Name}: {g1.BlockA.Wrestlers[6].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[7].Name}: {g1.BlockA.Wrestlers[7].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[8].Name}: {g1.BlockA.Wrestlers[8].Points}");
            Console.WriteLine($"{g1.BlockA.Wrestlers[9].Name}: {g1.BlockA.Wrestlers[9].Points}");

            var p = new Prediction(g1);

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
                        Console.Write(" " + t.BlockA.Matches[x, y].MatchContenders[0].Name.ToString() + "VS" + t.BlockA.Matches[x, y].MatchContenders[1].Name.ToString() + " \t");
                    }
                    catch
                    {
                        Console.Write("  ------  \t");
                    }
                }
                Console.Write("\n");
            }
        }

    }

}
