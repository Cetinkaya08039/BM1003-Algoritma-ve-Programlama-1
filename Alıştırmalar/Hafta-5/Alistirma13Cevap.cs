namespace Alistirma13Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Tam sayılardan oluşan bir dizide aranan elemanın olup olmadığını bulan bir programı yazınız.
            */
            Console.Write("Dizide arayacağınız elemanı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[10];
            Random rnd = new Random();
            int miktar = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,100);
                if (dizi[i] == sayi)
                {
                    miktar++;
                }
            }
            if (miktar !=0) 
            {
                Console.WriteLine("Rastgele oluşturulan dizide " + sayi + " sayısı " + miktar + " kez geçmekte.");

            }
            else 
            {
                Console.WriteLine("Oluşturulan dizide " + sayi + " sayısı geçmemekte.");
            }
        }
    }
}
