using System;
using System.Collections.Generic;
using System.Linq;

namespace Электронная_таблица_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                Console.ReadLine();
                var d = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                int h = d[0];
                int w = d[1];

                int[][] table = new int[h][];

                for (int j = 0; j < h; ++j)
                {
                    table[j] = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                }

                Console.ReadLine();
                var clicks = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();

                for (int j = 0; j < clicks.Length; ++j)
                {
                    table = Sort(table, clicks[j] - 1);
                }

                for (int j = 0; j < h; ++j)
                {
                    for (int k = 0; k < w; ++k)
                    {
                        Console.Write(table[j][k] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }

        static int[][] Sort(int[][] arr, int col)
        {
            int[][] newTable = new int[arr.Length][];

            var res = arr.OrderBy(row => row[col]);

            int i = 0;
            foreach (var r in res)
            {
                newTable[i] = r;
                ++i;
            }

            return newTable;
        }
    }
}