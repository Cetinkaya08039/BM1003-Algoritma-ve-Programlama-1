namespace Alistirma15Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan alınan sayının 0 ile 100 arasında olup olmadığını kontrol eden programı yazınız.
            */
            Console.Write("Bir sayı giriniz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());

            if (0 <= sayi && sayi < 100)
            {
                Console.WriteLine("Girdiğiniz sayı 0 ile 100 arasındadır.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı 0 ile yüz arasında değildir.");
            }
        }
    }
}
