namespace Alistirma17Cevap.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            İki basamaklı bir sayının basamaklarının yerini değiştiren ve elde edilen sayının orjinal sayıdan
            büyük olup olmadığını kontrol eden bir C# programı yazın.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(2 basamaklı olmayan bir sayı girildiğinde), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
                Console.Write("İki basamaklı bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi >= 100 || sayi < 10)
                {
                    Console.WriteLine("İki basamaklı bir sayı girmeniz gerekmekte!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    int onlar = sayi / 10;
                    int birler = sayi % 10;
                    int tut = onlar;
                    onlar = birler;
                    birler = tut;
                    string onstr = Convert.ToString(onlar);
                    string brstr = Convert.ToString(birler);
                    Console.WriteLine("İkinci sayı = " + onstr + brstr);
                    if (Convert.ToInt32(onstr + brstr) > sayi)
                    {
                        Console.WriteLine("İkinci sayı girilen sayıdan daha büyük.");
                        break;
                    }
                    else if (Convert.ToInt32(onstr + brstr) < sayi)
                    {
                        Console.WriteLine("Girdiğiniz sayı ikinci sayıdan daha büyük.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("İki sayı da birbirine eşittir.");
                    }
                }
            }


        }
    }
}
