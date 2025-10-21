namespace Alistirma34Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan kargonun ağırlığını(kg) ve konum bilgisini(“şehir içi” veya “şehir dışı”) alınız.
            Kargo ücreti aşağıdaki kurallara göre hesaplanacaktır:
            0–1 kg arası → 30 TL
            1–5 kg arası → 50 TL
            5 kg üzeri → 50 TL + (ağırlık − 5) × 8 TL
            Eğer konum şehir dışı ise, hesaplanan tutarın üzerine % 15 ekleyiniz.Ağırlık 0 veya negatif
            girilirse “Geçersiz giriş!” mesajı veriniz.

            Not:
            Kullanıcı hatalı bir değer girdiğinde, program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
                Console.Write("Kargonuzun ağırlığını kilogram cinsinden giriniz: ");
                double kg = Convert.ToDouble(Console.ReadLine());
                Console.Write("konum bilgisini giriniz(Şehir içi/Şehir dışı): ");
                string konum = Console.ReadLine();

                if ((0 <= kg && kg <= 1) && konum == "Şehir içi")
                {
                    Console.WriteLine("Kargo ücreti: 30 TL'dir.");
                    break;
                }
                else if ((1 < kg && kg <= 5) && konum == "Şehir içi")
                {
                    Console.WriteLine("Kargo ücreti: 50 TL'dir.");
                    break;
                }
                else if ((5 < kg) && konum == "Şehir içi")
                {
                    Console.WriteLine("Kargo ücreti: " + (50 + (kg - 5) * 8 + " TL'dir."));
                    break;
                }
                else if ((0 <= kg && kg <= 1) && konum == "Şehir dışı")
                {
                    Console.WriteLine("Kargo ücreti: 34,5 TL'dir.");
                    break;
                }
                else if ((1 < kg && kg <= 5) && konum == "Şehir dışı")
                {
                    Console.WriteLine("Kargo ücreti: 57,5 TL'dir.");
                    break;
                }
                else if ((5 < kg) && konum == "Şehir dışı")
                {
                    Console.WriteLine("Kargo ücreti: " + ((50 + (kg - 5) * 8) * 115 / 100 + " TL'dir."));
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı değer girildi!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}
