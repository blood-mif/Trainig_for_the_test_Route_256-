using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А.Оптимальный_путь
{
    class Program
    {
        static void Main(string[] args)
        {
            var repeat = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {

            double[] arrSize = Console.ReadLine().Split(' ').Select(it => double.Parse(it)).ToArray();
            double firstArihProgres = (1 + arrSize[1]) * arrSize[1] / 2;
            double secondArihProgres = (arrSize[1] + (arrSize[1] * arrSize[0]))*arrSize[0] / 2;
            double result = firstArihProgres + (secondArihProgres  - arrSize[1]);
            Console.WriteLine(result);
            }
        }
    }
}
