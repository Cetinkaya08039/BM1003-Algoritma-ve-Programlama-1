namespace Alistirma7Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10 elemanlı bir sayı dizisinde en küçük elemanının bu dizinin kaçıncı elemanı olduğunu bulan programı yazınız.
            */
            int[] dizi = new int[10];
            Random rnd = new Random();
            int kucuk = 21;
            int sira = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,20);
                if (dizi[i] < kucuk)
                {
                    kucuk = dizi[i];
                    sira = i+1;
                }
            }
            Console.WriteLine("En küçük eleman olan " + kucuk + " sayisi " + sira + ". sırada.");
        }
    }
}
