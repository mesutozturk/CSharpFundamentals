using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //if
            int a = 3;
            if (a % 3 == 0)
            {
                Console.WriteLine("0");
            }
            else if (a % 3 == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }

            switch (a % 3)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                default:
                    Console.WriteLine("2");
                    break;
            }

            string bugun = DateTime.Now.DayOfWeek.ToString();
            switch (bugun)
            {
                case "Sunday":
                    Console.WriteLine("Bugün pazar");
                    break;
                case "Monday":
                    Console.WriteLine("Bugün pazartesi");
                    break;
                case "Tuesday":
                    Console.WriteLine("bugün salı");
                    break;
                case "Wednesday":
                    Console.WriteLine("bugün çarşamba");
                    break;
                    //......
                default:
                    break;
            }

            DayOfWeek today = DateTime.Now.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }

            int sayi = 32;
            if (sayi > 0 && sayi < 100)
            {
                Console.WriteLine("sayı 0 ila 100 arasında");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("sayı 0 dan küçük");
            }
            else
            {
                Console.WriteLine("sayı 100 den büyük");
            }

            //for (int i = 0; i < int.MaxValue; i++)
            //    for (int j = 0; j < 1000; j++) ;

            if (sayi > 0 && sayi < 100)
                Console.WriteLine("sayı 0 ila 100 arasında");
            else if (sayi < 0)
                Console.WriteLine("sayı 0 dan küçük");
            else
                Console.WriteLine("sayı 100 den büyük");

            for (int i = 0; i < 5000; i++) ;

            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);

            int rastgeleSayi = new Random().Next(1, 100);

            Console.Read();
        }
    }
}
