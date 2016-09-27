using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi
            int sayi = 5;
            int[] sayilar = new int[5];
            sayilar[0] = 5;
            sayilar[1] = 6;
            sayilar[2] = 88;
            sayilar[3] = -324;
            sayilar[4] = -34;

            string[] kisiler = { "Ahmet", "Mehmet", "Kamil" };

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            foreach (string kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }

            double[,] matris = new double[2, 2];
            matris[0, 0] = 2;
            matris[0, 1] = 3;
            matris[1, 0] = 3;
            matris[1, 1] = 6;

            double[,,] ucboyutlu = new double[2, 2, 2];
            ucboyutlu[0, 0, 0] = 4;
            ucboyutlu[0, 0, 1] = 3;
            ucboyutlu[0, 1, 0] = 45;
            ucboyutlu[0, 1, 1] = 24;
            ucboyutlu[1, 0, 0] = 4;

            //using System.Collections;
            ArrayList dizi = new ArrayList();
            dizi.Add(1);
            dizi.Add("kamil");
            dizi.Add(DateTime.Now);
            dizi.Add(true);
            dizi.Add('3');
            dizi.Remove(true);
            dizi.Add(ucboyutlu);

            //Generic List
            List<int> zarlar = new List<int>();
            zarlar.Add(1);
            zarlar.Add(2);
            List<bool> cevaplar = new List<bool>();
            List<object> nesneler = new List<object>();

            Console.ReadLine();
        }
    }
}
