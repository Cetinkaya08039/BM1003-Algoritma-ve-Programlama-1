namespace Alistirma11Cevap
{
    internal class Program
    {
        static void us()
        {
            Console.Write("Üssü alınacak sayıyı girin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üssü girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + "^" + n + " = " + Math.Pow(x, n));
        }
        static void Main(string[] args)
        {
            /*
            Herhangi bir sayının herhangi bir dereceden kuvvetini(üssünü) bulan metodu yazınız.
            */
            us();

        }
    }
}
