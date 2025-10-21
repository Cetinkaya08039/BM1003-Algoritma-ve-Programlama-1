namespace Alistirma10Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan alınan bir sayının 5’e bölünüp bölünmediğini bulan programı yazınız.
            */

            Console.Write("Bir sayı giriniz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());

            if (sayi % 5 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı 5'e tam bölünüyor.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı 5'e tam bölünemiyor.");
            }
        }
    }
}
