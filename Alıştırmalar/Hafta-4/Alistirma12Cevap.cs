using System;
using System.Runtime.Serialization.Formatters;

namespace Alistirma12Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Girilen bir tam sayının basamaklarındaki en büyük rakamı bulan programı yazınız.
            */

            Console.Write("Bir tam sayı giriniz: ");
            string sayistr = Console.ReadLine();
            int sayiint = Convert.ToInt32(sayistr);
            int basamaksayi = sayistr.Length;
            int[] basamak = new int[basamaksayi];
            int buyuk = 0;
            for (int i = 0; i < basamaksayi; i++)
            {
                if (i == 0)
                {
                    // Convert.ToInt32 sayıyı yuvarlıyordu örneğin sayı 5.6 ise 5 çıkartmak yerine 6 yapıyordu bunun yerine (int) kullanıldı.
                    basamak[i] = (int)(sayiint / Math.Pow(10, basamaksayi - 1));
                    if (basamak[i] >buyuk)
                    {
                        buyuk = basamak[i];
                    }
                }
                else if (i == basamaksayi - 1)
                {
                    basamak[i] = sayiint % 10;
                    if (basamak[i] > buyuk)
                    {
                        buyuk = basamak[i];
                    }
                }
                else
                {
                    basamak[i] = (int)(sayiint % Math.Pow(10, basamaksayi - i) / Math.Pow(10, basamaksayi - 1 - i));
                    if (basamak[i] > buyuk)
                    {
                        buyuk = basamak[i];
                    }
                }
                
            }
            Console.WriteLine("Girdiğiniz sayının rakamlarının en büyüğü: " + buyuk);
        }

            

            
        
    }
}
