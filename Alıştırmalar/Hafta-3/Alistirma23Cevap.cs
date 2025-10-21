using System.Runtime.ConstrainedExecution;

namespace Alistirma23Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir çalışanın saatlik ücreti 200 TL.Kullanıcının girdiği çalışma saatine göre maaşı
            hesaplayınız.Eğer çalışma saati 40’tan fazlaysa fazla çalışılan her saat için % 50 zamlı
            ödeme yapılacaktır.
            */

            Console.Write("Kaç saat çalıştığınızı giriniz giriniz: ");
            double saat = Convert.ToDouble(Console.ReadLine());
            if (saat < 40)
            {
                Console.WriteLine("Maaşınız: " + saat*200 + " TL");
            }
            else if (40 <= saat)
            {
                Console.WriteLine("Maaşınız: " + saat*(200*150/100) + " TL");
            }
            else
            {
                Console.WriteLine("Hata!");
            }
        }
    }
}
