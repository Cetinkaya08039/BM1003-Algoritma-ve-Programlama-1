using System.Threading.Channels;

namespace Alistirma9Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden sıfır girinceye kadar sayı girilmesini sağlayan negatif ve pozitifleri ayrı ayrı toplayıp ekrana yazdıran programı yazınız.
            */

            double negatif = 0;
            double pozitif = 0;
            while (true)
            {
                Console.Write("Bir sayı giriniz(döngüyü bitirmek için 0 giriniz): ");
                double sayi = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                if (sayi < 0)
                {
                    negatif += sayi;
                }
                else if (sayi > 0)
                {
                    pozitif += sayi;
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
            Console.WriteLine("Negatiflerin toplamı = " + negatif);
            Console.WriteLine("Pozitiflerin toplamı = " + pozitif);

        }
        
    }
}
