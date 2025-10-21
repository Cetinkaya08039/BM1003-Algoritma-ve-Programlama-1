namespace Alistirma11Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            0 sayısı girilene kadar sayı girişini sağlayan ve bu sayıların kaç tane olduğunu, 
            toplamını ve ortalamasını bulup sonucu ekrana yazdıran programı yazınız.
            */

            int miktar = 0;
            double toplam = 0;
            double ort = 0;
            while (true)
            {
                Console.Write("Bir sayı giriniz(döngüyü bitirmek için 0 giriniz): ");
                double sayi = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (sayi > 0 || sayi < 0)
                {
                    miktar++;
                    toplam += sayi;
                }
                else
                {
                    Console.WriteLine("Çıkış yapılıyor.");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Çıkış yapılıyor..");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Çıkış yapılıyor...");
                    Thread.Sleep(500);
                    Console.Clear();
                    break;
                }
            }
            Console.WriteLine("Sayıların miktarı: " + miktar);
            Console.WriteLine("Girilen sayıların toplamı: " + toplam);
            Console.WriteLine("Girilen sayıların ortalaması: " + toplam/miktar);
        }
    }
}
