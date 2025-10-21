using System;

namespace Alistirma35Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan vize ve final notlarını alınız.
            Ortalama, vize × 0.4 + final × 0.6 formülüyle hesaplanacaktır.
            Hesaplanan ortalamaya göre harf notunu belirleyiniz:
            90 ve üzeri → AA
            80–89 → BA
            70–79 → BB
            60–69 → CB
            50–59 → CC
            50’den düşük → FF
            Sonuç olarak ekrana “Ortalama = …, Harf Notu = …” şeklinde yazdırınız.
            */

            Console.Write("Vize notunuzu giriniz: ");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final notunuzu giriniz: ");
            double final = Convert.ToDouble(Console.ReadLine());
            double ort = vize * 0.4 + final * 0.6;
            if (ort >= 90)
            {
                Console.WriteLine("Ortalama = " + ort + ", Harf Notu = AA");
            }
            else if (80 <= ort && ort <= 89)
            {
                Console.WriteLine("Ortalama = " + ort + ", Harf Notu = BA");
            }
            else if (70 <= ort && ort <= 79)
            {
                Console.WriteLine("Ortalama = " + ort + ", Harf Notu = BB");
            }
            else if (60 <= ort && ort <= 69)
            {
                Console.WriteLine("Ortalama = " + ort + ", Harf Notu = CB");
            }
            else if (50 <= ort && ort <= 59)
            {
                Console.WriteLine("Ortalama = " + ort + ", Harf Notu = CC");
            }
            else
            {
                Console.WriteLine("Ortalama = " + ort + ", Harf Notu = FF");
            }
        }
    }
}
