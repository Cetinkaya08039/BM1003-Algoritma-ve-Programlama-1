namespace Alistirma14Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden girilen 10 adet tamsayı sınav notuna göre, ortalamanın üstünde olanları ekrana
            yazan programı yazınız.
            Örnek:
            10 adet notu giriniz:
                        56
            42
            …
            75
            13
            Çıktı:
            Sınıfın ortalaması = 53.25
            ortalamadan yüksek olan notlar:
            56
            75
            */

            int[] notlar = new int[10];
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+1 + ". öğrencinin notunu giriniz: ");
                notlar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += notlar[i];
            }
            double ort = toplam / 10;
            Console.WriteLine("Sınıfın ortalaması = " + ort);
            int[] buyuk = new int[10];
            Console.WriteLine("Ortalamadan yüksek olan notlar:");
            for (int i = 0; i < 10; i++)
            {
                if (notlar[i] > ort)
                {
                    buyuk[i] = notlar[i];
                    Console.WriteLine(buyuk[i]);
                }
            }
        }
    }
}
