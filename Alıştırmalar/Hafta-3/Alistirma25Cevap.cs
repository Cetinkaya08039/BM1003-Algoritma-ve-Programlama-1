namespace Alistirma25Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan toplam dakika alınız; saat ve dakika cinsinden yazdırınız(örn. 135 → 2 saat 15 dakika).
            */

            Console.Write("Dakikayı giriniz: ");
            int toplamdakika = Convert.ToInt32(Console.ReadLine());
            int saat = toplamdakika / 60;
            int dakika = toplamdakika % 60;

            Console.WriteLine(toplamdakika + " = " + saat + " saat " + dakika + " dakika");

        }
    }
}
