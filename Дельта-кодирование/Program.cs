using System;
using System.Linq;

namespace Дельта_кодирование
{
    class Program
    {
        static void Main(string[] args)
        {
            var encodingLenght = int.Parse(Console.ReadLine());
            var dataCoding = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
            var dataEnCoding = new int[dataCoding.Length + 1];
            for (int i = 0; i < dataCoding.Length; i++)
                dataEnCoding[i + 1] = dataCoding[i] + dataEnCoding[i];
            while (dataEnCoding.Min() < 0)
                dataEnCoding = dataEnCoding.Select(x => { x = x + 1; return x; }).ToArray();
            for (int i = 0; i < dataEnCoding.Length; i++)
                Console.Write(dataEnCoding[i] + " ");
        }
    }
}
