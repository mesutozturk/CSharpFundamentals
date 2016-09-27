using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Adınızı giriniz");
            string girilen = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + girilen);

            //Veri tipleri
            //T A = D


            /*
             * değişken isimleri sayı ile başlamaz
             * sistemde tanımlı olan nesneler değişken adı olarak kullanılamaz
             * özel karakterlerle değişken adı verilemez
             * 
             * camelCase PascalCase
             */
            int _degisken = 3;
            double enBuyukOrtakBolen = 4;


            //Tam sayı değişkenleri
            byte _byte = 255;
            sbyte _sbyte = -23;
            short _short = 32423;
            ushort _ushort = 32423;
            int _int = 23423432;
            uint _uint = 4242342343;
            long _long = 23984729384;
            ulong _ulong = 223984729384;

            //Reel sayılar
            float _float = 5.5f;
            double _double = 5.5;
            decimal _decimal = 5.5m;

            //Metinsel değişkenler
            char _char = 'M';
            string _string = "lk lkadsakdja dlşkja lşjfd ş lk k k k k l şl fşajaoıg joıjrogıerjg aoerıgarıg aşoregı aoşırgarşogı jargşoa g şaırjga şoerııor gjaergş ıj arg şaoıreg oıarıj";

            bool _bool = true;
            _bool = false;
            _bool = 3 > 2;

            _string = _int + " adet";

            _int = _sbyte;
            _sbyte = Convert.ToSByte(_int);

            object _obje = _int;
            _obje = true;
            _obje = 34m;

            decimal a = 4 + (Convert.ToDecimal(4.4) * (2 - 4m));

            Console.WriteLine(a);

            //Çizim işlemleri
            //5x5 kare
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bir sayı giriniz");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < girilenSayi; i++)
            {
                for (int j = 0; j < girilenSayi; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Bir sayı giriniz içi boş için");
            girilenSayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < girilenSayi; i++)
            {
                for (int j = 0; j < girilenSayi; j++)
                {
                    if (i == 0 | i == girilenSayi - 1 | j == 0 | j == girilenSayi - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("Bir sayı giriniz üçgen için");
            girilenSayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= girilenSayi; i++)
            {
                for (int j = 1; j <= girilenSayi + i - 1; j++)
                {
                    if (j <= girilenSayi - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }

                }
                Console.WriteLine();
            }
            //Tarihi işlemleri
            DateTime suankiZaman = DateTime.Now;
            DayOfWeek gun = suankiZaman.DayOfWeek;
            Console.WriteLine(gun);

            Console.Read();
        }
    }
}
