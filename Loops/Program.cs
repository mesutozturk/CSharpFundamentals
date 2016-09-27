using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //while döngüsü
            DateTime suan = DateTime.Now;
            int sayac = 0;
            while (suan.Second < 5)
            {
                sayac++;
                //Console.WriteLine(DateTime.Now);
                suan = DateTime.Now;
            }

            //do-while
            sayac = 0;
            do
            {
                sayac++;
                Console.WriteLine(DateTime.Now);
                suan = DateTime.Now;
            } while (suan.Second < 35);


            //for
            for (int i = 55; i > 0; i--)
            {
                if (i == 41)
                {
                    continue;
                }
                Console.WriteLine(i);
                if (i == 40)
                {
                    break;
                }
            }


            Console.Read();
        }
    }
}
