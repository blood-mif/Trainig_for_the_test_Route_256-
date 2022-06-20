using System;
using System.Collections.Generic;
using System.Linq;
namespace D.Wordle
{
    class Program
    {
        static void Main(string[] args)
        {

            var fisrtStr = Console.ReadLine().ToList();
            var secondStr = Console.ReadLine().ToList();
            var resultStr = new List<char>(secondStr);
            for (int i = 0; i < resultStr.Count; i++)
                resultStr[i] = '+';
            for (int i = 0; i < secondStr.Count; i++)
            {
                if (secondStr[i] == fisrtStr[i])
                {
                    resultStr[i] = 'G';
                    fisrtStr[i] = '*';
                }
            }
            for (int i = 0; i < resultStr.Count; i++)
            {
                if (resultStr[i] != 'G')
                {
                    var inx = fisrtStr.FindIndex(s => s == secondStr[i]);
                    if (inx >= 0)
                    {
                        resultStr[i] = 'Y';
                        fisrtStr[inx] = '*';
                    }
                }
            }
            resultStr = resultStr.Select(x => { x = x != 'G' & x != 'Y' ? '.' : x; return x; }).ToList();
            for (int i = 0; i < resultStr.Count; i++)
                Console.Write(resultStr[i]);
        }
    }
}
