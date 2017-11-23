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

            for (int x = 0; x < t.BlockSize; x++)
            {
                for (int y = 0; y < t.BlockSize; y++)
                {
                    Console.WriteLine(x.ToString() + "," + y.ToString());
                    try
                    {
                        Console.Write(t.BlockA.Matches[x, y].Wrestlers[0].Name.ToString()+"vs"+ t.BlockA.Matches[x, y].Wrestlers[1].Name.ToString());
                    }
                    catch
                    {
                        Console.Write(" [NULL] ");
                    }
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
