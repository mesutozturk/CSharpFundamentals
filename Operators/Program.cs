using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //  + - * /  (  )  matematiksel oparatorler %

            int a = 4 * 3;
            a = 5 / 2;  //dikkat!

            // +=  -= *=
            // =+  =- =*

            a = a + 5;
            a += 5;

            // ++ -- 
            a = 5;
            int c = a++;
            Console.WriteLine(c + " " + a);
            c = --a;
            Console.WriteLine(c + " " + a);
            if (a % 2 == 0)
            {
                Console.WriteLine("çift");
            }
            else
            {
                Console.WriteLine("tek");
            }
            /* mantıksal operatorler
             * == !=
             * > <
             * <= >=
             * & |     &&  ||  
             * <<  >>
             */

            if (a % 2 == 0 && c == 5)
            {
                Console.WriteLine("doğru");
            }
            else
            {
                Console.WriteLine("yanlış");
            }

            if (5 > 6 & (9 < 2 | 3 == 9 / 3))
            {
                Console.WriteLine();
            }
            string kullaniciAdi = "Kamil2";

            bool sonuc = kullaniciAdi == "Kamil";

            if (!sonuc)
            {
                Console.WriteLine(kullaniciAdi + " sisteme başarıyla kaydoldunuz");
            }
            else
            {
                Console.WriteLine(kullaniciAdi + " sisteme daha önceden kayıtlı");
            }

            sonuc = !sonuc;

            // + concat
            string b = a + " adet";
            b = "bana \"Merhaba\" dedi";
            b += "\naferin\bppppppppp\tuzun boşluk";
            Console.WriteLine(b);
            string path = @"C:\Users\Mesut-Wissen\Dropbox\W-301O";
            Console.WriteLine(path);


            Console.Read();
        }
    }
}
