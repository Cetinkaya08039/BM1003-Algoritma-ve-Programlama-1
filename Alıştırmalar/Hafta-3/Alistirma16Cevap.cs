namespace Alistirma16Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan alınan sayının hem pozitif hem de çift olup olmadığını bulan programı yazınız. 
            */
            Console.Write("Bir sayı giriniz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            if (sayi % 2 == 0 && sayi > 0)
            {
                Console.WriteLine("Girdiğiniz sayı hem pozitif hemde çifttir.");
            }
            else if (sayi % 2 == 1 && sayi > 0)
            {
                Console.WriteLine("Girdiğiniz sayı pozitiftir ancak çift değildir.");
            }
            else if (sayi % 2 == 0 && sayi < 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir ancak pozitif değildir.");
            }
            else if (sayi % 2 == -1 && sayi < 0)
            {
                Console.WriteLine("Girdiğiniz sayı ne çift ne de pozitiftir.");
            }
            else
            {
                Console.WriteLine("Hata!");
            }

        }
    }
}
