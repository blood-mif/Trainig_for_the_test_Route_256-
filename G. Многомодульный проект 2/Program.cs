using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace G.Многомодульный_проект_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                Console.ReadLine();
                int count = Convert.ToInt32(Console.ReadLine());
                Dictionary<String, List<String>> m = new Dictionary<string, List<string>>();

                for (int j = 0; j < count; ++j)
                {
                    String[] modules = Console.ReadLine().ToLower().Replace(":", "").Split(' ');
                    List<String> dep = new List<string>();

                    for (int k = 1; k < modules.Length; ++k)
                        dep.Add(modules[k]);

                    m.Add(modules[0], dep);
                }

                int coutnOrder = Convert.ToInt32(Console.ReadLine());
                HashSet<String> installedModules = new HashSet<string>();

                for (int j = 0; j < coutnOrder; ++j)
                {
                    List<String> order = new List<string>();
                    String module = Console.ReadLine();

                    DFS(module, m, installedModules, order);

                    Console.Write(order.Count + " ");

                    foreach (var mod in order)
                    {
                        Console.Write(mod + " ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }

        static void DFS(String module, Dictionary<String, List<String>> m, HashSet<String> installed,
            List<String> order)
        {
            if (installed.Contains(module))
                return;

            foreach (var d in m[module])
            {
                DFS(d, m, installed, order);
            }

            order.Add(module);
            installed.Add(module);
        }
    }
}
