namespace Alistirma3Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden girilen gün adına göre haftanın kaçıncı günü olduğunu bulan programı yazınız.
            
            Not:
            Kullanıcı hatalı bir gün girdiğinde, program uyarı mesajı vererek 2 saniye bekliyor
            ve ekranı temizleyip tekrar giriş yapılmasını istiyor. Böylece hatalı girişlerde kod otomatik olarak
            yeniden çalışmaya başlıyor.
            */

            while (true)
            {
                Console.Write("Hangi günde olduğunuzu giriniz: ");
                string gun = Console.ReadLine();
                if (gun == "Pazartesi" || gun == "pazartesi")
                {
                    Console.WriteLine("Pazartesi, haftanın 1. günüdür!");
                    break;
                }
                else if (gun == "Salı" || gun == "salı")
                {
                    Console.WriteLine("Salı, haftanın 2. günüdür!");
                    break;
                }
                else if (gun == "Çarşamba" || gun == "çarşamba")
                {
                    Console.WriteLine("Çarşamba, haftanın 3. günüdür!");
                    break;
                }
                else if (gun == "Perşembe" || gun == "perşembe")
                {
                    Console.WriteLine("Perşembe, haftanın 4. günüdür!");
                    break;
                }
                else if (gun == "Cuma" || gun == "cuma")
                {
                    Console.WriteLine("Cuma, haftanın 5. günüdür!");
                    break;
                }
                else if (gun == "Cumartesi" || gun == "cumartesi")
                {
                    Console.WriteLine("Cumartesi, haftanın 6. günüdür!");
                    break;
                }
                else if (gun == "Pazar" || gun == "pazar")
                {
                    Console.WriteLine("Pazar, haftanın 7. günüdür!");
                    break;
                }
                else
                {
                    Console.WriteLine("Gün adını düzgün giriniz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}
