namespace Alistirma8Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            100 elemanlı bir dizi tanımlayınız. Bu diziye 0 - 10 arasında rastgele sayılar atayın. Dizideki
            elemanların ortalamasını bulup, dizi elemanlarından kaç tanesinin elde edilen bu ortalama
            değerine eşit olduğunu hesaplayınız.
            */
            int[] dizi = new int[100];
            Random rnd = new Random();
            int toplam = 0;
            int esitlik = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 10);
                toplam += dizi[i];
            }
            Console.WriteLine("Dizideki sayıların ortalaması: " + toplam/100);
            for (int i = 0;i < dizi.Length; i++)
            {
                if (dizi[i] == toplam/100)
                {
                    esitlik++;
                }
            }
            Console.WriteLine("Dizi elemanlarından " + esitlik + " tanesi ortalamaya eşit.");
        }
    }
}
