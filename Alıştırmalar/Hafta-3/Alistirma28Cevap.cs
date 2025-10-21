namespace Alistirma28Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir sayının mutlak değerini ve aynı zamanda işaretini(pozitif/ negatif / sıfır) tek çıktıdagösteriniz (örn. “|−12 | = 12, Negatif”).
            */

            Console.Write("Bir sayı giriniz: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            if (sayi < 0)
            {
                Console.WriteLine("|" + sayi + "| = " + -sayi + ", Negatif.");
            }
            else if (sayi > 0)
            {
                Console.WriteLine("|" + sayi + "| = " + sayi + ", Pozitif.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı sıfırdır.");
            }
        }
    }
}
