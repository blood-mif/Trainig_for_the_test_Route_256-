using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерная_игра
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char[,]> listResult = new List<char[,]>();
            var number = Convert.ToInt32(Console.ReadLine());
            for (int c = 0; c < number; c++)
            {
                var nn = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                char[,] arr = new char[nn[0], nn[1]];
                char[] array = new char[nn[1]];
                for (int x = 0; x < nn[0]; x++)
                {
                    array = (Console.ReadLine().ToCharArray());
                    for (int y = 0; y < nn[1]; y++)
                    {
                        arr[x, y] = array[y];
                    }
                }

                List<int> lst = new List<int>();
                char[,] resultArr = new char[nn[0], nn[1]];
                for (int i = 0; i < nn[1]; i++)
                {
                    int count = 0;
                    for (int j = 0; j < nn[0]; j++)
                    {
                        resultArr[j, i] = '.';
                        if (arr[j, i] == '*')
                        {
                            count++;
                            resultArr[count - 1, i] = '*';
                            continue;
                        }
                    }
                    lst.Add(count);
                }
                int fistIndex;
                int lastIndex;
                for (int i = 0; i < resultArr.GetLength(0); i++)
                {
                    fistIndex = lst.FindIndex(s => s > 0);
                    lastIndex = lst.FindLastIndex(s => s > 0);
                    if (fistIndex != lastIndex & fistIndex >= 0)
                    {
                        for (; fistIndex < lastIndex; fistIndex++)
                        {
                            if (resultArr[i, fistIndex] != '*')
                                resultArr[i, fistIndex] = '~';
                        }
                    }
                    lst = lst.Select(x => { x = x - 1; return x; }).ToList();
                }
                listResult.Add(resultArr);
            }
            for (int i = 0; i < listResult.Count; i++)
            {
                for (int j = listResult[i].GetLength(0) - 1; j >= 0; j--)
                {
                    for (int k = 0; k < listResult[i].GetLength(1); k++)
                    {
                        Console.Write(listResult[i][j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
