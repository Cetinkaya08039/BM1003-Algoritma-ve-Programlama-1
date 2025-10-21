namespace Alistirma10Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden girilen 10 adet sayıdan en büyüğünün kaçıncı sırada olduğunu yazan programı yazınız.
            */

            int[] dizi = new int[10];
            int buyuk = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write((i+1) + ". sayıyı giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (dizi[i] > buyuk)
                {
                    buyuk = dizi[i];
                }
            }

            for (int i = 0;i < dizi.Length;i++)
            {
                if (buyuk == dizi[i])
                {
                    Console.WriteLine("En büyük sayı olan " + buyuk + " bu dizide " + (i+1) + ". sırada.");
                }
            }
        }
    }
}
