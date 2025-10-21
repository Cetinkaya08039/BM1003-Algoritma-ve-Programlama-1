using System.Threading.Tasks;

namespace Alistirma33Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Taksi ücreti: Açılış 30 TL + km başı 12 TL.Eğer saat(22–06)arasındaysa toplam ücrete % 20 gece zammı uygulayınız.
            Mesafe(km) ve saat alın, ücreti yazdırın.
            */
            while (true)
            {
                Console.Write("Kaç kilometre yol kat edileceğiniz giriniz: ");
                double km = Convert.ToDouble(Console.ReadLine());
                Console.Write("Saati giriniz(1/24): ");
                double saat = Convert.ToDouble(Console.ReadLine());
                if (22 <= saat && saat <= 24 || 1 <= saat && saat <= 6)
                {
                    Console.WriteLine("Taksi ücreti: " + (30 + km * 12) * 120 / 100);
                    break;
                }
                else if (6 < saat && saat < 22)
                {
                    Console.WriteLine("Taksi ücreti: " + (30 + km * 12));
                    break;
                }
                else
                {
                    Console.WriteLine("Saati düzgün giriniz!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}
