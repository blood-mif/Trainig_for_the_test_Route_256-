using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адресная_книга
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<List<string>>> answer = new List<List<List<string>>>();
            List<List<string>> resuleLst = new List<List<string>>();
            var countXXX = int.Parse(Console.ReadLine());
            for (int ww = 0; ww < countXXX; ww++)
            {
                var numbers = int.Parse(Console.ReadLine());
                List<string[]> dataLst = new List<string[]>();
                var nameLst = new List<string>();
                var numberLst = new List<string>();
                for (int i = 0; i < numbers; i++)
                {
                    dataLst.Add(Console.ReadLine().Split(' ').ToArray());

                }
                for (int i = 0; i < dataLst.Count; i++)
                {
                    nameLst.Add(dataLst[i][0]);
                    numberLst.Add(dataLst[i][1]);
                }
                var nameLstCurr = nameLst.Distinct().ToList();
                nameLstCurr.Sort();
                for (int z = 0; z < nameLstCurr.Count; z++)
                {
                    var listTargetNumber = dataLst.FindAll(item => item[0] == nameLstCurr[z]);
                    List<string> numberLstCurr = new List<string>();
                    for (int d = 0; d < listTargetNumber.Count; d++)
                    {
                        numberLstCurr.Add(listTargetNumber[d][1]);
                    }
                    numberLstCurr.Reverse();
                    numberLstCurr = numberLstCurr.Distinct().ToList();
                    numberLstCurr.Reverse();
                    int allnumb = 0;
                    string result = " ";
                    List<string> resultNumber = new List<string>();
                    for (int i = 0; i < numberLstCurr.Count && i < 5; i++)
                    {
                        allnumb++;
                        resultNumber.Add(numberLstCurr[numberLstCurr.Count - (i + 1)]);
                        if (result != " ")
                        {
                            result = result + " " + resultNumber[i];
                        }
                        else
                        {
                            result = resultNumber[i];
                        }
                    }
                    List<string> gg = new List<string>();
                    gg.Add(nameLstCurr[z] + ": " + allnumb + " " + result);
                    resuleLst.Add(gg);
                }
                answer.Add(resuleLst);
                resuleLst = new List<List<string>>();
            }
            for (int j = 0; j < answer.Count; j++)
            {
                for (int x = 0; x < answer[j].Count; x++)
                {
                    for (int i = 0; i < answer[j][x].Count; i++)
                    {
                        Console.WriteLine(answer[j][x][i]);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
