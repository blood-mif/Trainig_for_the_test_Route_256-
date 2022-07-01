using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace H.Валидация_карты
{
    public class h
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                int[] dim = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                int y = dim[0];
                int x = dim[1];

                HashSet<Point> visited = new HashSet<Point>();
                Dictionary<Point, List<Point>> graph = new Dictionary<Point, List<Point>>();
                Dictionary<Point, int> vertColor = new Dictionary<Point, int>();

                bool[] visitedColor = new bool[28];

                for (int j = 0; j < y; ++j)
                {
                    string row = Console.ReadLine().Replace(".", "");

                    for (int k = 0; k < row.Length; ++k)
                    {
                        vertColor.Add(new Point(k, j), row[k] - 'A');
                        graph.Add(new Point(k, j), new List<Point>());
                    }

                    for (int k = 0; k < row.Length - 1; ++k)
                    {
                        graph[new Point(k, j)].Add(new Point(k + 1, j));
                    }

                    if (j != y - 1)
                    {
                        if (j % 2 == 0)
                        {
                            graph[new Point(0, j)].Add(new Point(0, j + 1));
                            for (int k = 1; k < row.Length - 1; ++k)
                            {
                                graph[new Point(k, j)].Add(new Point(k - 1, j + 1));
                                graph[new Point(k, j)].Add(new Point(k, j + 1));
                            }

                            if (row.Length != 1)
                            {
                                graph[new Point(row.Length - 1, j)].Add(new Point(row.Length - 2, j + 1));

                                if (x % 2 == 0)
                                    graph[new Point(row.Length - 1, j)].Add(new Point(row.Length - 1, j + 1));
                            }
                        }
                        else
                        {
                            for (int k = 0; k < row.Length - 1; ++k)
                            {
                                graph[new Point(k, j)].Add(new Point(k, j + 1));
                                graph[new Point(k, j)].Add(new Point(k + 1, j + 1));
                            }

                            graph[new Point(row.Length - 1, j)].Add(new Point(row.Length - 1, j + 1));

                            if (x % 2 == 1)
                                graph[new Point(row.Length - 1, j)].Add(new Point(row.Length, j + 1));
                        }
                    }
                }

                foreach (var l in graph)
                {
                    foreach (var n in l.Value)
                    {
                        graph[n].Add(l.Key);
                    }
                }

                bool flag = true;
                foreach (var v in graph)
                {
                    if (!visited.Contains(v.Key) && visitedColor[vertColor[v.Key]])
                    {
                        flag = false;
                    }

                    DFS(graph, v.Key, visited, vertColor);
                    visitedColor[vertColor[v.Key]] = true;
                }

                if (flag)
                    Console.WriteLine("YES");
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        public static void DFS(Dictionary<Point, List<Point>> graph, Point curr, HashSet<Point> visited,
            Dictionary<Point, int> vertColor)
        {
            if (visited.Contains(curr))
                return;

            visited.Add(curr);

            foreach (var l in graph[curr])
            {
                if (vertColor[l] == vertColor[curr])
                    DFS(graph, l, visited, vertColor);
            }
        }
    }
}