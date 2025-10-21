namespace Alistirma26Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan sıcaklık türü(Santigrat için C, Fahrenheit için F) ve sıcaklık değeri alınız.
            Eğer tür C ise, girilen sıcaklığı Fahrenheit’a;
            eğer tür F ise, girilen sıcaklığı Santigrat’a dönüştürüp ekrana yazdırınız.
            Geçersiz tür girilirse “Hatalı seçim!” mesajı veriniz.

            Not:
            Kullanıcı hatalı bir değer girdiğinde(sıcaklık türü C yada F'den başka bir değer olarak girildiğinde), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
                Console.Write("Sıcaklık türünü giriniz(Santigrat için C / Fahrenheit için F): ");
                string tur = Console.ReadLine();
                Console.Write("Sıcaklık değerini giriniz: ");
                double sicaklik = Convert.ToDouble(Console.ReadLine());

                /*
                Celsius'tan Fahrenheit'a dönüştürmek için °F = (°C × 9/5) + 32 formülünü kullanırız. 
                Tersine, Fahrenheit'tan Celsius'a dönüştürmek için °C = (°F - 32) × 5/9 formülünü uygularız.
                */

                double CtoF = (sicaklik * 9 / 5) + 32;
                double FtoC = (sicaklik - 32) * 5 / 9;
                if (tur == "C")
                {
                    Console.WriteLine("C -> F = " + CtoF);
                    break;
                }
                else if (tur == "F")
                {
                    Console.WriteLine("F -> C = " + FtoC);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı sıcaklık türü seçtiniz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}
