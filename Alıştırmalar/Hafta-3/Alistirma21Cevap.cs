namespace Alistirma21Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan AA, BB, CC, FF gibi bir not alınsın. Buna göre ekrana açıklama yazdırınız.
            "AA → Çok İyi"
            "BB → İyi"
            "CC → Orta"
            "FF → Başarısız"

            Not:
            Kullanıcı hatalı bir değer girdiğinde, program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
                Console.Write("Notunuzu giriniz(AA/BB/CC/FF): ");
                string not = Console.ReadLine();
                if (not == "AA")
                {
                    Console.WriteLine("AA - Çok İyi");
                    break;
                }
                else if (not == "BB")
                {
                    Console.WriteLine("BB - İyi");
                    break;
                }
                else if (not == "CC")
                {
                    Console.WriteLine("CC - Orta");
                    break;
                }
                else if (not == "FF")
                {
                    Console.WriteLine("FF - Başarısız");
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen belirtilen şekilde notunuzu giriniz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

        }
    }
}
