namespace Alistirma29Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan iki kesir alınız: birinci kesir için a ve b, ikinci kesir için c ve d değerlerini(pay
            ve payda) giriniz.Paydalar 0 olamaz.Girilen iki kesri karşılaştırarak, birinci kesir büyükse
            "a/b > c/d", küçükse "a/b < c/d", eşitse "a/b = c/d" şeklinde sonucu ekrana yazdırınız.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(paydalardan biri 0 olarak girildiğinde), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */
          
            while (true)
            {
                Console.Write("Birinci sayıyı(Pay) giriniz: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayıyı(Payda) giriniz: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Üçüncü sayıyı(Pay) giriniz: ");
                double sayi3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Dördüncü sayıyı(Payda) giriniz: ");
                double sayi4 = Convert.ToDouble(Console.ReadLine());
                if (sayi2 == 0 || sayi4 == 0)
                {
                    Console.WriteLine("Paydalar sıfır olamaz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (sayi1/sayi2 > sayi3/sayi4)
                {
                    Console.WriteLine(sayi1 + "/" + sayi2 + " > " + sayi3 + "/" + sayi4);
                    break;
                }
                else if (sayi1 / sayi2 < sayi3 / sayi4)
                {
                    Console.WriteLine(sayi1 + "/" + sayi2 + " < " + sayi3 + "/" + sayi4);
                    break;
                }
                else
                {
                    Console.WriteLine(sayi1 + "/" + sayi2 + " = " + sayi3 + "/" + sayi4);
                    break;

                }
            }
        }
    }
}
