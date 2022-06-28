using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_к_оплате
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> resultArr = new List<int>();
            var rep = int.Parse(Console.ReadLine());
            for (int x = 0; x < rep; x++)
            {

                var numbers = int.Parse(Console.ReadLine());
                var arr = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                var h = new Dictionary<int, int>();
                foreach (var i in arr)
                {
                    int res;
                    if (h.TryGetValue(i, out res))
                        h[i] += 1;
                    else
                        h.Add(i, 1);
                }

                int nnn = 0;
                int sss = 0;
                var keysArr = h.Keys.ToArray();
                for (int i = 0; i < keysArr.Length; i++)
                {
                    var cointArr = keysArr[i];
                    //cointArr = h.Keys    
                    //h.TryGetValue(i,out cointArr);
                    sss = h[keysArr[i]] / 3;
                    nnn = nnn + ((h[keysArr[i]] - sss) * keysArr[i]);
                }
                resultArr.Add(nnn);
            }
            for (int i = 0; i < resultArr.Count; i++)
            {
                Console.WriteLine(resultArr[i]);
            }

        }
    }
}
