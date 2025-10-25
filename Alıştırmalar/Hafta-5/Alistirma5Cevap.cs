namespace Alistirma5Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10 boyutlu bir diziyi rastgele sayılarla doldurunuz. Bu sayıların ortalaması ile en büyük ve en küçük sayının ortalamasını bularak, 
            bu 2 ortalamanın farkını bulan programı yazınız.
            */

            int[] dizi = new int[10];
            double kucuk = 21;
            double buyuk = 0;
            double toplam = 0;
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,20);
                if (dizi[i] > buyuk)
                {
                    buyuk = dizi[i];
                }
                else if (dizi[i] < kucuk)
                {
                    kucuk = dizi[i];
                }
                toplam += dizi[i];
            }
            Console.WriteLine("Dizideki tüm sayıların ortalaması: " + toplam/dizi.Length);
            Console.WriteLine("Dizideki en büyük ve en küçük sayının ortalaması: " + (buyuk+kucuk)/2);
        }
    }
}
