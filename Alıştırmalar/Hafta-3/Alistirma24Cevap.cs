namespace Alistirma24Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            İki tamsayı a ve b(b ≠ 0) için bölüm ve kalanı hesaplayıp yazdırınız.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(ikinci sayıyı 0 olarak girdiğinde), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */
            while (true)
            {
                Console.Write("Birinci tam sayıyı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci tam sayıyı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                if (sayi2 == 0)
                {
                    Console.WriteLine("İkinci sayı 0 olamaz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Bölüm: " + sayi1/sayi2);
                    Console.WriteLine("Kalan: " + sayi1%sayi2);
                    break;
                }
            }
        }
    }
}
