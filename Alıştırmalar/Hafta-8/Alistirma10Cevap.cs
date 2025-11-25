namespace Alistirma10Cevap
{
    internal class Program
    {
        static bool cntrl(int x)
        {
            int yuz = x / 100;
            int on = x % 100 / 10;
            int bir = x % 10;
            if ((yuz*yuz*yuz + on*on*on + bir*bir*bir) == x)
            {  return true; }
            return false;
        }
        static void Main(string[] args)
        {
            /*
            Girilen 3 basamaklı bir sayının basamaklarının küplerinin toplamının kendisine eşit olup olmadığını kontrol eden bir metot yazınız.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(üç basamaklı olmayan bir sayı girildiğinde), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */
            while (true)
            {
                Console.Write("Üç basamaklı bir sayı girin: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 99 && x < 1000)
                {
                    Console.WriteLine(cntrl(x));
                    break;
                }
                Console.WriteLine("3 basamaklı bir sayı girmeniz gerekmekte!");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
