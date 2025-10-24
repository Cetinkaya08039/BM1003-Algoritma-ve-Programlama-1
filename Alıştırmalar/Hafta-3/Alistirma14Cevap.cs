namespace Alistirma14Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan bir sayı alınız, bu sayının karesini ve küpünü hesaplayıp ekrana yazdırınız.
            */

            Console.Write("Bir sayı giriniz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Girdiğiniz sayının karesi: " + sayi*sayi);
            Console.WriteLine("Girdiğiniz sayının küpü: " + sayi*sayi*sayi);
        }
    }
}
