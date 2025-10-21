namespace Alistirma6Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Girdi olarak bir sayı alan ve 10'a kadar olan çarpım tablosunu yazdıran programı yazınız.
            Test verisi:
            Bir sayı girin: 8
            Beklenen çıktı :
            8x1 = 8
            8x2 = 16
            8×3 = 24...
            8x10 = 80
            */
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(sayi + "x" + i + " = " + sayi*i);
            }
        }
    }
}
