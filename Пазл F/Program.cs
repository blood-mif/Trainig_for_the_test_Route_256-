using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пазл_F
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[4, size];
            int count1 = 0;
            int count2 = 0;
            int result = 0;
            for (int x = 0; x < 4; x++)
            {
                var arr = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                for (int y = 0; y < arr.Length; y++)
                {
                    array[x, y] = arr[y];
                    if (arr[y]==0)
                    {
                        switch (x)
                        {
                            case 0:
                            case 1:
                                count1++;
                                break;
                            case 2:
                            case 3:
                                count2++;
                                break;
                        }
                    }
                }
            }
            if (count1!=count2)
            {
                result = -1;
                Console.WriteLine(result);
                return;
            }

            int[,] array1 = new int[4, 5]
            {
                {0,1,0,1,0 },
                {1,1,0,0,1 },
                {1,0,1,0,1 },
                {0,0,1,1,0 }
            };
            int[] arr1 = new int[5] { 0, 1, 0, 1, 0 };

            Console.ReadKey();
        }
    }
}
