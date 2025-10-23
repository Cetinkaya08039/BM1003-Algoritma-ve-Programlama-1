namespace Alistirma16Cevap.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Belirli bir karakterin ASCII değerini bulan bir C# Sharp programı yazın.
            ASCII tablosu: https://tr.wikipedia.org/wiki/ASCII
            Örnek Çıktı:
            1'in Ascii değeri: 49
            A'nın Ascii değeri: 65
            a'nın Ascii değeri: 97
            #'nin Ascii değeri: 35

            Not:
            Kullanıcı hatalı bir değer girdiğinde(birden fazla karakter girildiğinde), program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */
            while (true)
            {
                Console.Write("Bir karakter giriniz: ");
                string karakter = Console.ReadLine();
                if (karakter.Length == 1)
                {
                    char tochar = Convert.ToChar(karakter);
                    Console.WriteLine("Girdiğiniz karakterin ASCII değeri: " + Convert.ToByte(tochar));
                    break;

                }
                else
                {
                    Console.WriteLine("Yalnızca bir karakter girebilirsiniz.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

        }
    }
}
