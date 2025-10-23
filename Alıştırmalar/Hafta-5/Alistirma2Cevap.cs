namespace Alistirma2Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Rastgele sayılarla oluşturulan 20 elemanlı bir dizinin, elemanlarından kaç tanesinin dışarıdan girilen bir sayıdan küçük olduğunu bulunuz.
            */
            int[] dizi = new int[20];
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int miktar = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,100);
                if (dizi[i] < sayi)
                {
                    miktar++;
                }
            }
            Console.WriteLine(miktar);
        }
    }
}
