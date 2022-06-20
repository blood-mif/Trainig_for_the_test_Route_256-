using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Электронная_таблица
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = new int[4, 3]
                {
                {3,4,1 },
                {2,2,5 },
                {2,4,2 },
                {2,2,1 }
            };
            int[] click = new int[3]
                {2,1,3};

            List<int> lst = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                lst.Add(arr[i, click[1]]);
            }
            lst.Sort();
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] != arr[i, click[1]])
                {

                }
            }
        }
    }
}
