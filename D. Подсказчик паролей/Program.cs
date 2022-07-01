using System;
using System.Text.RegularExpressions;

namespace D.Подсказчик_паролей
{
    class Program
    {
        static void Main(string[] args)
        {
            String reg1 = @"^[a-zA-Z]+$";
            String reg2 = @"^[0-9]+$";

            String reg = @"[A-Z]+";
            String reg11 = @"^[A-Z0-9]+$";

            String reg4 = @"[euioayEUIOAY]+";
            String reg44 = @"[euioay]+";
            String reg3 = @"[bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ]+";
            String reg33 = @"[bcdfghjklmnpqrstvwxz]+";
            //String reg5 = @"^[a-zA-Z]+$";

            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string password = Console.ReadLine();
                string passwordCurr ="";
                if (Regex.IsMatch(password, reg1))
                {
                    password = password + "0";
                }
                if (Regex.IsMatch(password, reg2))
                {
                    Console.WriteLine(password + "aB");
                    continue;
                }

                if (!Regex.IsMatch(password, reg))
                {
                    if (!Regex.IsMatch(password, reg44))
                        password = password + "A";
                    if (!Regex.IsMatch(password, reg33))
                        password = password + "B";
                    if ((Regex.IsMatch(password, reg44)) && (Regex.IsMatch(password, reg33)))
                    {
                        password = password + "A";
                    }
                }
                else
                {
                    if (!Regex.IsMatch(password, reg4))
                        password = password + "a";
                    if (!Regex.IsMatch(password, reg3))
                        password = password + "b";

                    if (Regex.IsMatch(password, reg11))
                        password = password + "x";

                }
                Console.WriteLine(password+passwordCurr);
            }
        }
    }
}
