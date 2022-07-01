using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J.Рифмы
{
    class Program
    {
        static void Main(string[] args)
        {
            var desk = Convert.ToInt32(Console.ReadLine());
            List<string> lstDesk = new List<string>();
            List<string> lstRequest = new List<string>();
            for (int i = 0; i < desk; i++)
            {
                lstDesk.Add(Console.ReadLine());
            }
            var requestRepeat = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < requestRepeat; i++)
            {
                List<string> ddd = new List<string>(lstDesk);
                var request = Console.ReadLine();
                //lstRequest.Add(Console.ReadLine());
                try
                {
                    ddd.Remove(request);
                }
                catch (Exception)
                {

                }

                findR()
                
            }
        }
    }
}
