using System;
using System.Collections.Generic;
using System.Linq;


namespace C.Оповещения
{
    public class с
    {
        static void Main(string[] args)
        {
            int[] nq = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
            int n = nq[0];
            int q = nq[1];
            int count = 1;

            List<int> notificationAll = new List<int>();
            List<List<int>> peopleNotification = new List<List<int>>();

            for (int i = 0; i <= n; ++i)
                peopleNotification.Add(new List<int>());

            for (int i = 1; i <= q; ++i)
            {
                int[] tid = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                int t = tid[0];
                int id = tid[1];

                if (t == 1)
                {
                    if (id == 0)
                    {
                        notificationAll.Add(count);
                    }
                    else
                    {
                        peopleNotification[id].Add(count);
                    }

                    count++;
                }
                else
                {
                    int maxAll = 0;
                    int maxPerson = 0;

                    if (notificationAll.Count != 0)
                        maxAll = notificationAll[notificationAll.Count - 1];

                    if (peopleNotification[id].Count != 0)
                        maxPerson = peopleNotification[id][peopleNotification[id].Count - 1];

                    Console.WriteLine(Math.Max(maxAll, maxPerson));
                }
            }
        }
    }
}
