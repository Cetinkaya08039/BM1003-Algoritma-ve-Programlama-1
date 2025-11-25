namespace Alistirma23Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Girilen bir sayının yaklaşık olarak kare kökünü hesaplayan programı yazınız.
            Örnek:
            5->yaklaşık karekökü 2.25
            */
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            double kok = Math.Sqrt(sayi);
            Console.WriteLine(sayi + "-> yaklaşık karekökü " + kok);

        }
    }
}
