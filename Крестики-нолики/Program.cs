using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Крестики_нолики
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            List<string> resultLst = new List<string>();
            for (int c = 0; c < number; c++)
            {
                var hz = Console.ReadLine();
                List<char[]> lst = new List<char[]>();
                lst.Add((Console.ReadLine().ToLower().ToCharArray()));
                lst.Add((Console.ReadLine().ToLower().ToCharArray()));
                lst.Add((Console.ReadLine().ToLower().ToCharArray()));
                int countX = 0;
                int count0 = 0;
                int countT = 0;
                int strikeX = 0;
                int strike0 = 0;
                for (int i = 0; i < lst.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        switch (lst[i][j])
                        {
                            case 'x':
                                countX++;
                                break;
                            case '0':
                                count0++;
                                break;
                            default:
                                countT++;
                                break;
                        }
                    }
                }
                if (countT == 9)
                {
                    resultLst.Add("YES");
                    continue;
                }
                if (countX - count0 != 1 && countX - count0 != 0)
                {
                    resultLst.Add("NO");
                    continue;
                }
                //if (countX<count0|| countX - count0 > 1)
                //{
                //    resultLst.Add("NO");
                //    continue;
                //}

                switch (lst[1][1] != '.' && (lst[1][1] == lst[0][0] && lst[1][1] == lst[2][2]) || (lst[1][1] == lst[0][2] && lst[1][1] == lst[2][0]))
                {
                    case true:
                        if (lst[1][1] == 'x')
                            strikeX++;
                        if (lst[1][1] == '0')
                            strike0++;
                        break;
                    default:
                        break;
                }

                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i][0] != '.' && lst[i][0] == lst[i][1] && lst[i][0] == lst[i][2])
                    {
                        if (lst[i][0] == 'x')
                            strikeX++;
                        if ((lst[i][0] == '0'))
                            strike0++;
                    }
                    if (lst[0][i] != '.' && lst[0][i] == lst[1][i] && lst[0][i] == lst[2][i])
                    {
                        if (lst[0][i] == 'x')
                            strikeX++;
                        if ((lst[0][i] == '0'))
                            strike0++;
                    }

                }
                if (strikeX == strike0 && strikeX >= 1 || (strikeX == 1 && count0 == countX))
                {
                    if ((countX - count0 == 1 || countX - count0 == 0) && strikeX == 0)
                    {
                        resultLst.Add("YES");
                        continue;
                    }
                    resultLst.Add("NO");
                    continue;
                }
                //if (strikeX>0&&count0>=countX)
                //{
                //    resultLst.Add("NO");
                //    continue;
                //}
                //if (strike0 > 0 && countX >= count0)
                //{
                //    resultLst.Add("NO");
                //    continue;
                //}
                resultLst.Add("YES");

            }
            for (int i = 0; i < resultLst.Count; i++)
            {
                Console.WriteLine(resultLst[i]);
            }
        }
    }
}
