using System;
using System.Collections.Generic;

namespace J.Рифмы
{
    public class Node
    {
        public char s;
        public List<Node> next;
    }

    public class j
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            Node tree = new Node();
            tree.next = new List<Node>();

            for (int i = 0; i < t; ++i)
            {
                string word = Console.ReadLine();
                Node curr = tree;

                for (int j = word.Length - 1; j >= 0; --j)
                {
                    Node next = null;
                    foreach (var n in curr.next)
                    {
                        if (n.s == word[j])
                        {
                            next = n;
                            break;
                        }
                    }

                    if (next == null)
                    {
                        next = new Node();
                        next.next = new List<Node>();
                        next.s = word[j];
                        curr.next.Add(next);
                    }

                    curr = next;
                }
            }

            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; ++i)
            {
                string res = "";
                string word = Console.ReadLine();
                Node curr = tree;

                for (int j = word.Length - 1; j >= 0; --j)
                {
                    Node next = null;

                    foreach (var n in curr.next)
                    {
                        if (n.s == word[j])
                        {
                            next = n;
                            res += n.s;
                            break;
                        }
                    }

                    if (next == null)
                    {
                        break;
                    }
                    else
                    {
                        curr = next;
                    }
                }

                while (curr.next.Count != 0)
                {
                    if (curr.next.Count != 0)
                        res += curr.next[0].s;

                    curr = curr.next[0];
                }

                for (int j = 0; j < res.Length; ++j)
                    Console.Write(res[res.Length - 1 - j]);
                Console.WriteLine();
            }
        }
    }
}