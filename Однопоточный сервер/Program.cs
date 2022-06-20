using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Однопоточный_сервер
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> listResult = new List<int[]>();
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < number; j++)
            {
                var hz = Console.ReadLine();
                int size = int.Parse(Console.ReadLine());
                int[,] timeArray = new int[size, 2];
                for (int i = 0; i < size; i++)
                {
                    var nn = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                    timeArray[i, 0] = nn[0];
                    timeArray[i, 1] = nn[1];
                }

                int[] timeResulte = new int[size];
                int a = timeArray[0, 0] + timeArray[0, 1];
                timeResulte[0] = a;
                for (int i = 1; i < timeArray.GetLength(0); i++)
                {
                    if (a > timeArray[i, 0])
                        a = a + timeArray[i, 1];
                    else
                        a = timeArray[i, 0] + timeArray[i, 1];
                    timeResulte[i] = a;
                }
                listResult.Add(timeResulte);
            }
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < listResult[i].Length; j++)
                {
                    Console.Write(listResult[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
