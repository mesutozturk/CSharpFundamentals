using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Metotlar 2ye ayrılır
             * 1) Geriye değer döndürenler
             * 2) Değer döndürmeyenler.
             * 
             */
            Bekle(999999);
            GeriyeDegerDondurmeyenFonksiyon("Deneme", 5);
            Bekle(109000);
            GeriyeDegerDondurmeyenFonksiyon("Kamil", 15);
            Bekle(999999);
            GeriyeDegerDondurmeyenFonksiyon("Hıdır", 2);

            double hip = HipotenusHesapla(23, 44);
            Console.WriteLine(hip);

            double hiz = 90, saat = 3;
            double yol = YolHesapla(hiz, saat);
            double yol2 = YolHesapla(55, 12);
            Console.WriteLine(yol);

            double KareAlan = AlanHesapla(25);
            double dikdortgenAlan = AlanHesapla(2, 5);
            double daireAlan = AlanHesapla(2.8, 3.14);

            int[] sayilar = new int[5];
            sayilar[4] = 99;
            Array.Resize(ref sayilar, 4);
            string ad = "kamil";
            int a = 5;
            Test(ref a);
            Console.WriteLine(a);

            string giris = "5uıh";
            int cikis = 0;
            if (int.TryParse(giris, out cikis))
                Console.WriteLine("Sayi dönüştürüldü " + cikis);
            else
                Console.WriteLine("Giriş sayıya dönüştürülemedi");

            string dgiris = "5.pp5";
            double dcikis = 0;
            if (DeneDouble(dgiris, out dcikis))
                Console.WriteLine("Sayi dönüştürüldü " + dcikis);
            else
                Console.WriteLine("Giriş sayıya dönüştürülemedi");

            int toplam = Topla(1, 2, 3, 4, 5, 45, 3, 23, 6);

            Console.Read();
        }
        /// <summary>
        /// Gidilen yolun hesaplayan metotdur kendileri.
        /// </summary>
        /// <param name="hiz">saatlik ortalama hız</param>
        /// <param name="saat">saat</param>
        /// <returns></returns>
        static double YolHesapla(double hiz, double saat) => hiz * saat;
        /// <summary>
        /// Dik üçgenin hipotenus uzunluğunu hesaplar
        /// </summary>
        /// <param name="kenar1">dik kenarlardan birincisi</param>
        /// <param name="kenar2">dik kenarlardan ikicinsi</param>
        /// <returns></returns>
        static double HipotenusHesapla(double kenar1, double kenar2) => Math.Sqrt(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2));
        static void GeriyeDegerDondurmeyenFonksiyon(string yazi, int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(yazi);
            }
        }
        static void Bekle(int milisaniye)
        {
            for (int i = 0; i < milisaniye; i++) ;
        }

        // method overloading..
        /// <summary>
        /// Karenin alanını hesaplamak için kullanılır
        /// </summary>
        /// <param name="kenar">Kenar uzunluğu</param>
        /// <returns></returns>
        static double AlanHesapla(int kenar) => Math.Pow(kenar, 2);
        /// <summary>
        /// Dikdörtgenin alanını hesaplamak için kullanılır
        /// </summary>
        /// <param name="kenar1">Kısa Kenar</param>
        /// <param name="kenar2">Uzun Kenar</param>
        /// <returns></returns>
        static double AlanHesapla(int kenar1, int kenar2) => kenar1 * kenar2;
        /// <summary>
        /// Dairenin alanını hesaplamak için kullanılır.
        /// </summary>
        /// <param name="yaricap">yarıçap uzunluğu</param>
        /// <returns></returns>
        static double AlanHesapla(double yaricap, double pi = Math.PI) => pi * Math.Pow(yaricap, 2);

        static void Test(ref int sayi)
        {
            sayi += 50;
        }

        static bool DeneDouble(string s, out double cikis)
        {
            try
            {
                cikis = double.Parse(s);
                return true;
            }
            catch
            {
                cikis = 0;
                return false;
            }
        }

        static int Topla(params int[] sayilar)
        {
            int sonuc = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc += sayilar[i];
            }
            return sonuc;
        }
    }
}
