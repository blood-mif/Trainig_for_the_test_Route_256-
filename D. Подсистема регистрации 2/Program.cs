using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace D.Подсистема_регистрации_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            String reg = @"^[0-9a-zA-Z_][0-9a-zA-Z_-]{1,23}$";

            for (int i = 0; i < t; ++i)
            {
                HashSet<String> usernames = new HashSet<string>();
                int count = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < count; ++j)
                {
                    String username = Console.ReadLine().ToLower();

                    if (!Regex.IsMatch(username, reg))
                        Console.WriteLine("NO");
                    else
                    {
                        if (usernames.Contains(username))
                            Console.WriteLine("NO");
                        else
                        {
                            usernames.Add(username);
                            Console.WriteLine("YES");
                        }
                    }
                }
            Console.WriteLine();
            }
        }
    }
}
