namespace Alistirma4Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10 elemanlı bir sayı dizisinin en büyük ve en küçük elemanlarını ve kaçıncı sırada olduklarını bulan programı yazınız.
            */
            int[] dizi = new int[10];
            int kucuk = 21;
            int buyuk = 0;
            int kucuksira = 0;
            int buyuksira = 0;
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,20);
                if (dizi[i] < kucuk)
                {
                    kucuk = dizi[i];
                    kucuksira = i+1;
                }
                else if (dizi[i] > buyuk)
                {
                    buyuk = dizi[i];
                    buyuksira = i+1;
                }
            }
            Console.WriteLine("En küçük terim olan " + kucuk + " sayısı dizide " + kucuksira + ". sırada.");
            Console.WriteLine("En büyük terim olan " + buyuk + " sayısı dizide " + buyuksira + ". sırada.");

        }
    }
}
