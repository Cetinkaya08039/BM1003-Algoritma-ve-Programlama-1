namespace Alistirma2Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden girilen 3 basamaklı pozitif bir tam sayının basamakları toplamını bulanprogramı yazınız.
            Ör: 123 sayısının basamakları toplam 1 + 2 + 3 = 6’dır.

            Not: 
            Hatalı (3 basamaklı olmayan) bir sayı girildiğinde program uyarı mesajı vererek 3 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
            Console.Write("3 basamaklı bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 100)
            {
                Console.WriteLine("3 basamaklı bir tam sayı girmeniz gerekmekte!");
                Thread.Sleep(3000);
                Console.Clear();

            }
            else if (sayi > 999)
            {
                Console.WriteLine("3 basamaklı bir tam sayı girmeniz gerekmekte!");
                Thread.Sleep(3000);
                Console.Clear();
                }
            else
            {
                int yuzler = sayi / 100;
                int onlar = (sayi % 100)/10;
                int birler = sayi % 10;
                int toplam = yuzler + birler + onlar;
                Console.WriteLine("Girdiğiniz sayının;");
                Console.WriteLine("Yüzler basamağı: " + yuzler);
                Console.WriteLine("Onlar basamağı: " + onlar);
                Console.WriteLine("Birler basamağı: " + birler);
                Console.WriteLine("Basamak toplamları: " + toplam);
            }
            }
        }
    }
}
