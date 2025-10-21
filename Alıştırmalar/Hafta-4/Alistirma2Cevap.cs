namespace Alistirma2Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10 sayıyı kullanıcıdan alıp bunların ortalamasını ve toplamını bulan bir C# programı yazın.
            */

            int[] sayi = new int[10];
            double toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i +1) + ". sayıyı giriniz: ");
                sayi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayi[i];
                Console.Clear();
            }
            Console.WriteLine("Sayıların toplamı = " + toplam + ", Ortalaması = " + toplam/10);

        }
    }
}
