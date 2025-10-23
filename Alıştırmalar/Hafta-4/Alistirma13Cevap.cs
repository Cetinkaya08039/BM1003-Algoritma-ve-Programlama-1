using System;
using System.Numerics;

namespace Alistirma13Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Girilen bir k sayısı tek ise 3 ile çarpılıp 1 ekleniyor, çift ise 2 ile bölünüyor. Bu işlem k sayısı 1
            olana kadar devam ediyor. Bu işlemin kaç adım sürdüğünü ve işlem sırasında k sayısının aldığı
            maksimum değeri ve k sayısının hangi sayıdan sonra hep çift olarak bire ulaştığını bulan C#
            kodunu yazınız.
            */

            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int adim = 0;
            int sontek = 0;
            int buyuk = sayi;
            while (sayi != 1)
            {
                if (sayi % 2 == 0)
                {
                    sayi = sayi/2;
                    adim++;
                }
                else
                {
                    if ((sayi*3+1) > buyuk)
                    {
                        buyuk = sayi*3+1;
                    }
                    if ((sayi * 3 + 1) % 2 == 0)
                    {
                        sontek = sayi;
                    }

                    sayi = (sayi*3+1);
                    adim++;
                }
            }
            Console.WriteLine("Yapılan işlem " + adim + " adım sürdü.");
            Console.WriteLine("İşlem sırasındaki maksimum değer: " + buyuk);
            if (sontek == 0)
            {
                Console.WriteLine("Girilen sayı hiç tek sayıya ulaşmadan hep çift olarak devam edip bire ulaştı.");

            }
            else
            {
                Console.WriteLine("Girilen sayı " + sontek + " sayısından sonra hep çift olarak devam edip bire ulaştı.");
            }

        }
    }
}
