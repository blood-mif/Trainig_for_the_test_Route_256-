using System;
using System.Collections.Generic;
using System.Linq;

namespace Е.Адресная_книга_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                int count = Convert.ToInt32(Console.ReadLine());
                Dictionary<String, List<String>> book = new Dictionary<string, List<string>>();

                for (int j = 0; j < count; ++j)
                {
                    String[] s = Console.ReadLine().Split(' ');

                    if (!book.ContainsKey(s[0]))
                    {
                        book.Add(s[0], new List<string>() { s[1] });
                    }
                    else
                    {
                        if (!book[s[0]].Contains(s[1]))
                            book[s[0]].Add(s[1]);
                        else
                        {
                            book[s[0]].Remove(s[1]);
                            book[s[0]].Add(s[1]);
                        }


                        if (book[s[0]].Count > 5)
                            book[s[0]].RemoveAt(0);
                    }
                }
                var names = book.Select(kvp => kvp.Key).ToList();
                names.Sort();
                foreach (var name in names)
                {
                    Console.Write(name + ": ");
                    Console.Write(book[name].Count + " ");
                    book[name].Reverse();
                    foreach (var number in book[name])
                    {
                        Console.Write(number + " ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}