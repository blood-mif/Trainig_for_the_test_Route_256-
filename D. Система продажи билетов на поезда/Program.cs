using System;
using System.Collections.Generic;
using System.Linq;


namespace D.Система_продажи_билетов_на_поезда
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                Console.ReadLine();
                var arr = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                int n = arr[0];
                int q = arr[1];

                SortedDictionary<int, int> freeCupe = new SortedDictionary<int, int>();
                HashSet<int> freePlace = new HashSet<int>();

                for (int j = 1; j <= n; ++j)
                {
                    freePlace.Add(j * 2 - 1);
                    freePlace.Add(j * 2);

                    freeCupe.Add(j, 0);
                }

                for (int j = 0; j < q; ++j)
                {
                    var req = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                    if (req.Length == 1)
                    {
                        try
                        {
                            var el = freeCupe.First();

                            freePlace.Remove(el.Key * 2 - 1);
                            freePlace.Remove(el.Key * 2);
                            freeCupe.Remove(el.Key);

                            Console.WriteLine("SUCCESS " + (el.Key * 2 - 1) + "-" + el.Key * 2);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("FAIL");
                        }
                    }
                    else
                    {
                        if (req[0] == 1)
                        {
                            if (freePlace.Contains(req[1]))
                            {
                                Console.WriteLine("SUCCESS");
                                freePlace.Remove(req[1]);
                                freeCupe.Remove((req[1] + 1) / 2);
                            }
                            else
                                Console.WriteLine("FAIL");
                        }
                        else
                        {
                            if (!freePlace.Contains(req[1]))
                            {
                                Console.WriteLine("SUCCESS");
                                freePlace.Add(req[1]);
                                int pairPlace = req[1] % 2 == 1 ? req[1] + 1 : req[1] - 1;

                                if (freePlace.Contains(pairPlace))
                                    freeCupe.Add((req[1] + 1) / 2, 0);
                            }
                            else
                                Console.WriteLine("FAIL");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}