using System;
using System.Collections.Generic;
using System.Linq;

namespace B.Парное_программирование
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                Console.ReadLine();
                int[] power = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();

                HashSet<int> inPair = new HashSet<int>();
                Dictionary<int, int> pair = new Dictionary<int, int>();

                for (int j = 0; j < power.Length; ++j)
                {
                    if (!inPair.Contains(j))
                    {
                        int best = -1;

                        for (int k = j + 1; k < power.Length; ++k)
                        {
                            if (!inPair.Contains(k))
                            {
                                if (best == -1)
                                    best = k;

                                if (Math.Abs(power[j] - power[best]) > Math.Abs(power[j] - power[k]))
                                {
                                    best = k;
                                }
                            }
                        }

                        inPair.Add(best);
                        inPair.Add(j);
                        pair.Add(j, best);
                    }
                }

                foreach (var p in pair)
                {
                    Console.WriteLine((p.Key + 1) + " " + (p.Value + 1));
                }

                Console.WriteLine();
            }
        }
    }
}