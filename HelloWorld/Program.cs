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
            Console.Read();
        }
    }
}
