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
            List<List<List<int>>> answer = new List<List<List<int>>>();
            var repeat = int.Parse(Console.ReadLine());
            for (int ix = 0; ix < repeat; ix++)
            {
                var skip = Console.ReadLine();
                var axx = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                var x = axx[0];
                var y = axx[1];
                List<List<int>> arrLstT = new List<List<int>>();
                for (int i = 0; i < x; i++)
                {
                    arrLstT.Add(Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToList());
                }

                List<int> deleteLst = new List<int>();
                List<List<int>> arrLstCurrent = new List<List<int>>();
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        deleteLst.Add(arrLstT[j][i]);
                    }
                    arrLstCurrent.Add(deleteLst);
                    deleteLst = new List<int>();
                }
                var skip2 = int.Parse(Console.ReadLine());
                List<int> click = new List<int>();
                var sdad = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToList();
                for (int i = 0; i < sdad.Count; i++)
                {
                    click.Add(sdad[i]);
                }
                for (int a = 0; a < click.Count; a++)
                {
                    List<Dictionary<int, int>> lst = new List<Dictionary<int, int>>();
                    List<int> currLst = new List<int>();
                    List<List<int>> currLstBIG = new List<List<int>>();
                    List<int> arrLst = new List<int>();
                    var dictionary = new Dictionary<int, int>();
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            dictionary.Add(j, arrLstCurrent[i][j]);
                        }
                        lst.Add(dictionary);
                        dictionary = new Dictionary<int, int>();
                    }
                    var items = from pair in lst[click[a] - 1]
                                orderby pair.Value ascending
                                select pair;
                    foreach (KeyValuePair<int, int> pair in items)
                    {
                        dictionary.Add(pair.Key, pair.Value);
                    }
                    var keys = dictionary.Keys.ToArray();
                    for (int gg = 0; gg < lst.Count; gg++)
                    {
                        for (int g = 0; g < lst[0].Count; g++)
                        {
                            currLst.Add(lst[gg][keys[g]]);
                        }
                        currLstBIG.Add(currLst);
                        currLst = new List<int>();

                    }
                    arrLstCurrent = new List<List<int>>(currLstBIG);
                }
                answer.Add(arrLstCurrent);

            }
            for (int j = 0; j < answer.Count; j++)
            {
                // почему если я ставлю i < answer[j][i].Count вылетает ошибка
                for (int i = 0; i < answer[j][0].Count; i++)
                {
                    for (int ji = 0; ji < answer[j].Count; ji++)
                    {
                        Console.Write(answer[j][ji][i] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
