namespace Alistirma3Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            0 ile 100 arasındaki sayılardan 7 ile bölümünden kalan 3 olan sayıların kaç tane olduğunu hesaplayıp ekrana yazdıran programı yazınız.
            */
            int sayi = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%7 == 3)
                {
                    sayi++;
                }
            }
            Console.WriteLine("0 ile 100 arasına 7 ile bölümünden kalan 3 olan " + sayi + " sayı bulunmakta.");

        }
    }
}
