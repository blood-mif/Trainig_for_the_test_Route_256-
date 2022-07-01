using System;
using System.Collections.Generic;
using System.Linq;

namespace E.Отчет
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                Console.ReadLine();
                int[] tasks = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                bool flag = true;
                int prev = -1;
                HashSet<int> doTask = new HashSet<int>();

                for (int j = 0; j < tasks.Length; ++j)
                {
                    if (prev != tasks[j] && doTask.Contains(tasks[j]))
                        flag = false;

                    prev = tasks[j];
                    doTask.Add(tasks[j]);
                }

                if (flag)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}