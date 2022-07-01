using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace D.Подсистема_регистрации
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                var number = int.Parse(Console.ReadLine());
                List<string> listLogin = new List<string>();
                var dictionary = new Dictionary<int, string>();
                for (int j = 0; j < number; j++)
                {
                    var login = Console.ReadLine().ToLower();
                    var ss = StringIsValid(login);
                    listLogin.Add(login);
                    dictionary.Add(j,login);
                }

            }
        }
            public static bool StringIsValid(string str)
        {
            return !string.IsNullOrEmpty(str) && !Regex.IsMatch(str, @"(^[^0-9a-zA-Z_]|[^0-9a-zA-Z_-]){2,22}");
        }
    }
}
