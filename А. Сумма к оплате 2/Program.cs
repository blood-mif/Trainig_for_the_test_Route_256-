using System;

namespace А.Сумма_к_оплате_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                int[] price = new int[10001];
                string[] numbers = Console.ReadLine().Split(' ');

                for (int j = 0; j < numbers.Length; ++j)
                {
                    int n = Convert.ToInt32(numbers[j]);

                    price[n]++;
                }

                int sum = 0;
                for (int j = 0; j < 10001; ++j)
                {
                    sum += j * (price[j] / 3) * 2;
                }

                Console.WriteLine(sum);
            }

        }
    }
}
