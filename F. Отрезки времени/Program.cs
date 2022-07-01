using System;
using System.Collections.Generic;
using System.Linq;

namespace F.Отрезки_времени
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                int count = Convert.ToInt32(Console.ReadLine());
                bool flag = true;
                Dictionary<DateTime, DateTime> all = new Dictionary<DateTime, DateTime>();
                List<DateTime> left = new List<DateTime>();

                for (int j = 0; j < count; ++j)
                {
                    int[] times = Console.ReadLine().Replace("-", ":").Split(':').Select(it => int.Parse(it)).ToArray();

                    if (times[0] >= 0 && times[0] < 24 && times[3] >= 0 && times[3] < 24 &&
                        times[1] >= 0 && times[1] < 60 && times[4] >= 0 && times[4] < 60 &&
                        times[2] >= 0 && times[2] < 60 && times[5] >= 0 && times[5] < 60
                    )
                    {
                        DateTime t1 = new DateTime(2022, 1, 1, times[0], times[1], times[2]);
                        DateTime t2 = new DateTime(2022, 1, 1, times[3], times[4], times[5]);

                        if (t1 > t2)
                        {
                            flag = false;
                        }
                        else
                        {
                            if (all.ContainsKey(t1))
                                flag = false;
                            else
                                all.Add(t1, t2);
                            left.Add(t1);
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }

                left.Sort();
                for (int j = 0; j < left.Count - 1; ++j)
                {
                    if (left[j] == left[j + 1])
                        flag = false;

                    if (all[left[j]] >= left[j + 1])
                        flag = false;
                }


                if (flag)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}