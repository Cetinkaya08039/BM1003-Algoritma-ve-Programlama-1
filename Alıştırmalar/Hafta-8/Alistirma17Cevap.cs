namespace Alistirma17Cevap
{
    internal class Program
    {
        static void yazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            /*
            Kendisine parametre olarak gönderilen bir tamsayı diziyi ekrana yazdıran bir metot yazınız.
            */
            Random rnd = new Random();
            int[] dizi = new int[rnd.Next(1, 11)];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 10);
            }
            yazdir(dizi);
        }
    }
}
