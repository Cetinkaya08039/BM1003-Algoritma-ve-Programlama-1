namespace Alistirma19Cevap
{
    internal class Program
    {
        static int buyuk(int[] dizi)
        {
            int buyuk = 0;
            Console.Write("Dizi: ");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
                if (dizi[i] > buyuk)
                {
                    buyuk = dizi[i];
                }
            }
            return buyuk;
        }
        static void Main(string[] args)
        {
            /*
            Bir sayı dizisini parametre olarak alan ve en büyük elemanı bulup geri döndüren metodu yazınız.
            */
            Random rnd = new Random();
            int[] dizi = new int[rnd.Next(1, 11)];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 10);
            }
            Console.WriteLine("\n" + "Dizideki en büyük eleman: " + buyuk(dizi));

        }
    }
}
