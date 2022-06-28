using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.Палиндромные_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeat = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                var size = Convert.ToInt32(Console.ReadLine());
                string number = Console.ReadLine();
                int first = int.Parse(number[0].ToString());
                double? result;
                string strRelust ;
                //if (number.Length == size)
                //{
                if (first == 9)
                {
                    double polidrom = 1;
                    for (int j = 0; j < size; j++)
                    {
                        polidrom = polidrom * 10 + 1;
                    }
                    result = polidrom - Convert.ToDouble(number);
                    strRelust = result.ToString();
                }
                else
                {
                    double polidrom = 9;
                    for (int j = 0; j < size - 1; j++)
                    {
                        polidrom = polidrom * 10 + 9;
                    }
                    result = polidrom - Convert.ToDouble(number);
                    strRelust = result.ToString();
                }
                Console.WriteLine(strRelust);
            }
                //else
                //{
                //    result = null;
                //    Console.WriteLine("NaN");
                //    continue;
                //}
            //}
        }
    }
}
