using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Многопоточный_сервер
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
                var nnn = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                int threads = nnn[0];
                int size = nnn[1];
                int[,] timeArray = new int[size, 2];
                for (int i = 0; i < size; i++)
                {
                    var nn = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                    timeArray[i, 0] = nn[0];
                    timeArray[i, 1] = nn[1];
                }
                int[] timeResulte = new int[size];
                if (threads > size)
                    threads = size;
                List<int> lstTime = new List<int>();
                for (int i = 0; i < threads; i++)
                {
                    timeResulte[i] = timeArray[i, 0] + timeArray[i, 1];
                    lstTime.Add(timeResulte[i]);
                }
                if (timeResulte[size - 1] != 0)
                {
                    listResult.Add(timeResulte);
                    continue;
                }
                int minTime;
                for (int i = threads; i < timeArray.GetLength(0); i++)
                {
                    minTime = lstTime.Min();
                    int forDel = minTime;
                    if (minTime > timeArray[i, 0])
                    {
                        minTime = minTime + timeArray[i, 1];
                        lstTime.Remove(forDel);
                    }
                    else
                    {
                        minTime = timeArray[i, 0] + timeArray[i, 1];
                        lstTime.Remove(forDel);
                    }
                    timeResulte[i] = minTime;
                    lstTime.Add(minTime);
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
